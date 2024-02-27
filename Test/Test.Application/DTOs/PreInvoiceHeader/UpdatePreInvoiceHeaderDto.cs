using Test.Application.DTOs.Common;

namespace Test.Application.DTOs.PreInvoiceHeader
{
    public record UpdatePreInvoiceHeaderDto:BaseDto
    {
        public int SalesLineId { get; set; }

        public int SellerId { get; set; }

        public AddPreInvoiceHeaderDtoCustomer Customer { get; set; }
    }
}
