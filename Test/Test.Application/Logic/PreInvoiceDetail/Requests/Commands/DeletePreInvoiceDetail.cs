using MediatR;
using Store.Application.Responses;
using Test.Application.DTOs.PreInvoiceDetail;

namespace Test.Application.Logic.PreInvoiceDetail.Requests.Commands
{
    public class DeletePreInvoiceDetail : IRequest<Response>
    {
        public DeletePreInvoiceDetailDto Request { get; set; }

    }
}
