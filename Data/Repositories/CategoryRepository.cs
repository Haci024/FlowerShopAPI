using Data.DAL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data.Connection;

namespace Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryDAL
    {
        private readonly DbConnection _db;
       
        public CategoryRepository(Connection.DbConnection context) : base(context)
        {
            _db=context;
        }

        public ICollection<Category> GetActiveCategories()
        {
            return _db.Category.Where(x=>x.Status==true).ToList();
        }
        

        public ICollection<Category> GetDeactiveCategories()
        {
            return _db.Category.Where(x => x.Status == false).ToList();
        }

    }
}
