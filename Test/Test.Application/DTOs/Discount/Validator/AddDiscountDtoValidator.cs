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

                    var isExist = await _unitOfWork.PreInvoiceHeaderRepository.IsExist(id);
                    if (isExist==false)
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
             .When(a => a.Type == DiscountType.Row)
             .Must((dto, type) => dto.PreInvoiceDetailId.HasValue)
             .WithMessage("PreInvoiceDetailId is required for Row")
             .When(a => a.Type == DiscountType.Document)
             .Must((dto, type) => dto.PreInvoiceDetailId == null)
             .WithMessage("PreInvoiceDetailId must be null for Document");


    

            RuleFor(a => a.Amount)
              .GreaterThan(0).WithMessage("Invalid Amount");

            
        }
    }
}
