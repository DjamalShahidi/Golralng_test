using FluentValidation;
using Test.Application.Contracts.Persistence;

namespace Test.Application.DTOs.PreInvoiceHeader.Validator
{
    public class UpdatePreInvoiceHeaderStatusDtoValidator : AbstractValidator<UpdatePreInvoiceHeaderStatusDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdatePreInvoiceHeaderStatusDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork= unitOfWork;

            RuleFor(a => a.PreInvoiceHeaderId)
                       .GreaterThan(0).WithMessage("Invalid PreInvoiceHeaderId")
                       .MustAsync(async (id, token) =>
                       {
                           var header = await _unitOfWork.PreInvoiceHeaderRepository.GetAsync(id);
                           if (header==null)
                           {
                               return false;
                           }
                           else if (header.Status==Domain.PreInvoiceHeaderStatus.Final)
                           {
                               return false;
                           }
                           else
                           {
                               var totalPreInvoiceAmount = await _unitOfWork.PreInvoiceDetailRepository.GetFinalTotalPrice(header.CustomerId);
                               var totalDiscountAmount = await _unitOfWork.DiscountRepository.GetFinalTotalDiscount(header.CustomerId);

                               if (totalPreInvoiceAmount- totalDiscountAmount>1_000_000)
                               {
                                   return false;
                               }
                               return true;

                           }
                       }).WithMessage("Can not be update");
        }

    }
}
