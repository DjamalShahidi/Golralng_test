using Test.Application.DTOs.Common;

namespace Test.Application.DTOs.PreInvoiceHeader
{
    public record UpdatePreInvoiceDetailDto :BaseDto
    {
        public int ProductId { get; set; }

        public int Count { get; set; }

        public double Price { get; set; }
    }
}
