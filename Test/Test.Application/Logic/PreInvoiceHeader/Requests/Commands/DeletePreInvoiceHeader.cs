using MediatR;
using Store.Application.Responses;
using Test.Application.DTOs.PreInvoiceHeader;

namespace Test.Application.Logic.PreInvoiceHeader.Requests.Commands
{
    public class DeletePreInvoiceHeader : IRequest<Response>
    {
        public DeletePreInvoiceHeaderDto Request { get; set; }

    }
}
