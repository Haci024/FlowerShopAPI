using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOS.SubscriberDTO
{
    public class NewSubscriberDTO
    {
       
        public string Email { get; set; }

        public bool Status { get; set; } = false;    


    }
}
