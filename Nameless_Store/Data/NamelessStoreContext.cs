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

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Performance_kit> Performance_kit { get; set; }
        public DbSet<Performance_parts> Performance_Parts { get; set; }
    }
}
