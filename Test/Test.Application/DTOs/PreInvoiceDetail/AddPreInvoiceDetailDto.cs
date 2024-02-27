namespace Test.Application.DTOs.PreInvoiceHeader
{
    public class AddPreInvoiceDetailDto
    {
        public int ProductId { get; set; }

        public int Count { get; set; }

        public double Price { get; set; }

        public int PreInvoiceHeaderId { get; set; }
    }
}
