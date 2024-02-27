using FluentValidation;
using Test.Application.Contracts.Persistence;
using Test.Domain;

namespace Test.Application.DTOs.PreInvoiceDetail.Validator
{
    public class DeletePreInvoiceDetailDtoValidator : AbstractValidator<DeletePreInvoiceDetailDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeletePreInvoiceDetailDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            RuleFor(a => a.Id)
                 .GreaterThan(0).WithMessage("Invalid Id")
                 .MustAsync(async (id, token) =>
                 {
                     var preInvoiceDetail = await _unitOfWork.PreInvoiceDetailRepository.GetAsync(id);

                     if (preInvoiceDetail == null)
                     {
                         return false;
                     }
                     var preInvoiceHeader = await _unitOfWork.PreInvoiceHeaderRepository.GetAsync(preInvoiceDetail.PreInvoiceHeaderId);

                     if (preInvoiceHeader == null)
                     {
                         return false;
                     }
                     else if (preInvoiceHeader.Status == PreInvoiceHeaderStatus.Final)
                     {
                         return false;
                     }
                     return true;

                 }).WithMessage("NotExist PreInvoiceDeail or PreInvoiceHeader status is Final");
        }
    }
}
