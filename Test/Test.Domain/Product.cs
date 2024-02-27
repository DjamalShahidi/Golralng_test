using Test.Domain.Common;

namespace Test.Domain
{
    public class Product : BaseDomainEntity
    {
        public string Title { get; set; }

        public List<ProductSaleLine> ProductSaleLines { get; set; }

        public List<PreInvoiceDetail> PreInvoiceDetails { get; set; }
    }
}
