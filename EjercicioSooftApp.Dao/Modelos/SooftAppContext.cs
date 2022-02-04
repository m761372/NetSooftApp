using System;
using System.Data.Entity;
using System.Linq;

namespace EjercicioSooftApp.Dao.Modelos
{
    public class SooftAppContext : DbContext
    {

        public SooftAppContext() : base("name=SooftDb2")
        {
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

        public DbSet<Direccion> Direccion { get; set; }

        public DbSet<Cliente> TipoCliente { get; set; }

        public DbSet<DireccionPais> DireccionPais { get; set; }

    }
}