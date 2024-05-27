using Data.Connection;
using Data.DAL;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ProductRepository:GenericRepository<Product>,IProductDAL
    {
        private readonly DbConnection _db;

        public ProductRepository(Connection.DbConnection context) : base(context)
        {
            _db = context;
        }

        public ICollection<Product> ActiveProductList()
        {
              return _db.Products.Include(x=>x.Category).Where(x=>x.Status==true && x.Category.Status==true).ToList();
        }

        public ICollection<Product> ActiveProductsByCategory(int categoryId)
        {
            return _db.Products.Include(x => x.Category).Where(x => x.Status == true && x.CategoryId==categoryId  && x.Category.Status==true).ToList();
        }

        public ICollection<Product> DeactiveProductList()
        {
            return _db.Products.Include(x => x.Category).Where(x => x.Status == false).ToList();
        }

        public ICollection<Product> DeactiveProductsByCategory(int categoryId)
        {
            return _db.Products.Include(x => x.Category).Where(x => x.Status == false && x.CategoryId == categoryId && x.Category.Status == false).ToList();
        }

        public ICollection<Product> PopularProducts()
        {
            return _db.Products.Include(x => x.Category).Where(x => x.Status == true && x.Popular == true && x.Category.Status == true).ToList();
        }

        public ICollection<Product> PopularProductsByCategory(int categoryId)
        {
            return _db.Products.Include(x => x.Category).Where(x => x.Status == true && x.CategoryId==categoryId  && x.Popular == true && x.Category.Status == true).ToList();
        }

        public ICollection<Product> ProductListByCategory(int categoryId)
        {
            return _db.Products.Include(x => x.Category).Where(x => x.Category.Status == true && x.Status==true && x.CategoryId == categoryId).ToList();
        }
    }
}
