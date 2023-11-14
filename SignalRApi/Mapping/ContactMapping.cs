using AutoMapper;
using SignalR.DtoLayer.ContactDto;
using SignalR.Entitylayer.Entities;

namespace SignalRApi.Mapping
{
    public class ContactMapping : Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact,UpdateContactDto>().ReverseMap();
            CreateMap<Contact,ResultContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();
            CreateMap<Contact,CreateContactDto>().ReverseMap();
        }
    }
}
