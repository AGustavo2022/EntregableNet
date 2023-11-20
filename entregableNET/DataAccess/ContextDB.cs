using Microsoft.EntityFrameworkCore;
using entregableNET.Entities;

namespace entregableNET.DataAccess
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions options) : base(options)
        { 

        }

        public DbSet<Tasks> Tasks { get; set; }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);
    }
}

        


