using MediatR;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Responses;
using Test.Application.DTOs.Discount;
using Test.Application.DTOs.PreInvoiceDetail;
using Test.Application.Logic.Discount.Requests.Commands;
using Test.Application.Logic.PreInvoiceDetail.Requests.Commands;
using Test.Application.Logic.PreInvoiceHeader.Requests.Commands;
using Test.Application.Logic.PreInvoiceHeader.Requests.Queries;

namespace Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DiscountController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost]
        public async Task<Response> AddDiscount([FromBody] AddDiscount addDiscount)
        {
            return await _mediator.Send(addDiscount);
        }

        [HttpGet]
        public async Task<Response> GetDiscount([FromQuery] GetDiscount getDiscount)
        {
            return await _mediator.Send(getDiscount);
        }

        [HttpPut]
        public async Task<Response> UpdateDiscount([FromBody] UpdateDiscount updateDiscount)
        {
            return await _mediator.Send(updateDiscount);
        }

        [HttpDelete]
        public async Task<Response> DeleteDiscount([FromQuery] int id)
        {
            return await _mediator.Send(new DeleteDiscount()
            {
                Request = new DeleteDiscountDto()
                {
                    Id = id
                }
            });
        }
    }
}
