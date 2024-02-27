namespace Test.Application.DTOs.Product
{
    public class AddProductDto
    {
        public string Title { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string ImgUrl { get; set; }

        public int CategoryId { get; set; }

        public List<int> FeatureIds { get; set; }
    }
}
