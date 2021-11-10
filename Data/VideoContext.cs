using System.Data.Entity;
using Entity;

namespace Data
{
    public class VideoContext : DbContext
    {
        public VideoContext() : base()
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
