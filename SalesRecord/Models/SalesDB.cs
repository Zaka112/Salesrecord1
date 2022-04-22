using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesRecord.Models;


namespace SalesRecord.Models
{
    public class SalesDB:DbContext
    {
        public SalesDB(DbContextOptions<SalesDB> options): base (options)
        {

        }
        //public virtual ICollection<Product> Products { get; set; }
        //public virtual ICollection<Sale> Sales { get; set; }
        //public virtual ICollection<Customer> Customers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }

    }
}
