namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _13112021 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Pelicula", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Clients", "User");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "User", c => c.String(nullable: false, maxLength: 30));
            DropColumn("dbo.Clients", "Pelicula");
        }
    }
}
