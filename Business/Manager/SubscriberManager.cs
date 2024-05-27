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
    public class SubscriberManager : ISubscriberService
    {
        private readonly ISubscriberDAL _dal;

        public SubscriberManager(ISubscriberDAL dal)
        {
            _dal = dal;
        }

        public void Create(Subscribers entity)
        {
            _dal.Create(entity);
        }

        public void Delete(Subscribers entity)
        {
            _dal.Delete(entity);
        }

        public Subscribers GetById(int id)
        {
            return _dal.GetById(id);
        }

        public IEnumerable<Subscribers> GetList()
        {
           return _dal.GetList();
        }

        public void Update(Subscribers entity)
        {
            _dal.Update(entity);
        }
    }
}
