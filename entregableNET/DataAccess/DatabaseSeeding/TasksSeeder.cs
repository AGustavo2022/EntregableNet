using entregableNET.Entities;
using Microsoft.EntityFrameworkCore;

namespace entregableNET.DataAccess.DatabaseSeeding
{
    public class TasksSeeder : IEntitySeeder
    {
        public void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tasks>().HasData(
                new Tasks
                {
                    Id = 1,
                    Title = "test",
                    Description = "test de prueba",
                    IsCompleted = true
                    
                });
        }
    }
}
