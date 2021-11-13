namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12112021_tres : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockMovies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Gender = c.String(),
                        Date = c.DateTime(nullable: false),
                        Removed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StockMovies");
        }
    }
}
