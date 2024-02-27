namespace Test.Domain
{
    public class ProductSaleLine
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int SalesLineId { get; set; }

        public SalesLine SalesLine { get; set; }
    }
}
