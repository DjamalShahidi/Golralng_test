using FluentValidation;
using Test.Application.Contracts.Persistence;
using Test.Domain;

namespace Test.Application.DTOs.PreInvoiceDetail.Validator
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
                    else if (preInvoiceHeader.Status ==PreInvoiceHeaderStatus.Final )
                    {
                        return false;
                    }
                    return true;

                }).WithMessage("NotExist PreInvoiceHeaderId");



            RuleFor(a => a.ProductId)
             .GreaterThan(0).WithMessage("Invalid ProductId")
             .MustAsync(async (id, token) =>
                 {
                     if (preInvoiceHeader!=null)
                     {
                         var isExist = await _unitOfWork.ProductSaleLineRepository.IsExist(id, preInvoiceHeader.SalesLineId);
                         return isExist;
                     }
                     else
                     {
                         return false;
                     }
                 }).WithMessage("Not Exist product in this line")
             .MustAsync(async (id, token) =>
             {
                 if (preInvoiceHeader != null)
                 {
                     var isExist = await _unitOfWork.PreInvoiceDetailRepository.CheckDublicateProductForAdd(preInvoiceHeader.Id, id);
                     if (isExist)
                     {
                         return false;
                     }
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             }).WithMessage("Dublicate product");

            RuleFor(a => a.Price)
              .GreaterThan(0).WithMessage("Invalid Price");

            RuleFor(a => a.Count)
              .GreaterThan(0).WithMessage("Invalid Count");

        }
    }
}
