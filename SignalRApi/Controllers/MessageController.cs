using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.MessageDto;
using SignalR.Entitylayer.Entities;
using SignalRApi.Entitylayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

     
        [HttpGet]
        public IActionResult ActionResult()
        {
            var values = _messageService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            Message message = new Message()
            {
               NameSurname=createMessageDto.NameSurname,
               Mail=createMessageDto.Mail,
               Phone=createMessageDto.Phone,
               Subject = createMessageDto.Subject,
               MessageContent = createMessageDto.MessageContent,
               MessageSendDate=DateTime.Now,
               Status = createMessageDto.Status
            };
            _messageService.TAdd(message);
            return Ok("Mesaj Başarılı Bir Şekilde Gönderildi.");
        }
        [HttpDelete]
        public IActionResult DeleteMessage(int id)
        {
            var value = _messageService.TGetByID(id);
            _messageService.TDelete(value);
            return Ok("Mesaj Silindi");
        }
        [HttpGet("GetMessage")]
        public IActionResult GetMessage(int id)
        {
            var value = _messageService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            Message message = new Message()
            {
                MessageID=updateMessageDto.MessageID,
                NameSurname = updateMessageDto.NameSurname,
                Mail = updateMessageDto.Mail,
                Phone = updateMessageDto.Phone,
                Subject = updateMessageDto.Subject,
                MessageContent = updateMessageDto.MessageContent,
                MessageSendDate =updateMessageDto.MessageSendDate,
                Status = false
            };
            _messageService.TUpdate(message);
            return Ok("Mesaj Güncellendi.");
        }
    }
}
