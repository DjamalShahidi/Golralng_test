using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Contracts.Persistence;
using Test.Application.Logic.PreInvoiceHeader.Requests.Commands;

namespace Test.Application.DTOs.PreInvoiceHeader.Validator
{
    public class DeletePreInvoiceHeaderDtoValidator : AbstractValidator<DeletePreInvoiceHeaderDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeletePreInvoiceHeaderDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            RuleFor(a => a.PreInvoiceHeaderId)
               .GreaterThan(0).WithMessage("Invalid Id")
               .MustAsync(async (Id, token) =>
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
                   return true;

               }).WithMessage("Can not be delete");
        }
    }
}
