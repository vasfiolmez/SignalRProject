﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ContactDto;
using SignalR.DtoLayer.ProductDto;
using SignalR.Entitylayer.Entities;
using SignalRApi.Entitylayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;
        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact()
            {
                FooterDescription = createContactDto.FooterDescription,
                Location = createContactDto.Location,
                Mail=createContactDto.Mail,
                Phone = createContactDto.Phone

            });
            return Ok("İletişim Bilgisi eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("İletişim bilgisi silindi");
        }
        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetByID(id);

            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateContacr(UpdateContactDto updateContactDto)
        {
            _contactService.TUpdate(new Contact()
            {
                
                ContactID=updateContactDto.ContactID,
                FooterDescription=updateContactDto.FooterDescription,
                Location=updateContactDto.Location,
                Mail=updateContactDto.Mail,
                Phone=updateContactDto.Phone
            });
            return Ok("İletişim Bilgisi Güncellendi");
        }
    }
}
