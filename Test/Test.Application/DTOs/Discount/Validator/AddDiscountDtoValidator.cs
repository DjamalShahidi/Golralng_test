using FluentValidation;
using Test.Application.Contracts.Persistence;
using Test.Domain;

namespace Test.Application.DTOs.Discount.Validator
{
    public class AddDiscountDtoValidator : AbstractValidator<AddDiscountDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddDiscountDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            double totalPreInvoiceAmount = 0;

            double totalDiscountAmount = 0;


            RuleFor(a => a.PreInvoiceHeaderId)
                .GreaterThan(0).WithMessage("Invalid PreInvoiceHeaderId")
                .MustAsync(async (id, token) =>
                {

                    var header = await _unitOfWork.PreInvoiceHeaderRepository.GetAsync(id);
                    if (header == null)
                    {
                        return false;
                    }
                    else if (header.Status == PreInvoiceHeaderStatus.Final)
                    {
                        return false;

                    }

                    totalPreInvoiceAmount = await _unitOfWork.PreInvoiceDetailRepository.GetTotalPrice(id);
                    totalDiscountAmount = await _unitOfWork.DiscountRepository.GetTotalDiscount(id);
                    return true;

                }).WithMessage("Invalid PreInvoiceHeaderId");


            RuleFor(a => a.Amount)
               .GreaterThan(0).WithMessage("Invalid Amount")
               .Must((dto, amount) =>
               {
                   double totalAmount = amount + totalDiscountAmount;
                   return totalAmount <= totalPreInvoiceAmount;
               }).WithMessage("Total amount exceeds ");



            RuleFor(a => a.Type)
             .IsInEnum().WithMessage("Invalid Type")
             .Must((model, type) =>
             {
                 if (type==DiscountType.Row )
                 {
                     if (model.PreInvoiceDetailId == null)
                     {
                         return false;
                     }
                 }
                 else
                 {
                     if (model.PreInvoiceDetailId != null)
                     {
                         return false;
                     }
                 }
                 return true;
             })
             .WithMessage("In Row type detail must be send ,and in Document type detail must be ignore");

            
        }
    }
}
