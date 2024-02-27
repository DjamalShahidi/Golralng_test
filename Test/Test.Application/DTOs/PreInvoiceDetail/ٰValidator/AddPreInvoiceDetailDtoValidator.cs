using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Contracts.Persistence;
using Test.Application.DTOs.Product;
using Test.Domain;

namespace Test.Application.DTOs.PreInvoiceHeader._ٰValidator
{
    public class AddPreInvoiceDetailDtoValidator : AbstractValidator<AddPreInvoiceDetailDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddPreInvoiceDetailDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            Domain.PreInvoiceHeader preInvoiceHeader = null;

            RuleFor(a => a.PreInvoiceHeaderId)
                .GreaterThan(0).WithMessage("Invalid PreInvoiceHeaderId")
                .MustAsync(async (id, token) =>
                {
                    preInvoiceHeader = await _unitOfWork.PreInvoiceHeaderRepository.GetAsync(id);
                    if (preInvoiceHeader == null)
                    {
                        return false;
                    }
                    return true;

                }).WithMessage("Invalid PreInvoiceHeaderId");



            RuleFor(a => a.ProductId)
             .GreaterThan(0).WithMessage("Invalid ProductId")
             .MustAsync(async (id, token) =>
                 {
                     var isExist = await _unitOfWork.ProductSaleLineRepository.IsExist(id, preInvoiceHeader.SalesLineId);
                     return isExist;

                 }).WithMessage("Not Exist product in this line")
             .MustAsync(async (id, token) =>
             {
                 var isExist = await _unitOfWork.PreInvoiceDetailRepository.DublicateProduct(id, preInvoiceHeader.Id);
                 if (isExist)
                 {
                     return false;
                 }
                 return true;

             }).WithMessage("Not Exist product in this line");

            RuleFor(a => a.Price)
              .GreaterThan(0).WithMessage("Invalid Price");

            RuleFor(a => a.Count)
              .GreaterThan(0).WithMessage("Invalid Count");

        }
    }
}
