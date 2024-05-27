using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public interface ISubscriberDAL:IGenericDAL<Subscribers>
    {
        public IEnumerable<Subscribers> ActiveSubscribers();

        public IEnumerable<Subscribers> DeactiveSubscribers();
    }
}
