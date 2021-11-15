namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _15112021 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Movies", newName: "Movements");
            AddColumn("dbo.StockMovies", "Amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StockMovies", "Amount");
            RenameTable(name: "dbo.Movements", newName: "Movies");
        }
    }
}
