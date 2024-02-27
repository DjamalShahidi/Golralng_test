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

            double totalDiscountAmount = 0;

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

                    if (preInvoiceHeader == null  || preInvoiceHeader.Status== PreInvoiceHeaderStatus.Final)
                    {
                        return false;
                    }

                    totalPreInvoiceAmount = await _unitOfWork.PreInvoiceDetailRepository.GetTotalPrice(preInvoiceHeader.Id);

                    totalDiscountAmount = await _unitOfWork.DiscountRepository.GetTotalDiscount(preInvoiceHeader.Id);

                    return true;

                }).WithMessage("Invalid PreInvoiceHeaderId");


            RuleFor(a => a.Amount)
               .GreaterThan(0).WithMessage("Invalid Amount")
               .Must((dto, amount) =>
               {
                   double totalAmount = amount + totalDiscountAmount;
                   return totalAmount <= totalPreInvoiceAmount;
               }).WithMessage("Discount grater than price");

            RuleFor(a => a.Type)
              .IsInEnum().WithMessage("Invalid Type")
              .Must((model, type) =>
              {
                  if (type == DiscountType.Row)
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
