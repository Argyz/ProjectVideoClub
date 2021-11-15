namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _15112021_uno : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clients", "Pelicula");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Pelicula", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
