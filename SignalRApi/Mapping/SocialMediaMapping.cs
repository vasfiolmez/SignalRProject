﻿using AutoMapper;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.Entitylayer.Entities;

namespace SignalRApi.Mapping
{
    public class SocialMediaMapping:Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia,GetSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,UpdateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,ResultSocialMediaDto>().ReverseMap();
        }
    }
}
