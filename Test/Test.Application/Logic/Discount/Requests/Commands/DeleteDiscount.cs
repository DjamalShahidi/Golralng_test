using MediatR;
using Store.Application.Responses;
using Test.Application.DTOs.Discount;

namespace Test.Application.Logic.Discount.Requests.Commands
{
    public class DeleteDiscount : IRequest<Response>
    {
        public DeleteDiscountDto Request { get; set; }

    }
}
