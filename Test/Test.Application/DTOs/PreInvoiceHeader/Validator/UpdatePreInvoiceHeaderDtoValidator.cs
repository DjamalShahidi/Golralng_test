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
                .GreaterThan(0).WithMessage("Invalid SalesLineId");

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
