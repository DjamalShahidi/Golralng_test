using MediatR;
using Store.Application.Responses;
using Test.Application.DTOs.Discount;
using Test.Application.DTOs.PreInvoiceHeader;

namespace Test.Application.Logic.PreInvoiceHeader.Requests.Commands
{
    public class UpdateDiscount : IRequest<Response>
    {
        public UpdateDiscountDto Request { get; set; }
    }
}
