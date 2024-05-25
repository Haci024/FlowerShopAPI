using Data.DAL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Connection;

namespace Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryDAL
    {
        public CategoryRepository(Connection.DbConnection context) : base(context)
        {
        }

        public ICollection<Category> GetActiveCategories()
        {
            throw new NotImplementedException();
        }

        public ICollection<Category> GetDeactiveCategories()
        {
            throw new NotImplementedException();
        }

        public Category UpdateCategoryStatus(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
