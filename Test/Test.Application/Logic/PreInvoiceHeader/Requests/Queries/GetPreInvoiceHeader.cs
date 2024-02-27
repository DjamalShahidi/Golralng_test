using MediatR;
using Store.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Logic.PreInvoiceHeader.Requests.Queries
{
    public class GetPreInvoiceHeader : IRequest<Response>
    {
        public int? Id { get; set; }

        public int From { get; set; }

        public int To { get; set; } = 10;
    }
}
