﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOS.CategoryDTO
{
    public class AddCategoryDTO
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public bool Status { get; set; }
    }
}