using System.Data.Entity;

namespace AteaPackageManager.Entities
{
    public class FilmContext : DbContext
    {
        public FilmContext() : base("name=FilmContextConnectionString")
        {

        }

        public DbSet<Film> Films { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public DbSet<Screenshot> Screenshots { get; set; }
    }
}