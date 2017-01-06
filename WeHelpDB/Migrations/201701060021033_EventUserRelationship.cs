namespace WeHelpDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventUserRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventUser",
                c => new
                    {
                        EventId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.EventId, t.UserId })
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.EventId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EventUser", "UserId", "dbo.Users");
            DropForeignKey("dbo.EventUser", "EventId", "dbo.Events");
            DropIndex("dbo.EventUser", new[] { "UserId" });
            DropIndex("dbo.EventUser", new[] { "EventId" });
            DropTable("dbo.EventUser");
        }
    }
}
