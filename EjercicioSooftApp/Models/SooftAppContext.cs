
using EjercicioSooftApp.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace NetSooftApp.Models
{
    public class SooftAppContext : DbContext
    {

        public SooftAppContext() : base("name=SooftDb2")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            //Database.SetInitializer<SooftAppContext>(new DropCreateDatabaseIfModelChanges<SooftAppContext>());
            Database.SetInitializer(new DbInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>()
                .HasKey(t => new { t.Id });

            modelBuilder.Entity<Direccion>()
                .HasKey(t => new { t.Id });

            modelBuilder.Entity<TipoCliente>()
                .HasKey(t => new { t.Id });

            modelBuilder.Entity<DireccionPais>()
                .HasKey(t => new { t.Id });

        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Direccion> Direcciones { get; set; }

        public DbSet<TipoCliente> TipoClientes { get; set; }

        public DbSet<DireccionPais> DireccionPaises { get; set; }

    }
}