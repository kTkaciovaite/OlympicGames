using System.Data.Entity;
using OlympicGames.Domain;

namespace OlympicGames.DataAccess
{
    public class OlympicGamesContext : DbContext
    {
        public OlympicGamesContext() : base()
        {
            Database.SetInitializer(new OlympicGamesInitializer());
        }

        public DbSet<Country> Country { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<Sportsperson> Sportsperson { get; set; }
        public DbSet<Coach> Coach { get; set; }
        public DbSet<Team> Team { get; set; }
    }
}
