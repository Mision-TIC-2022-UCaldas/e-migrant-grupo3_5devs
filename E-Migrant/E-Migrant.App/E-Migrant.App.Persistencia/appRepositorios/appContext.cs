using Microsoft.EntityFrameworkCore;
using E_Migrant.App.Dominio.Entidades;
namespace E_Migrant.App.Persistencia.appRepositorios
{
    public class appContext: DbContext
    {
        public DbSet<Entidad> Entidad {get;set;}
        public DbSet<Migrante> Migrante {get;set;}
        public DbSet<Servicio> Servicio {get;set;}
        public DbSet<SolicitudSerivicio> SolicitudServicio {get;set;}
        public DbSet<SolicitudEmergencia> SolicitudEmergencia {get;set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EMigrant.Data");
            }
        }
    }
}