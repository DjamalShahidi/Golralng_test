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
    public class AddPreInvoiceHeaderDtoValidator : AbstractValidator<AddPreInvoiceHeaderDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddPreInvoiceHeaderDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            RuleFor(a => a.SalesLineId)
             .GreaterThan(0).WithMessage("Invalid SalesLineId");

            RuleFor(a => a.SellerId)
              .GreaterThan(0).WithMessage("Invalid SellerId");

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
