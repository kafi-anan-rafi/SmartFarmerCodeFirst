namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserRelationAdded : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Advisors");
            DropPrimaryKey("dbo.Doctors");
            DropPrimaryKey("dbo.Farmers");
            AlterColumn("dbo.Advisors", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Doctors", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Farmers", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Advisors", "Id");
            AddPrimaryKey("dbo.Doctors", "Id");
            AddPrimaryKey("dbo.Farmers", "Id");
            CreateIndex("dbo.Advisors", "Id");
            CreateIndex("dbo.Doctors", "Id");
            CreateIndex("dbo.Farmers", "Id");
            AddForeignKey("dbo.Doctors", "Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Farmers", "Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Advisors", "Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Advisors", "Id", "dbo.Users");
            DropForeignKey("dbo.Farmers", "Id", "dbo.Users");
            DropForeignKey("dbo.Doctors", "Id", "dbo.Users");
            DropIndex("dbo.Farmers", new[] { "Id" });
            DropIndex("dbo.Doctors", new[] { "Id" });
            DropIndex("dbo.Advisors", new[] { "Id" });
            DropPrimaryKey("dbo.Farmers");
            DropPrimaryKey("dbo.Doctors");
            DropPrimaryKey("dbo.Advisors");
            AlterColumn("dbo.Farmers", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Doctors", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Users", "Type", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Advisors", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Farmers", "Id");
            AddPrimaryKey("dbo.Doctors", "Id");
            AddPrimaryKey("dbo.Advisors", "Id");
        }
    }
}
