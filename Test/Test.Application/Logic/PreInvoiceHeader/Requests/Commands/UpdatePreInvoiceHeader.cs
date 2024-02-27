using MediatR;
using Store.Application.Responses;
using Test.Application.DTOs.PreInvoiceHeader;

namespace Test.Application.Logic.PreInvoiceHeader.Requests.Commands
{
    public class UpdatePreInvoiceHeader : IRequest<Response>
    {
        public UpdatePreInvoiceHeaderDto Request { get; set; }
    }
}
