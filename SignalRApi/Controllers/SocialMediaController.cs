using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ProductDto;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.Entitylayer.Entities;
using SignalRApi.Entitylayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;
        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            _socialMediaService.TAdd(new SocialMedia()
            {
                Icon=createSocialMediaDto.Icon,
                Title=createSocialMediaDto.Title,
                Url=createSocialMediaDto.Url

            });
            return Ok("Sosyal Medya eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(value);
            return Ok("Sosyal Medya silindi");
        }
        [HttpGet("GetSocialMedia")]
        public IActionResult GetProduct(int id)
        {
            var value = _socialMediaService.TGetByID(id);

            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            _socialMediaService.TUpdate(new SocialMedia()
            {
               SocialMediaID=updateSocialMediaDto.SocialMediaID,
               Icon=updateSocialMediaDto.Icon,
               Title=updateSocialMediaDto.Title,
               Url = updateSocialMediaDto.Url
            });
            return Ok("Ürün Bilgisi Güncellendi");
        }
    }
}
