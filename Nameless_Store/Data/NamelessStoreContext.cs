using Microsoft.EntityFrameworkCore;
using Nameless_Store.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nameless_Store.Data
{
    public class NamelessStoreContext : DbContext
    {
        public NamelessStoreContext(DbContextOptions<NamelessStoreContext> options)
            : base(options)
        {
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public NamelessStoreContext(int ID, string Name, double Price)
        {
            this.ID = ID;
            this.Name = Name;
            this.Price = Price;
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Performance_kit> Performance_kit { get; set; }
        public DbSet<Performance_parts> Performance_Parts { get; set; }
    }
}
