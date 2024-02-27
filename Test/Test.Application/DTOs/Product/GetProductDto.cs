using Test.Application.DTOs.Common;

namespace Test.Application.DTOs.Product
{
    record class GetProductDto:BaseDto
    {
        public string Title { get; set; }

 
    }

}
