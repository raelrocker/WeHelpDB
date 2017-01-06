namespace WeHelpDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequirementTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Requirements",
                c => new
                    {
                        RequirementId = c.Int(nullable: false, identity: true),
                        EventoId = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 50),
                        Quant = c.Decimal(nullable: false, precision: 6, scale: 2),
                        Unity = c.String(nullable: false, maxLength: 2, fixedLength: true),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RequirementId)
                .ForeignKey("dbo.Events", t => t.EventoId, cascadeDelete: true)
                .Index(t => t.EventoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requirements", "EventoId", "dbo.Events");
            DropIndex("dbo.Requirements", new[] { "EventoId" });
            DropTable("dbo.Requirements");
        }
    }
}
