using AutoMapper;
using Business.Service;
using Data.Connection;
using DTO.DTOS.SubscriberDTO;
using Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriberController : ControllerBase
    {
        private readonly ISubscriberService _subscribers;
        private readonly DbConnection _connection;
        private readonly IMapper _mapper;
        private readonly IEmailService _email;
        public SubscriberController(ISubscriberService subscribers,DbConnection db,IMapper mapper,IEmailService emailService)
        {
            _subscribers = subscribers;
            _connection = db;
            _mapper = mapper;   
            _email = emailService;   
        }
        [HttpGet("SubscriberList")]
        public IActionResult SubscriberList()
        {
            IEnumerable<Subscribers> entity = _subscribers.GetList();
            return Ok(entity);
        }
        [HttpPost("NewSubscriber")]
        public IActionResult NewSubscriber(NewSubscriberDTO dto)
        {
            Subscribers entity = new Subscribers();
           bool IsExist=_connection.Subscribers.Any(x=>x.Email==dto.Email);
            if (IsExist)
            {
                
                return BadRequest("Bu elektron ünvan artıq abunə olub!");
            }
            _mapper.Map(dto, entity);
            _subscribers.Create(entity);
            _email.SendEmailToNewSubscriber(dto);

            return Ok("Abunəlik uğurla tamamlandı!");
        }
        [HttpDelete("UnSubscribe")]
        public IActionResult UnSubscribe(int Id)
        {
           UnSubscribeDTO dto=new UnSubscribeDTO();
            
            var entity=_subscribers.GetById(Id);

            dto.Email = entity.Email;
            
            _subscribers.Delete(entity);
            _email.UnSubscribeMessageToCustomer(dto);

            return Ok("Abunəlikdən çıxıldı!");
        }

    }
}
