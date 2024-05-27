using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public interface IContactUsService:IGenericService<ContactUs>
    {
        public IEnumerable<ContactUs> UnReadMessageList();

        public IEnumerable<ContactUs> ReadMessageList();
    }
}
