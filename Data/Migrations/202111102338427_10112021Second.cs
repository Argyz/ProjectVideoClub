namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10112021Second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "User", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Clients", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Clients", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Movies", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Gender", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "User", c => c.String(nullable: false));
        }
    }
}
