namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class smallChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Doctors", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Doctors", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Comments", "CommentText", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Category", c => c.String(nullable: false));
            AlterColumn("dbo.Services", "ServiceType", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Services", "ServiceType", c => c.String());
            AlterColumn("dbo.Products", "Category", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.Comments", "CommentText", c => c.String());
            AlterColumn("dbo.Doctors", "Address", c => c.String());
            AlterColumn("dbo.Doctors", "Name", c => c.String());
            AlterColumn("dbo.Customers", "Address", c => c.String());
            AlterColumn("dbo.Customers", "Username", c => c.String());
        }
    }
}
