using AutoMapper;
using MediatR;
using Store.Application.Responses;
using Test.Application.Contracts.Persistence;
using Test.Application.DTOs.PreInvoiceHeader._ٰValidator;
using Test.Application.Logic.PreInvoiceHeader.Requests.Commands;

namespace Test.Application.Logic.PreInvoiceHeader.Handlers.Commands
{
    public class AddPreInvoiceHeaderHandler : IRequestHandler<AddPreInvoiceHeader, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AddPreInvoiceHeaderHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(AddPreInvoiceHeader request, CancellationToken cancellationToken)
        {
            var validator = new AddPreInvoiceHeaderDtoValidator(_unitOfWork);

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

            var preInvoiceHeader = _mapper.Map<Domain.PreInvoiceHeader>(request.Request);

            preInvoiceHeader = await _unitOfWork.PreInvoiceHeaderRepository.AddAsync(preInvoiceHeader);

            await _unitOfWork.Save(cancellationToken);

            return new Response()
            {
                IsSuccess = true,
                Result = preInvoiceHeader.Id
            };
        }

    }
}
