using Test.Application.DTOs.Common;

namespace Test.Application.DTOs.SalesLine
{
    public record GetSaleLineDto:BaseDto
    {
        public string Title { get; set; }

        public List<GetSaleLineDtoProduct> Products { get; set; }

        public List<GetSaleLineSeller> Sellers { get; set; }

    }

    public record GetSaleLineDtoProduct : BaseDto
    {
        public string Title { get; set; }
    }

    public record GetSaleLineSeller : BaseDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
