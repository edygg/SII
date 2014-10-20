using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SistemaIntegralIngresos.Models
{
    public class SIIDbContext : DbContext
    {
        public DbSet<Campus> Campus { get; set; }
    }
}