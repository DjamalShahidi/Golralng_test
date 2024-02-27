using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain;

namespace Test.Application.DTOs.Discount
{
    public class AddDiscountDto
    {
        public int PreInvoiceHeaderId { get; set; }

        public int? PreInvoiceDetailId { get; set; }

        public double Amount { get; set; }

        public DiscountType Type { get; set; }

    }
}
