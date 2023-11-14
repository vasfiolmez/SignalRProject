using AutoMapper;
using SignalR.DtoLayer.CategoryDto;
using SignalRApi.Entitylayer.Entities;

namespace SignalRApi.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category,CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category,GetCategoryDto>().ReverseMap();
            CreateMap<Category,ResultCategoryDto>().ReverseMap();
        }
    }
}
