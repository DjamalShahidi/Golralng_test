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
