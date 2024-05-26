using Business.Service;
using Data.DAL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager
{
    public class ProductManager:IProductService
    {
        private readonly IProductDAL _dal;
        public ProductManager(IProductDAL dal)
        {
            _dal = dal;
        }

        public ICollection<Product> ActiveProductList()
        {
            return _dal.ActiveProductList();    
        }

        public ICollection<Product> ActiveProductsByCategory(long categoryId)
        {
           return _dal.ActiveProductsByCategory(categoryId);
        }

        public void Create(Product entity)
        {
            _dal.Create(entity);
        }

        public ICollection<Product> DeactiveProductList()
        {
            return _dal.DeactiveProductList();
        }

        public ICollection<Product> DeactiveProductsByCategory(long categoryId)
        {
            return _dal.DeactiveProductsByCategory(categoryId);
        }

        public void Delete(Product entity)
        {
            _dal.Delete(entity);
        }

        public Product GetById(long id)
        {
            return _dal.GetById(id);
        }

        public IEnumerable<Product> GetList()
        {
            return _dal.GetList();
        }

        public ICollection<Product> PopularProducts()
        {
            return _dal.PopularProducts();
        }

        public ICollection<Product> PopularProductsByCategory(long categoryId)
        {
            return _dal.PopularProductsByCategory(categoryId);
        }

        public ICollection<Product> ProductListByCategory(long categoryId)
        {
            return _dal.ProductListByCategory(categoryId);
        }

        public void Update(Product entity)
        {
            _dal.Update(entity);
        }
    }
}
