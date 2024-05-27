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
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDAL _dal;
        public ContactUsManager(IContactUsDAL dal)
        {
            _dal = dal;
        }
        public void Create(ContactUs entity)
        {
            _dal.Create(entity);
        }

        public void Delete(ContactUs entity)
        {
            _dal.Delete(entity);
        }

        public ContactUs GetById(int id)
        {
            return _dal.GetById(id);
        }

        public IEnumerable<ContactUs> GetList()
        {
           return _dal.GetList();
        }

        public IEnumerable<ContactUs> ReadMessageList()
        {
          return  _dal.ReadMessageList();
        }

        public IEnumerable<ContactUs> UnReadMessageList()
        {
           return _dal.UnReadMessageList();
        }

        public void Update(ContactUs entity)
        {
            _dal.Update(entity);
        }
    }
}
