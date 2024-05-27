using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class ProductImages
    {
        public int Id { get; set; }

        public string ImgUrl { get; set; }
      
        [NotMapped]
        public IFormFile Photo { get; set; }

        public Product Product { get; set; }

        public int ProductId { get; set; }

    }
}
