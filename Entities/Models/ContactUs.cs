using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class ContactUs
    {
        public long Id { get; set; }

        public string Email { get; set; } = string.Empty;

        public string Subject  { get; set; }=string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
