using FluentValidation;
using Test.Application.Contracts.Persistence;

namespace Test.Application.DTOs.PreInvoiceHeader.Validator
{
    public class UpdatePreInvoiceHeaderDtoValidator : AbstractValidator<UpdatePreInvoiceHeaderDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdatePreInvoiceHeaderDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            RuleFor(a => a.SalesLineId)
                   .GreaterThan(0).WithMessage("Invalid SalesLineId")
                   .MustAsync(async (saleLineId, token) =>
                   {
                       var isExist = await _unitOfWork.SaleLineRepository.IsExist(saleLineId);
                       if (!isExist)
                       {
                           return false;
                       }
                       return true;
                   }).WithMessage("SaleLine with this id not exist");

            RuleFor(a => a.Id)
               .GreaterThan(0).WithMessage("Invalid Id")
               .MustAsync(async (model, Id, token) =>
               {
                   var preInvoiceHeader = await _unitOfWork.PreInvoiceHeaderRepository.GetAsync(Id);

                   if (preInvoiceHeader == null)
                   {
                       return false;
                   }
                   if (preInvoiceHeader.Status == Domain.PreInvoiceHeaderStatus.Final)
                   {
                       return false;
                   }
                   var isExist = await _unitOfWork.PreInvoiceDetailRepository.IsExistWithThisPreInvoiceHeaderId(preInvoiceHeader.Id);

                   if (isExist && preInvoiceHeader.SalesLineId != model.SalesLineId)
                   {
                       return false;
                   }
                   return true;

               }).WithMessage("Can not be update");


            RuleFor(a => a.SellerId)
                   .GreaterThan(0).WithMessage("Invalid SellerId")
                   .MustAsync(async (model, sellerId, token) =>
                   {
                       var isExist = await _unitOfWork.SellerRepository.IsExist(sellerId);
                       if (!isExist)
                       {
                           return false;
                       }
                       var haveRelation = await _unitOfWork.SellerRepository.IsExist(sellerId, model.SalesLineId);
                       if (!haveRelation)
                       {
                           return false;
                       }
                       return true;
                   }).WithMessage("This Seller id invalid or seller dose not belong to  this line");

            RuleFor(a => a.Customer.FirstName)
              .NotNull().NotEmpty().MaximumLength(50).MaximumLength(1).WithMessage("Invalid Customer first name");

            RuleFor(a => a.Customer.LastName)
              .NotNull().NotEmpty().MaximumLength(50).MaximumLength(1).WithMessage("Invalid Customer last name");
        }
    }
}
