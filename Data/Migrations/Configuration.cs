namespace Data.Migrations
{
    using Entity;
    using Entity.secondary;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.VideoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.VideoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            var usuario1 = new User() {UserName="martin", Password=Encrypt.GetSHA256("tincho")};
            context.Users.Add(usuario1);

            var usuario2 = new User() { UserName = "sebastian", Password = Encrypt.GetSHA256("chuma") };
            context.Users.Add(usuario2);

            context.SaveChanges();
        }
    }
}
