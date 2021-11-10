using System.Data.Entity;
using Entity;

namespace Data
{
    public class VideoContext : DbContext
    {
        public VideoContext() : base(@"Data Source=DESKTOP-AKCIL0Q\ALEXDEV;Initial Catalog=VideoClub;User Id=sa; Password=hackingadict;")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
