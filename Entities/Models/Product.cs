using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Product
    {
        public long Id { get; set; }

        public string Title { get; set; }=string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool Status { get; set; }

        public bool Popular { get; set; }

        public decimal Price { get; set; }

        public DateTime AddingDate { get; set; }

        public Category Category { get; set; }

        [ForeignKey(nameof(Category))]
        public long CategoryId { get; set; }

        public IEnumerable<ProductImages> ProductImages { get; set; }
    }
}
