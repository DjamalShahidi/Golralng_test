using Test.Application.DTOs.Common;

namespace Test.Application.DTOs.PreInvoiceHeader
{
    public record GetPreInvoiceDetailDto : BaseDto
    {
        public int Count { get; set; }

        public double Price { get; set; }

        public GetPreInvoiceDetailDtoProduct Product { get; set; }
    }
    public record GetPreInvoiceDetailDtoProduct : BaseDto
    {
        public string Title { get; set; }
    }
}
