namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdvisorAndOrderTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advisors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        HourlyRate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Category = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
            DropTable("dbo.Advisors");
        }
    }
}
