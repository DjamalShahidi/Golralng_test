using MediatR;
using Store.Application.Responses;
using Test.Application.DTOs.Discount;

namespace Test.Application.Logic.PreInvoiceHeader.Requests.Queries
{
    public class GetDiscount : IRequest<Response>
    {
        public GetDiscountRequestDto Request { get; set; }
    }
}
