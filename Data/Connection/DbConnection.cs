using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Connection
{
    public class DbConnection:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=Odissey;initial catalog=FlowerShopDb;integrated Security=true;TrustServerCertificate=true;");
            optionsBuilder.ConfigureWarnings(warnings =>
            {
                warnings.Ignore(CoreEventId.NavigationBaseIncludeIgnored);
            });
        }
        public DbSet<Category> Category { get; set; }

        public DbSet<Product> Products { get; set; }    


    }
}
