namespace WeHelpDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 300),
                        StartDate = c.DateTime(nullable: false),
                        FinishDate = c.DateTime(),
                        Street = c.String(nullable: false, maxLength: 50),
                        Complement = c.String(nullable: false, maxLength: 30),
                        Number = c.Int(nullable: false),
                        Zip = c.String(nullable: false, maxLength: 9),
                        City = c.String(nullable: false, maxLength: 50),
                        State = c.String(nullable: false, maxLength: 2, fixedLength: true),
                        Lat = c.Decimal(nullable: false, precision: 17, scale: 14),
                        Lng = c.Decimal(nullable: false, precision: 17, scale: 14),
                        EventStatus = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EventId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.UserId);
            
            AlterColumn("dbo.Ongs", "Complement", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Ongs", "Number", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Events", "UserId", "dbo.Users");
            DropIndex("dbo.Events", new[] { "UserId" });
            DropIndex("dbo.Events", new[] { "CategoryId" });
            AlterColumn("dbo.Ongs", "Number", c => c.Int());
            AlterColumn("dbo.Ongs", "Complement", c => c.String(maxLength: 30));
            DropTable("dbo.Events");
        }
    }
}
