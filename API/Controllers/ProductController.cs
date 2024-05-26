using AutoMapper;
using Business.Service;
using DTO.DTOS.CategoryDTO;
using DTO.DTOS.ProductDTO;
using Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ICategoryService _category;
        private readonly IProductService _product;
        private readonly IMapper _mapper;

        public ProductController(ICategoryService category, IProductService product,IMapper mapper)
        {
            _category = category;
            _product = product;
            _mapper = mapper;
        }
        #region Get
        [HttpGet("ProductList")]
        public IActionResult GetProductList()
        {
            var entities = _product.GetList();
            var dtos = _mapper.Map<IEnumerable<CategoryListDTO>>(entities);
            return Ok(dtos);
        }
        [HttpGet("GetById/{Id}")]
        public IActionResult GetById(long Id)
        {
            var values = _mapper.Map<GetProductDTO>(_product.GetById(Id));
            return Ok(values);
        }
        [HttpGet("ProductListByCategory/{categoryId}")]
        public IActionResult ProductListByCategory(long categoryId)
        {
            var entities = _product.ActiveProductsByCategory(categoryId);
            var dtos = _mapper.Map<IEnumerable<CategoryListDTO>>(entities);

            return Ok(dtos);
        }
        [HttpGet("DeactiveProductList")]
        public IActionResult DeactiveProductList()
        {
            var entities = _product.DeactiveProductList();
            var dtos = _mapper.Map<IEnumerable<CategoryListDTO>>(entities);

            return Ok(dtos);
        }
        [HttpGet("PopularProductList")]
        public IActionResult PopularProductList()
        {
            var entities = _product.PopularProducts();
            var dtos = _mapper.Map<IEnumerable<CategoryListDTO>>(entities);

            return Ok(dtos);
        }
        [HttpGet("PopularProductListByCategory/{categoryId}")]
        public IActionResult PopularProductList(long categoryId)
        {
            var entities = _product.PopularProductsByCategory(categoryId);
            var dtos = _mapper.Map<IEnumerable<CategoryListDTO>>(entities);

            return Ok(dtos);
        }
        #endregion
        #region Create
        [HttpPost("Create")]
        public IActionResult CreateProduct(AddProductDTO dto)
        {
            Product product = new Product();
            _mapper.Map(dto, product);
            _product.Create(product);
            return Ok("Məhsul əlavə edildi!");
        }
        #endregion
        #region Update
        [HttpPut("UpdateProduct/{Id}")]
        public IActionResult Update(long Id,UpdateProductDTO dto)
        {
            var entity = _product.GetById(Id);
            if (entity == null)
            {
                return NotFound("Məhsul tapılmadı!");
            }
            _mapper.Map(dto, entity);
            _product.Update(entity);
            return Ok("Məhsul yeniləndi!");
        }
        #endregion
        #region Delete
        [HttpDelete("/DeleteProduct/{Id}")]
        public IActionResult DeleteProduct(long Id) {

            if (Id == null)
            {
                return BadRequest("Bu Id uyğun kateqoriya mövcud deyil!");
            }
            var Entity = _product.GetById(Id);
            if (Entity == null)
            {
                return NotFound("Xəta!");
            }
            _product.Delete(Entity);

            return Ok("Məhsul silindi!");
        }
        #endregion
    }
}
