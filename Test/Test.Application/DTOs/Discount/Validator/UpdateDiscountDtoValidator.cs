using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Contracts.Persistence;
using Test.Domain;

namespace Test.Application.DTOs.Discount.Validator
{
    public class UpdateDiscountDtoValidator : AbstractValidator<UpdateDiscountDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateDiscountDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            double totalPreInvoiceAmount = 0;

            List<Domain.Discount> discounts = new List<Domain.Discount>();

            RuleFor(a => a.Id)
                .GreaterThan(0).WithMessage("Invalid Id")
                .MustAsync(async (id, token) =>
                {
                    var dicount = await _unitOfWork.DiscountRepository.GetAsync(id);

                    if (dicount == null)
                    {
                        return false;
                    }

                    var preInvoiceHeader = await _unitOfWork.PreInvoiceHeaderRepository.GetAsync(dicount.PreInvoiceHeaderId);

                    totalPreInvoiceAmount = await _unitOfWork.PreInvoiceDetailRepository.GetTotalPrice(preInvoiceHeader.Id);

                    discounts = await _unitOfWork.DiscountRepository.GetAsyncWithPreInvoiceHeaderId(preInvoiceHeader.Id);

                    if (preInvoiceHeader == null  || preInvoiceHeader.Status== PreInvoiceHeaderStatus.Final)
                    {
                        return false;
                    }
                    return true;

                }).WithMessage("Invalid PreInvoiceHeaderId");


            RuleFor(a => a.Amount)
               .GreaterThan(0).WithMessage("Invalid Amount")
               .Must((model, amount) =>
               {
                   double totalAmount = amount + discounts.Where(a=>a.Id!= model.Id).Sum(a=>a.Amount);
                   return totalAmount <= totalPreInvoiceAmount;
               }).WithMessage("Discount grater than price");

            RuleFor(a => a.Type)
                 .IsInEnum().WithMessage("Invalid Type")
                 .MustAsync(async(model, type,token) =>
                 {
                     if (type == DiscountType.Row)
                     {
                         if (model.PreInvoiceDetailId == null || model.PreInvoiceDetailId <= 0)
                         {
                             return false;
                         }
                         return await _unitOfWork.PreInvoiceDetailRepository.IsExist(model.PreInvoiceDetailId.Value);
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
                 .WithMessage("In Row type detail must be send ,and in Document type detail must be ignore Or PreInvoiceDetailId with this id not exist");





        }
    }
}
