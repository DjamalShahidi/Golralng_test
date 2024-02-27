using System.ComponentModel.DataAnnotations;
using Test.Domain.Common;

namespace Test.Domain
{
    public class SalesLine:BaseDomainEntity
    {
        public string Title { get; set; }

        public List<PreInvoiceHeader> PreInvoiceHeaders { get; set; }

        public List<ProductSaleLine> ProductSaleLines { get; set; }
    }
}
