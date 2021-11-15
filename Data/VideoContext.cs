using System.Data.Entity;
using Entity;

namespace Data
{
    public class VideoContext : DbContext
    {
        public VideoContext() : base(@"")
        {

        }

        public DbSet<StockMovie> StockMovies { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Movement> Movements { get; set; }
    }
}
