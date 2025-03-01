using AutoMapper;
using Talabat.APIs.DTOs;
using Talabat.Core.Entities;

namespace Talabat.APIs.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(dest => dest.Brand, o => o.MapFrom(src => src.ProductBrand.Name))
                .ForMember(dest => dest.Category, o => o.MapFrom(src => src.ProductCategory.Name));

            CreateMap<CustomerBasketDto, CustomerBasket>();
            
            CreateMap<BasketItemsDto, BasketItems>();
        }
    }
}
