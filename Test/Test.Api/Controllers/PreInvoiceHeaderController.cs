using MediatR;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Responses;
using Test.Application.DTOs.PreInvoiceHeader;
using Test.Application.Logic.PreInvoiceHeader.Requests.Commands;
using Test.Application.Logic.PreInvoiceHeader.Requests.Queries;
using Test.Domain;

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
            return await _mediator.Send(new UpdateStatusPreInvoiceHeader() 
            { 
                Request=new UpdatePreInvoiceHeaderStatusDto() 
                {   
                    PreInvoiceHeaderId=id
                } 
            });
        }

        [HttpPut]
        public async Task<Response> UpdatePreInvoiceHeader([FromBody] UpdatePreInvoiceHeader updatePreInvoiceHeader)
        {
            return await _mediator.Send(updatePreInvoiceHeader);
        }

        [HttpDelete]
        public async Task<Response> DeletePreInvoiceHeader([FromQuery] int id)
        {
            return await _mediator.Send(new DeletePreInvoiceHeader()
            {
                Request = new DeletePreInvoiceHeaderDto()
                {
                    PreInvoiceHeaderId = id
                }
            });
        }
    }
}
