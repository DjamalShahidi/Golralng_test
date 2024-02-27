using Test.Application.DTOs.Common;

namespace Test.Application.DTOs.SalesLine
{
    public record GetSaleLineDto:BaseDto
    {
        public string Title { get; set; }

        public List<GetSaleLineDtoProduct> Products { get; set; }
    }

    public record GetSaleLineDtoProduct : BaseDto
    {
        public string Title { get; set; }
    }
}
