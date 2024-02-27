using MediatR;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Responses;

namespace Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreInvoiceDetailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PreInvoiceDetailController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        //[HttpPost]
        //public async Task<Response> AddPreInvoiceDetail([FromBody] AddProduct addProduct)
        //{
        //    return await _mediator.Send(addProduct);
        //}

        //[HttpGet]
        //public async Task<Response> GetPreInvoiceDetail([FromQuery] GetProducts getProducts)
        //{
        //    return await _mediator.Send(getProducts);
        //}

        //[HttpPut]
        //public async Task<Response> UpdatePreInvoiceDetail([FromBody] AddProduct addProduct)
        //{
        //    return await _mediator.Send(addProduct);
        //}

        //[HttpDelete]
        //public async Task<Response> DeletePreInvoiceDetail([FromBody] AddProduct addProduct)
        //{
        //    return await _mediator.Send(addProduct);
        //}
    }
}
