﻿using Business.Service;
using Data.DAL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _dal;
        public CategoryManager(ICategoryDAL dal)
        {
            _dal = dal;
        }
        public void Create(Category entity)
        {
             _dal.Create(entity);
        }

        public void Delete(Category entity)
        {
            _dal.Delete(entity);
        }

        public ICollection<Category> GetActiveCategories()
        {
           return _dal.GetActiveCategories();
        }

        public Category GetById(long id)
        {
           return _dal.GetById(id);
        }

        public ICollection<Category> GetDeactiveCategories()
        {
            return _dal.GetDeactiveCategories();
        }

        public IEnumerable<Category> GetList()
        {
            return _dal.GetList();
        }

        public void Update(Category entity)
        {
            _dal.Update(entity);
        }
    }
}
