using Microsoft.EntityFrameworkCore;
using entregableNET.Entities;
using entregableNET.DataAccess.DatabaseSeeding;

namespace entregableNET.DataAccess
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions options) : base(options) {}

        public DbSet<Tasks> Tasks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seeders = new List<IEntitySeeder>
            {
                new TasksSeeder(),
            };

            foreach (var seeder in seeders)
            {

                seeder.SeedDatabase(modelBuilder);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}

        


