using MediatR;
using Store.Application.Responses;
using Test.Application.DTOs.PreInvoiceHeader;

namespace Test.Application.Logic.PreInvoiceHeader.Requests.Commands
{
    public class UpdatePreInvoiceDetail : IRequest<Response>
    {
        public UpdatePreInvoiceDetailDto Request { get; set; }
    }
}
