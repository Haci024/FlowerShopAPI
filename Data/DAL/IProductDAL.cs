using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public interface IProductDAL:IGenericDAL<Product>
    {
        public ICollection<Product> ProductListByCategory(int categoryId);

        public ICollection<Product> PopularProducts();

        public ICollection<Product> PopularProductsByCategory(int categoryId);

        public ICollection<Product> ActiveProductList();

        public ICollection<Product> DeactiveProductList();

        public ICollection<Product> ActiveProductsByCategory(int categoryId);

        public ICollection<Product> DeactiveProductsByCategory(int categoryId);

    }
}
