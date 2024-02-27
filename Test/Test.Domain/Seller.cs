using Test.Domain.Common;

namespace Test.Domain
{
    public class Seller:BaseDomainEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int SalesLineId { get; set; }

        public SalesLine SalesLine { get; set; }

        public List<PreInvoiceHeader> PreInvoiceHeaders { get; set; }
    }
}
