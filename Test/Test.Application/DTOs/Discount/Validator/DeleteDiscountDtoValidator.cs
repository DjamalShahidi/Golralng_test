using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Contracts.Persistence;
using Test.Application.DTOs.PreInvoiceHeader;

namespace Test.Application.DTOs.Discount.Validator
{
    public class DeleteDiscountDtoValidator : AbstractValidator<DeleteDiscountDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteDiscountDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            RuleFor(a => a.Id)
               .GreaterThan(0).WithMessage("Invalid Id")
               .MustAsync(async (Id, token) =>
               {
                   return await _unitOfWork.DiscountRepository.IsExist(Id);

               }).WithMessage("Discount with this id not exist");
        }
    }
}
