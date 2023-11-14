using AutoMapper;
using Microsoft.EntityFrameworkCore.Update.Internal;
using SignalR.DtoLayer.AboutDto;
using SignalRApi.Entitylayer.Entities;

namespace SignalRApi.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
        CreateMap<About,ResultAboutDto>().ReverseMap();
            CreateMap<About,UpdateAboutDto>().ReverseMap();
            CreateMap<About,GetAboutDto>().ReverseMap();
            CreateMap<About,CreateAboutDto>().ReverseMap(); 
        }
    }
}
