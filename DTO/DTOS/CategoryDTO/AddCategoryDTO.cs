﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOS.CategoryDTO
{
    public class AddCategoryDTO
    {

        
        public string Name { get; set; }

        public bool Status { get; set; } = false;
    }
}
