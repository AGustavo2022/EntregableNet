using Microsoft.EntityFrameworkCore;

namespace entregableNET.DataAccess.DatabaseSeeding
{
    public interface IEntitySeeder
    {
        void SeedDatabase(ModelBuilder modelBuilder);
    }
}
