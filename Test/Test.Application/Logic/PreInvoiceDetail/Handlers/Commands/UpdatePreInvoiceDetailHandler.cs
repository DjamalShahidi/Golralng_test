using AutoMapper;
using MediatR;
using Store.Application.Responses;
using Test.Application.Contracts.Persistence;
using Test.Application.DTOs.PreInvoiceDetail.Validator;
using Test.Application.Logic.PreInvoiceHeader.Requests.Commands;
using Test.Domain;

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
            try
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
            catch (Exception ex)
            {
                return new Response()
                {
                    IsSuccess = false,
                    ErrorMessages = [ex.Message]
                };
            }
        }
    }
}
