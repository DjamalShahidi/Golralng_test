using Test.Application.DTOs.Common;
using Test.Domain;

namespace Test.Application.DTOs.Discount
{
    public record UpdateDiscountDto :BaseDto
    {
        public int? PreInvoiceDetailId { get; set; }

        public double Amount { get; set; }

        public DiscountType Type { get; set; }

    }
}
