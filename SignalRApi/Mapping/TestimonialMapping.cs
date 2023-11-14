using AutoMapper;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.Entitylayer.Entities;

namespace SignalRApi.Mapping
{
    public class TestimonialMapping:Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial,GetTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
        }
    }
}
