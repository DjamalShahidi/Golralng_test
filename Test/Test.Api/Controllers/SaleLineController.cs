using MediatR;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Responses;
using Test.Application.Logic.PreInvoiceHeader.Requests.Commands;
using Test.Application.Logic.SalesLine.Requests.Queries;

namespace Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleLineController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SaleLineController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<Response> Get()
        {
            return await _mediator.Send(new GetSaleLines());
        }

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
