using Test.Application.DTOs.Common;

namespace Test.Application.DTOs.PreInvoiceHeader
{
    public record UpdatePreInvoiceHeaderDto:BaseDto
    {
        public int SalesLineId { get; set; }

        public int SellerId { get; set; }

        public UpdatePreInvoiceHeaderDtoCustomer Customer { get; set; }
    }
    public class UpdatePreInvoiceHeaderDtoCustomer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
