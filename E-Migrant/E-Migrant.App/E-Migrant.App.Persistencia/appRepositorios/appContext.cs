using Microsoft.EntityFrameworkCore;
using E_Migrant.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
namespace E_Migrant.App.Persistencia.appRepositorios
{
    public class appContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; } // Leandro: ¿Si necesita una tabla?
        public DbSet<Entidad> Entidad { get; set; }
        public DbSet<Migrante> Migrante { get; set; }
        public DbSet<Servicio> Servicio { get; set; }
        public DbSet<SolicitudServicio> SolicitudServicio { get; set; }
        public DbSet<SolicitudEmergencia> SolicitudEmergencia { get; set; }
        public DbSet<Novedad> Novedad { get; set; }
        public DbSet<Mensaje> Mensaje { get; set; }
        public DbSet<Necesidad> Necesidad { get; set; }
        public DbSet<Emergencia> Emergencia {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EMigrant.Data");
            }
        }
        /*protected override void OnModelCreating(Modelbuilder modelBuilder)
        {
            modelBuilder.Entity<Entidad>()
                .HasMany(c => c.Servicio)
                .WithOne(e => e.Entidad);
        }*/

    }
}