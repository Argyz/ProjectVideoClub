namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12112021_dos : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Gender");
            DropColumn("dbo.Movies", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Gender", c => c.String());
        }
    }
}
