namespace SistemaIntegralIngresos.Migrations
{
    using SistemaIntegralIngresos.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SistemaIntegralIngresos.Models.SIIDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SistemaIntegralIngresos.Models.SIIDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var campus = new List<Campus> 
            {
                new Campus {Id = 1, Code = "UTGU", Name = "UNITEC Tegucigalpa", Details = ""},
                new Campus {Id = 2, Code = "USPS", Name = "UNITEC San Pedro Sula", Details = ""},
                new Campus {Id = 3, Code = "ULCB", Name = "UNITEC La Ceiba", Details = ""},
                new Campus {Id = 4, Code = "CTCPCR", Name = "CEUTEC Próceres", Details = ""},
                new Campus {Id = 5, Code = "CTCPRD", Name = "CEUTEC Prado", Details = ""},
                new Campus {Id = 6, Code = "CTCCMR", Name = "CEUTEC Centroamérica", Details = ""},
                new Campus {Id = 7, Code = "CTCSPS", Name = "CEUTEC San Pedro Sula", Details = ""},
                new Campus {Id = 8, Code = "CTCLCB", Name = "CEUTEC La Ceiba", Details = ""}
            };
            campus.ForEach(s => context.Campus.AddOrUpdate(p => p.Code, s));
            context.SaveChanges();
        }
    }
}
