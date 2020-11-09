using Grup22.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grup22.Context
{
    public class KurumsalContext : DbContext
    {
        public KurumsalContext(DbContextOptions<KurumsalContext> options) : base(options)
        { }
        public DbSet<FactoryUser> factoryUsers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
    }
}
