using MediatR;
using Store.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Logic.PreInvoiceHeader.Requests.Queries
{
    public class GetPreInvoiceDetail : IRequest<Response>
    {
        public int PreInvoiceHeaderId { get; set; }

    }
}
