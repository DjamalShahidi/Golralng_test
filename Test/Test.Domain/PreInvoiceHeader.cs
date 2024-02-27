using Test.Domain.Common;

namespace Test.Domain
{
    public class PreInvoiceHeader:BaseDomainEntity
    {
        public SalesLine SalesLine { get; set; }

        public int SalesLineId { get; set; }

        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public Seller Seller { get; set; }

        public int SellerId { get; set; }

        public PreInvoiceHeaderStatus Status { get; set; } = PreInvoiceHeaderStatus.Draft;

        public List<PreInvoiceDetail> PreInvoiceDetails { get; set; }
    }

    public enum PreInvoiceHeaderStatus
    {
        Draft=1,
        Final=2
    }
}
