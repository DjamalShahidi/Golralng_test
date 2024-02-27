using MediatR;
using Store.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.DTOs.PreInvoiceHeader;

namespace Test.Application.Logic.PreInvoiceDetail.Requests.Commands
{
    public class DeletePreInvoiceDetail : IRequest<Response>
    {
        public DeletePreInvoiceDetailDto Request { get; set; }

    }
}
