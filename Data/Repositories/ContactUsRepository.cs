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
    public class ContactUsRepository : GenericRepository<ContactUs>, IContactUsDAL
    {
        private readonly DbConnection _db;
        public ContactUsRepository(DbConnection context) : base(context)
        {
            _db = context;
        }

        public IEnumerable<ContactUs> ReadMessageList()
        {
            return _db.ContactUs.Where(x=>x.Viewed==true).OrderBy(x=>x.SendDate).ToList();
        }

        public IEnumerable<ContactUs> UnReadMessageList()
        {
            return _db.ContactUs.Where(x => x.Viewed==false).OrderBy(x=>x.SendDate).ToList();
        }
    }
}
