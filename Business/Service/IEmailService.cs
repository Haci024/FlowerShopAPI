using DTO.DTOS.SubscriberDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public interface IEmailService
    {
        public void SendEmailToNewSubscriber(NewSubscriberDTO dto);
        public void UnSubscribeMessageToCustomer(UnSubscribeDTO dto);

    }
}
