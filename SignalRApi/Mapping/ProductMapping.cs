using AutoMapper;
using SignalR.DtoLayer.ProductDto;
using SignalRApi.Entitylayer.Entities;

namespace SignalRApi.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {
            CreateMap<Product,GetProductDto>().ReverseMap();
            CreateMap<Product,UpdateProductDto>().ReverseMap();
            CreateMap<Product,ResultProductDto>().ReverseMap();
            CreateMap<Product,CreateProductDto>().ReverseMap();
        }
    }
}
