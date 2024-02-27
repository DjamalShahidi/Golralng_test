using MediatR;
using Store.Application.Responses;
using Test.Application.DTOs.Discount;
using Test.Application.DTOs.PreInvoiceHeader;

namespace Test.Application.Logic.PreInvoiceHeader.Requests.Commands
{
    public class AddDiscount : IRequest<Response>
    {
        public AddDiscountDto Request { get; set; }
    }
}
