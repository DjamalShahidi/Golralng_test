using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Contracts.Persistence;
using Test.Application.DTOs.PreInvoiceHeader;
using Test.Domain;

namespace Test.Application.DTOs.Discount.Validator
{
    public class AddDiscountDtoValidator : AbstractValidator<AddDiscountDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddDiscountDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            //RuleFor(a => a.PreInvoiceDetailId)
            // .GreaterThan(0).WithMessage("Invalid ProductId");

            RuleFor(a => a.PreInvoiceHeaderId)
              .GreaterThan(0).WithMessage("Invalid PreInvoiceHeaderId");

            RuleFor(a => a.Amount)
              .GreaterThan(0).WithMessage("Invalid Amount");

            //RuleFor(a => a.Type)
            //     .IsInEnum(DiscountType).WithMessage("Invalid Type");

            //RuleFor(a => a.GetHashCode)
            // .NotNull().NotEmpty().WithMessage("Code must be send");

            //RuleFor(a => a.CategoryId)
            //     .GreaterThan(0).WithMessage("Invalid CategoryId")
            //     .MustAsync(async (id, token) =>
            //     {
            //         var isExist = await _unitOfWork.CategoryRepository.IsExist(id);
            //         return isExist;

            //     }).WithMessage("Invalid CategoryId");

            //RuleFor(a => a.FeatureIds)
            //  .NotNull().NotEmpty().WithMessage("Invalid FeatureId")
            //  .MustAsync(async (ids, token) =>
            //  {
            //      foreach (var id in ids)
            //      {
            //          var isExist = await _unitOfWork.FeaturesRepository.IsExist(id);
            //          if (!isExist)
            //          {
            //              return false;
            //          }
            //      }

            //      return true;
            //  }).WithMessage("Invalid FeatureId");
        }
    }
}
