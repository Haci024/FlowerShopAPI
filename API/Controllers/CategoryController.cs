using AutoMapper;
using Business.Service;
using DTO.DTOS.CategoryDTO;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _category;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService category,IMapper mapper)
        {
            _category = category;
            _mapper = mapper;   
        }

        [HttpGet("CategoryList")]
        public IActionResult GetList()
        {
            var values = _mapper.Map<IEnumerable<CategoryListDTO>>(_category.GetList());
           
            return Ok(values);
        }
        [HttpGet("GetById/{Id}")]
        public IActionResult GetById(long Id)
        {
            var values = _mapper.Map<GetCategoryDTO>(_category.GetById(Id));
            return Ok(values);
        }
        [HttpPost("Create")]
        public IActionResult Create(AddCategoryDTO dto)
        {
            _category.Create(new Category()
            {
                Name =dto.Name,
                Status = dto.Status,
                Id = dto.Id,
            });
          

            return Ok("Əlavə edildi!");
        }
        [HttpPut("Update/{Id}")]
        public IActionResult Update(UpdateCategoryDTO dto)
        {
          
            return Ok("Yeniləndi!");
        }
        [HttpPut("Delete/{Id}")]
        public IActionResult Delete()
        {

            return Ok();
        }
        [HttpGet("ActiveCategoryList")]
        public IActionResult ActiveCategoryList()
        {

            return Ok();
        }
        [HttpGet("DeactiveCategoryList")]
        public IActionResult DeacitveActiveCategoryList()
        {
        
            return Ok();
        }
    }
}
