namespace GestionDeGastos.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GestionDeGastos.Context.GestionDeGastosDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GestionDeGastos.Context.GestionDeGastosDbContext";
        }

        protected override void Seed(GestionDeGastos.Context.GestionDeGastosDbContext context)
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
            context.TipoCuentas.AddOrUpdate(
                p => p.Descripcion,
                new Models.TipoCuenta { Descripcion = "Cuenta Corriente" },
                new Models.TipoCuenta { Descripcion = "Billetera" },
                new Models.TipoCuenta { Descripcion = "Ahorro" },
                new Models.TipoCuenta { Descripcion = "Otros" }
                );

        }
    }
}
