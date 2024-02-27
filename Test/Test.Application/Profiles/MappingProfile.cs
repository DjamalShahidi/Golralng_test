using AutoMapper;
using Test.Application.DTOs.PreInvoiceHeader;
using Test.Domain;

namespace Test.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PreInvoiceHeader, AddPreInvoiceHeaderDto>().ReverseMap(); 
            CreateMap<PreInvoiceDetail, AddPreInvoiceDetailDto>().ReverseMap();


            //CreateMap<AddFeatureDto, Feature>().ForMember(dest => dest.Type, opt => opt.MapFrom(src => MapValueType(src.Value))).ReverseMap();
            //CreateMap<GetFeatureDto, Feature>().ReverseMap();
            //CreateMap<AddCategoryDto, Category>().ReverseMap();
            //CreateMap<AddProductDto, Product>().ReverseMap();
            //CreateMap<GetCategoryDto, Category>().ReverseMap();
            //CreateMap<GetProductDto, Product>().ReverseMap();
            //CreateMap<UserDto, ApplicationUser>().ReverseMap();
            //CreateMap<LoginRequestDto, ApplicationUser>().ReverseMap();
            //CreateMap<LoginResponseDTO, ApplicationUser>().ReverseMap();
            //CreateMap<RegisterationRequestDTO, ApplicationUser>().ReverseMap();




        }
    }
}
