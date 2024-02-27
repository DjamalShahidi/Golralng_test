using Test.Domain.Common;

namespace Test.Domain
{
    public class Discount:BaseDomainEntity
    {
        public int PreInvoiceHeaderId { get; set; }

        public PreInvoiceHeader PreInvoiceHeader { get; set; }

        public int? PreInvoiceDetailId { get; set; }

        public PreInvoiceDetail PreInvoiceDetail { get; set; }

        public double Amount { get; set; }

    }

    public enum DiscountType
    {
        Row=1,
        Document=2
    }
}
