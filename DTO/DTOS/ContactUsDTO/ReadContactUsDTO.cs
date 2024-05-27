using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOS.ContactUsDTO
{
    public class ReadContactUsDTO
    {
        public int Id { get; set; }

        public bool Viewed { get; set; }

        public DateTime SendDate { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Description { get; set; } 
    }
}
