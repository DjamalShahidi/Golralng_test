namespace Test.Application.DTOs.PreInvoiceHeader
{
    public record GetPreInvoiceHeaderRequestDto
    {
        public int? Id { get; set; }

        public int From { get; set; }

        public int To { get; set; } = 10;
    }
}
