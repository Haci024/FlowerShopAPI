﻿using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOS.ProductDTO
{
    public class UpdateProductDTO
    {
        public long Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool Status { get; set; }

        public bool Popular { get; set; }

        public decimal Price { get; set; }

        public DateTime AddingDate { get; set; }

        public int ViewCount { get; set; }


        public long CategoryId { get; set; }
    }
}
