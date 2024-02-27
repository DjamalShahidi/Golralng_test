using FluentValidation;
using Test.Application.Contracts.Persistence;

namespace Test.Application.DTOs.PreInvoiceHeader.Validator
{
    public class UpdatePreInvoiceHeaderStatusDtoValidator : AbstractValidator<UpdatePreInvoiceHeaderStatusDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly double MAX = 1_000_000;

        public UpdatePreInvoiceHeaderStatusDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            RuleFor(a => a.PreInvoiceHeaderId)
                       .GreaterThan(0).WithMessage("Invalid PreInvoiceHeaderId")
                       .MustAsync(async (id, token) =>
                       {
                           var preInvoiceHeader = await _unitOfWork.PreInvoiceHeaderRepository.GetAsync(id);

                           if (preInvoiceHeader == null)
                           {
                               return false;
                           }
                           if (preInvoiceHeader.Status == Domain.PreInvoiceHeaderStatus.Final)
                           {
                               return false;
                           }

                           var preDetailIsExist = await _unitOfWork.PreInvoiceDetailRepository.IsExistWithThisPreInvoiceHeaderId(id);

                           if (preDetailIsExist==false)
                           {
                               return false;
                           }

                           var totalPreInvoiceAmount = await _unitOfWork.PreInvoiceDetailRepository.GetFinalTotalPrice(preInvoiceHeader.CustomerId);

                           var totalDiscountAmount = await _unitOfWork.DiscountRepository.GetFinalTotalDiscount(preInvoiceHeader.CustomerId);

                           if (totalPreInvoiceAmount - totalDiscountAmount > MAX)
                           {
                               return false;
                           }
                           return true;


                       }).WithMessage("Can not be update");
        }

    }
}
