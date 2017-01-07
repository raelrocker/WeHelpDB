namespace WeHelpDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequirementUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RequirementUser",
                c => new
                    {
                        RequirementId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Quant = c.Decimal(nullable: false, precision: 6, scale: 2),
                        Unity = c.String(nullable: false, maxLength: 2, fixedLength: true),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.RequirementId, t.UserId })
                .ForeignKey("dbo.Requirements", t => t.RequirementId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.RequirementId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RequirementUser", "UserId", "dbo.Users");
            DropForeignKey("dbo.RequirementUser", "RequirementId", "dbo.Requirements");
            DropIndex("dbo.RequirementUser", new[] { "UserId" });
            DropIndex("dbo.RequirementUser", new[] { "RequirementId" });
            DropTable("dbo.RequirementUser");
        }
    }
}
