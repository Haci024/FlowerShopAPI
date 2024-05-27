using AutoMapper;
using Business.Service;
using DTO.DTOS.CategoryDTO;
using DTO.DTOS.ContactUsDTO;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactUsController : ControllerBase
    {
        private readonly IContactUsService _contactUs;
        private readonly IMapper _mapper;
        public ContactUsController(IContactUsService contactUs,IMapper mapper)
        {
            _contactUs = contactUs;
            _mapper = mapper;
        }
        [HttpGet("ReadMessage/{Id}")]
        public IActionResult ReadContactMessage(int Id)
        {
            var Entity=_contactUs.GetById(Id);
            
            return Ok(Entity);
        }
        [HttpPut("UnReadMessage/{Id}")]
        public IActionResult UnReadMessage(int Id,ReadContactUsDTO dto)
        {
            var entity=_contactUs.GetById(Id);
            _mapper.Map(entity,dto);
            if (dto.Viewed)
            {
                _contactUs.Update(entity);
                return Ok("Mesaj oxunmuşlar siyahısına əlavə edildi");
            }
            else
            {

                return Ok("Siyahıya qayıt");
            }
          
        }
        [HttpGet("ReadMessageList")]
        public IActionResult ReadMessageList()
        {
            var entities = _contactUs.ReadMessageList();
            var dtos = _mapper.Map<IEnumerable<ContactUsListDTO>>(entities);
            return Ok(dtos);

          
        }
        [HttpGet("UnReadMessageList")]
        public IActionResult UnReadMessageList()
        {

            var entities = _contactUs.UnReadMessageList();
            var dtos = _mapper.Map<IEnumerable<ContactUsListDTO>>(entities);
            return Ok(dtos);
            
        }
        [HttpPost("SendMessage")]
        public IActionResult SendContactMessage(SendContactUsDTO dto) {

            var entity = new ContactUs();
            _mapper.Map(entity, dto);
            _contactUs.Create(entity);
         
            return Ok(entity);
        }
        [HttpDelete("DeleteMessage")]
        public IActionResult DeleteMessage(int Id)
        {
            if (Id == null)
            {
                return NotFound("Belə bir mesaj yoxdur!");
            }
            var entity= _contactUs.GetById(Id);
            _contactUs.Delete(entity);
            return Ok("Mesaj uğurla silindi!");
        }
    }
}
