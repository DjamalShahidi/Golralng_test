using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Contracts.Persistence;
using Test.Application.DTOs.Product;

namespace Test.Application.DTOs.PreInvoiceHeader._ٰValidator
{
    public class AddPreInvoiceDetailDtoValidator : AbstractValidator<AddPreInvoiceDetailDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddPreInvoiceDetailDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            RuleFor(a => a.ProductId)
             .GreaterThan(0).WithMessage("Invalid ProductId");

            RuleFor(a => a.Price)
              .GreaterThan(0).WithMessage("Invalid Price");

            RuleFor(a => a.Count)
              .GreaterThan(0).WithMessage("Invalid Count");

            RuleFor(a => a.PreInvoiceHeaderId)
                .GreaterThan(0).WithMessage("Invalid PreInvoiceHeaderId");
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
