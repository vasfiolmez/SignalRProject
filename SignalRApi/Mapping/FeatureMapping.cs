using AutoMapper;
using SignalR.DtoLayer.FeatureDto;
using SignalRApi.Entitylayer.Entities;

namespace SignalRApi.Mapping
{
    public class FeatureMapping:Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();


        }
    }
}
