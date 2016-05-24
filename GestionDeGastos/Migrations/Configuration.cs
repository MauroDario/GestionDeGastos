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
            context.TipoCuentas.AddOrUpdate(
                p => p.Descripcion,
                new Models.TipoCuenta { Descripcion = "Cuenta Corriente",Icono="credit_card", Color = "red" },
                new Models.TipoCuenta { Descripcion = "Billetera", Icono="attach_money", Color = "green" },
                new Models.TipoCuenta { Descripcion = "Ahorro", Icono="account_balance", Color = "blue" },
                new Models.TipoCuenta { Descripcion = "Otros",Icono="gesture", Color="black" }
                );

        }
    }
}
