﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Subscribers
    {
        public int Id { get; set; }
       
        public string Email { get; set; }

        public bool Status { get; set; }    
    }
}
