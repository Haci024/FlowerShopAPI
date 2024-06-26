﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class ContactUs
    {
        public int Id { get; set; }

        public bool Viewed { get; set; }

        public DateTime SendDate { get; set; }

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; }=string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
