using Test.Application.DTOs.Common;
using Test.Domain;

namespace Test.Application.DTOs.PreInvoiceHeader
{
    public record GetPreInvoiceHeaderResponseDto : BaseDto
    {
        public int SalesLineId { get; set; }

        public int SellerId { get; set; }

        public PreInvoiceHeaderStatus Status { get; set; }

        public GetPreInvoiceHeaderDtoCustomer Customer { get; set; }
    }
    public record GetPreInvoiceHeaderDtoCustomer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
