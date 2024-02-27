using Test.Application.DTOs.Common;

namespace Test.Application.DTOs.PreInvoiceHeader
{
    public record GetPreInvoiceHeaderDto : BaseDto
    {
        public int SalesLineId { get; set; }

        public int SellerId { get; set; }

        public GetPreInvoiceHeaderDtoCustomer Customer { get; set; }
    }
    public record GetPreInvoiceHeaderDtoCustomer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
