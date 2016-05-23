using GestionDeGastos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace GestionDeGastos.Context
{
    public class GestionDeGastosDbContext: DbContext
    {
        public DbSet<Frecuencia> Frecuencias { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<TipoCuenta> TipoCuentas { get; set; }

        public GestionDeGastosDbContext() : base("DefaultConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}