namespace WeHelpDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StatusEventFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "EventStatus", c => c.String(nullable: false, maxLength: 1, fixedLength: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "EventStatus", c => c.Int(nullable: false));
        }
    }
}
