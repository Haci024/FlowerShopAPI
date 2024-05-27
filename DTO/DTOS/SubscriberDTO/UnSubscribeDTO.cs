using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOS.SubscriberDTO
{
    public class UnSubscribeDTO
    {
        public string Email { get; set; }
        public bool Status { get; set; } = false;
    }
}
