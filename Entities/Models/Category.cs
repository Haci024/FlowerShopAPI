using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Category
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public bool Status { get; set; }

        IEnumerable<Product> Products { get; set; } 




    }
}
