using System.Reflection.Metadata;

namespace Test.Application.DTOs.PreInvoiceHeader
{
    public class AddPreInvoiceHeaderDto
    {
        public int SalesLineId { get; set; }

        public int SellerId { get; set; }

        public AddPreInvoiceHeaderDtoCustomer Customer { get; set; }
    }

    public class AddPreInvoiceHeaderDtoCustomer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
