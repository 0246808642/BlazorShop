using BlazorShop.Api.Model;
using BlazorShop.Models.DTOs;

namespace BlazorShop.Api.Data.Profile
{
    public class MappingProfile : AutoMapper.Profile
    {
        
        public MappingProfile()
        {
            // Category -> CategoryDto

            CreateMap<Category, CategoryDto>();

            // Product -> ProductDto
            CreateMap<Product, ProductDto>()
                .ForMember(c=> c.CategoryId, ca => ca.MapFrom(src=> src.Category.Id))
                .ForMember(c=>c.CategoriaName, ca => ca.MapFrom(src=> src.Category.Name));

            // CartItem -> CartItemDto
            CreateMap<CarItem, CarItemDto>()
                 .ForMember(c => c.ProductName, ca => ca.MapFrom(src => src.Product.Name))
                 .ForMember(c => c.ProductDescription, ca => ca.MapFrom(src => src.Product.Description))
                 .ForMember(c => c.ProductImageUrl, ca => ca.MapFrom(src => src.Product.ImageUrl))
                 .ForMember(c => c.Price, ca => ca.MapFrom(src => src.Product.Price))
                 .ForMember(c => c.TotalPrice, ca => ca.MapFrom(src => src.Product.Price * src.Quantity));
            
        }
    }
}
