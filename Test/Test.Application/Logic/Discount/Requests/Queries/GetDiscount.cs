using MediatR;
using Store.Application.Responses;

namespace Test.Application.Logic.PreInvoiceHeader.Requests.Queries
{
    public class GetDiscount : IRequest<Response>
    {
        public int? PreInvoiceHeaderId { get; set; }

        public int? PreInvoiceDetailId { get; set; }
    }
}
