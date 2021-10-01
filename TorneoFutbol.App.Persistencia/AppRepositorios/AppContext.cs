using Microsoft.EntityFrameworkCore;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Arbitros> Arbitros{get; set;}
        public DbSet<DirectoresTecnicos> DirectoresTecnicos{get; set;}
        public DbSet<Equipos> Equipos{get; set;}
        public DbSet<Estadios> Estadios{get; set;}
        public DbSet<InformacionPartido> InformacionPartido{get; set;}
        public DbSet<Jugadores> Jugadores{get; set;}
        public DbSet<Municipios> Municipios{get; set;}
        public DbSet<Partidos> Partidos{get; set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TorneoFutbolData");
            }
        }
    }
}




