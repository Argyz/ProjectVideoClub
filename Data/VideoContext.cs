﻿using System.Data.Entity;
using Entity;

namespace Data
{
    public class VideoContext : DbContext
    {
        public VideoContext() : base(@"Data Source=DESKTOP-AKCIL0Q\ALEXDEV;Initial Catalog=VideoClub;User Id=sa; Password=hackingadict;")
        {

        }


        public DbSet<User> Users { get; set; }  
        public DbSet<StockMovie> StockMovies { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Movement> Movements { get; set; }
    }
}
