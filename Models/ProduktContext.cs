using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DevTaskJulianBenda.Models
{
    public class ProduktContext : DbContext
    {
        public ProduktContext(DbContextOptions<ProduktContext> options)
            : base(options)
        { 
        }

        public DbSet<Product> Products { get; set; }
    }
}
