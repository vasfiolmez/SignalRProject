using AutoMapper;
using SignalR.DtoLayer.SliderDto;
using SignalR.Entitylayer.Entities;
using SignalRApi.Entitylayer.Entities;

namespace SignalRApi.Mapping
{
    public class SliderMapping:Profile
    {
        public SliderMapping()
        {
            CreateMap<Slider, GetSliderDto>().ReverseMap();
            CreateMap<Slider, CreateSliderDto>().ReverseMap();
            CreateMap<Slider, UpdateSliderDto>().ReverseMap();
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
        }
    }
}
