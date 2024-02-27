using MediatR;
using Store.Application.Responses;
using Test.Application.DTOs.PreInvoiceHeader;

namespace Test.Application.Logic.PreInvoiceHeader.Requests.Commands
{
    public class UpdateStatusPreInvoiceHeader : IRequest<Response>
    {
        public UpdatePreInvoiceHeaderStatusDto Request { get; set; }
    }
}
