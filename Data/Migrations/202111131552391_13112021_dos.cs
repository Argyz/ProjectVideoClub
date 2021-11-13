namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _13112021_dos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StockMovies", "Date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StockMovies", "Date", c => c.DateTime(nullable: false));
        }
    }
}
