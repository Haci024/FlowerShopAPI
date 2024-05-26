﻿using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public interface ICategoryService:IGenericService<Category>
    {
        public ICollection<Category> GetActiveCategories();

        public ICollection<Category> GetDeactiveCategories();
    }
}
