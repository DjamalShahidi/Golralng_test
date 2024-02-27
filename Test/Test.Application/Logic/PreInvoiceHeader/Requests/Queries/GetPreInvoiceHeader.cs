using MediatR;
using Store.Application.Responses;
using Test.Application.DTOs.PreInvoiceHeader;

namespace Test.Application.Logic.PreInvoiceHeader.Requests.Queries
{
    public class GetPreInvoiceHeader : IRequest<Response>
    {
        public GetPreInvoiceHeaderRequestDto Request { get; set; }
    }
}
