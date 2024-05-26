using AutoMapper;
using DTO.DTOS.ProductDTO;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AutoMapper
{
    public class ProductMapper:Profile
    {
        public ProductMapper()
        {
           CreateMap<Product,GetProductDTO>().ReverseMap();
            CreateMap<Product,AddProductDTO>().ReverseMap();
            CreateMap<Product,UpdateProductDTO>().ReverseMap();
            CreateMap<Product, ProductListDTO>().ReverseMap();
        }
    }
}
