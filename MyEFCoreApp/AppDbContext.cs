using Microsoft.EntityFrameworkCore;

namespace MyEFCoreApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // SQLite-DB im Projektverzeichnis anlegen
            optionsBuilder.UseSqlite("Data Source=localdb.db");
        }
    }
}
