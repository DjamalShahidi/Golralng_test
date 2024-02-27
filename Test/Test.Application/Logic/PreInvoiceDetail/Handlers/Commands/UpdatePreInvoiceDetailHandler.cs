using AutoMapper;
using MediatR;
using Store.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Contracts.Persistence;
using Test.Application.DTOs.PreInvoiceDetail._ٰValidator;
using Test.Application.DTOs.PreInvoiceHeader._ٰValidator;
using Test.Application.Logic.PreInvoiceHeader.Requests.Commands;

namespace Test.Application.Logic.PreInvoiceDetail.Handlers.Commands
{
    public class UpdatePreInvoiceDetailHandler : IRequestHandler<UpdatePreInvoiceDetail, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdatePreInvoiceDetailHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdatePreInvoiceDetail request, CancellationToken cancellationToken)
        {
            var validator = new UpdatePreInvoiceDetailDtoValidator(_unitOfWork);

            var validatorResult = await validator.ValidateAsync(request.Request);

            if (validatorResult.IsValid == false)
            {
                return new Response()
                {
                    ErrorMessages = validatorResult.Errors.Select(a => a.ErrorMessage).ToList(),
                    IsSuccess = false,
                    Result = null
                };
            }


            var preInvoiceDetail = await _unitOfWork.PreInvoiceDetailRepository.GetAsync(request.Request.Id);

            preInvoiceDetail = _mapper.Map<Domain.PreInvoiceDetail>(request.Request);

            _unitOfWork.PreInvoiceDetailRepository.Update(preInvoiceDetail);

            await _unitOfWork.Save(cancellationToken);

            return new Response()
            {
                IsSuccess = true,
                Result = preInvoiceDetail.Id
            };
        }

    }
}
