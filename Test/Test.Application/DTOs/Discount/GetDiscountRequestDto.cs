namespace Test.Application.DTOs.Discount
{
    public class GetDiscountRequestDto
    {
        public int? PreInvoiceHeaderId { get; set; }

        public int? PreInvoiceDetailId { get; set; }
    }
}
