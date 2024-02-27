using MediatR;
using Store.Application.Responses;
using Test.Application.Contracts.Persistence;
using Test.Application.DTOs.PreInvoiceHeader.Validator;
using Test.Application.Logic.PreInvoiceHeader.Requests.Commands;

namespace Test.Application.Logic.PreInvoiceHeader.Handlers.Commands
{
    public class DeletePreInvoiceHeaderHandler : IRequestHandler<DeletePreInvoiceHeader, Response>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeletePreInvoiceHeaderHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(DeletePreInvoiceHeader request, CancellationToken cancellationToken)
        {
            try
            {

                var validator = new DeletePreInvoiceHeaderDtoValidator(_unitOfWork);

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

                var preInvoiceHeader = await _unitOfWork.PreInvoiceHeaderRepository.GetAsync(request.Request.Id);

                _unitOfWork.PreInvoiceHeaderRepository.Delete(preInvoiceHeader);

                await _unitOfWork.Save(cancellationToken);

                return new Response()
                {
                    IsSuccess = true
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
