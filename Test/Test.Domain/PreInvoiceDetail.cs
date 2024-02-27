using Test.Domain.Common;

namespace Test.Domain
{
    public class PreInvoiceDetail:BaseDomainEntity
    {
        public Product Product { get; set; }

        public int ProductId { get; set; }

        public int Count { get; set; }

        public double Price { get; set; }

        public int PreInvoiceHeaderId { get; set; }

        public PreInvoiceHeader PreInvoiceHeader { get; set; }
    }
}
