using MediatR;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Responses;
using Test.Application.DTOs.PreInvoiceHeader;
using Test.Application.Logic.PreInvoiceHeader.Requests.Commands;
using Test.Application.Logic.PreInvoiceHeader.Requests.Queries;

namespace Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreInvoiceHeaderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PreInvoiceHeaderController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost]
        public async Task<Response> AddPreInvoiceHeader([FromBody] AddPreInvoiceHeader addPreInvoiceHeader)
        {
            return await _mediator.Send(addPreInvoiceHeader);
        }

        [HttpGet]
        public async Task<Response> GetPreInvoiceHeader([FromQuery] GetPreInvoiceHeader getProducts)
        {
            return await _mediator.Send(getProducts);
        }

        [HttpPut,Route("status")]
        public async Task<Response> UpdateStatus([FromForm] int  id)
        {
            return await _mediator.Send(new UpdateStatusPreInvoiceHeader() { Request=new UpdatePreInvoiceHeaderStatusDto() { PreInvoiceHeaderId=id} });
        }

        //[HttpPut]
        //public async Task<Response> UpdatePreInvoiceHeader([FromBody] AddProduct addProduct)
        //{
        //    return await _mediator.Send(addProduct);
        //}

        //[HttpDelete]
        //public async Task<Response> DeletePreInvoiceHeader([FromBody] AddProduct addProduct)
        //{
        //    return await _mediator.Send(addProduct);
        //}
    }
}
