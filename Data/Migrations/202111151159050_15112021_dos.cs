namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _15112021_dos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Name", c => c.String());
            AlterColumn("dbo.Clients", "LastName", c => c.String());
            AlterColumn("dbo.Movements", "Name", c => c.String());
            AlterColumn("dbo.StockMovies", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StockMovies", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Movements", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Clients", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Clients", "Name", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
