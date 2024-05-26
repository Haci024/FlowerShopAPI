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
            //  var values = _mapper.Map<IEnumerable<CategoryListDTO>>(_category.GetList());
            var entities = _category.GetList();
            var dtos = _mapper.Map<IEnumerable<CategoryListDTO>>(entities);
            return Ok(dtos);
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
            Category category = new Category();
            _mapper.Map(category, dto);
          
            _category.Create(category);

            return Ok("Əlavə edildi!");
        }
        [HttpPut("Update/{Id}")]
        public IActionResult Update(long Id,UpdateCategoryDTO dto)
        {
            var entity = _category.GetById(Id);
            if (entity == null)
            {
                return NotFound("Category not found");
            }
            _mapper.Map(dto,entity);
            _category.Update(entity);
            return Ok("Yeniləndi!");
        }
        [HttpDelete("Delete/{Id}")]
        public IActionResult Delete(long Id)
        {
            if (Id == null)
            {
                return BadRequest("Bu Id uyğun kateqoriya mövcud deyil!");
            }
            var Entity = _category.GetById(Id);
            if (Entity==null)
            {
                return NotFound("Xəta!");
            }
            _category.Delete(Entity);   
            return Ok("Kateqoriya silindi!");
        }
        [HttpGet("ActiveCategoryList")]
        public IActionResult ActiveCategoryList()
        {
          
            ICollection<Category> category=_category.GetActiveCategories();
            var dto = _mapper.Map<IEnumerable<CategoryListDTO>>(category);


            return Ok(dto);
        }
        [HttpGet("DeletedCategoryList")]
        public IActionResult DeletedCategoryList()
        {
            var entities = _category.GetDeactiveCategories();
            var dto = _mapper.Map<IEnumerable<CategoryListDTO>>(entities);


            return Ok(dto);
        }
    }
}
