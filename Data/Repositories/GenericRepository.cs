using Data.DAL;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class

    {
        public void Create(T t)
        {
            using DbConnection dbContext = new DbConnection();
            dbContext.Set<T>().Add(t);
            dbContext.SaveChanges();
        }

        public void Delete(T t)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
