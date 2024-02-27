using MediatR;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Responses;

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

        //[HttpPost]
        //public async Task<Response> AddDiscount([FromBody] AddProduct addProduct)
        //{
        //    return await _mediator.Send(addProduct);
        //}

        //[HttpGet]
        //public async Task<Response> GetDiscount([FromQuery] GetProducts getProducts)
        //{
        //    return await _mediator.Send(getProducts);
        //}

        //[HttpPut]
        //public async Task<Response> UpdateDiscount([FromBody] AddProduct addProduct)
        //{
        //    return await _mediator.Send(addProduct);
        //}

        //[HttpDelete]
        //public async Task<Response> DeleteDiscount([FromBody] AddProduct addProduct)
        //{
        //    return await _mediator.Send(addProduct);
        //}
    }
}
