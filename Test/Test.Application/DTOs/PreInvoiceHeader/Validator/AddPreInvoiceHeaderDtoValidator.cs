﻿using FluentValidation;
using Test.Application.Contracts.Persistence;

namespace Test.Application.DTOs.PreInvoiceHeader.Validator
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
                   .GreaterThan(0).WithMessage("Invalid SellerId")
                   .MustAsync(async (model, sellerId, token) =>
                   {
                       var isExist = await _unitOfWork.SellerRepository.IsExist(sellerId, model.SalesLineId);
                       if (!isExist)
                       {
                           return false;
                       }
                       return true;
                   }).WithMessage("Not Exist SellerId in this SalesLine");

            RuleFor(a => a.Customer.FirstName)
             .NotNull().NotEmpty().WithMessage("Invalid Customer first name");

            RuleFor(a => a.Customer.LastName)
           .NotNull().NotEmpty().WithMessage("Invalid Customer last name");
        }

    }
}
