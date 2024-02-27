using AutoMapper;
using Test.Application.DTOs.Discount;
using Test.Application.DTOs.PreInvoiceHeader;
using Test.Application.DTOs.SalesLine;
using Test.Domain;

namespace Test.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PreInvoiceHeader, AddPreInvoiceHeaderDto>().ReverseMap(); 
            CreateMap<PreInvoiceDetail, AddPreInvoiceDetailDto>().ReverseMap();
            CreateMap<Discount, AddDiscountDto>().ReverseMap();
            CreateMap<Product, GetSaleLineDtoProduct>().ReverseMap();
            CreateMap<Seller, GetSaleLineSeller>().ReverseMap();
            CreateMap<Customer, AddPreInvoiceHeaderDtoCustomer  >().ReverseMap();
            CreateMap<PreInvoiceHeader, GetPreInvoiceHeaderDto>().ReverseMap();
            CreateMap<Customer, GetPreInvoiceHeaderDtoCustomer>().ReverseMap();
            CreateMap<Product, GetPreInvoiceDetailDtoProduct>().ReverseMap();
            CreateMap<PreInvoiceDetail, GetPreInvoiceDetailDto>().ReverseMap();
        }
    }
}
