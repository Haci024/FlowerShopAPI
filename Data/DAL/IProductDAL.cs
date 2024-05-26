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
        public ICollection<Product> ProductListByCategory(long categoryId);

        public ICollection<Product> PopularProducts();

        public ICollection<Product> PopularProductsByCategory(long categoryId);

        public ICollection<Product> ActiveProductList();

        public ICollection<Product> DeactiveProductList();

        public ICollection<Product> ActiveProductsByCategory(long categoryId);

        public ICollection<Product> DeactiveProductsByCategory(long categoryId);

    }
}
