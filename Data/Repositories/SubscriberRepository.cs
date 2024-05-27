using Data.Connection;
using Data.DAL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class SubscriberRepository : GenericRepository<Subscribers>, ISubscriberDAL
    {
        private readonly DbConnection _db;

        public SubscriberRepository(DbConnection context) : base(context)
        {
            _db = context;
        }

        public IEnumerable<Subscribers> ActiveSubscribers()
        {
            return _db.Subscribers.Where(x=>x.Status==true).ToList();
        }
        public IEnumerable<Subscribers> DeactiveSubscribers()
        {
            return _db.Subscribers.Where(x=>x.Status==false).ToList();
        }
    }
}
