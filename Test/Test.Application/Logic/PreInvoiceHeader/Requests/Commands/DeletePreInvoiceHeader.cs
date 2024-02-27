using MediatR;
using Store.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.DTOs.PreInvoiceHeader;

namespace Test.Application.Logic.PreInvoiceHeader.Requests.Commands
{
    public class DeletePreInvoiceHeader : IRequest<Response>
    {
        public DeletePreInvoiceHeaderDto Request { get; set; }

    }
}
