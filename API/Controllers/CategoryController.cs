using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategoryList()
        {

            return Ok();
        }
        [HttpGet("GetById/{Id}")]
        public IActionResult GetById()
        {

            return Ok();
        }
        [HttpPost]
        public IActionResult Create()
        {

            return Ok();
        }
        [HttpPut]
        public IActionResult Update()
        {

            return Ok();
        }
        [HttpPut]
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
