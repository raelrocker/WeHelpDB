namespace WeHelpDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddressCorrection : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "Complement", c => c.String(maxLength: 30));
            AlterColumn("dbo.Events", "Number", c => c.Int());
            AlterColumn("dbo.Ongs", "Complement", c => c.String(maxLength: 30));
            AlterColumn("dbo.Ongs", "Number", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ongs", "Number", c => c.Int(nullable: false));
            AlterColumn("dbo.Ongs", "Complement", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Events", "Number", c => c.Int(nullable: false));
            AlterColumn("dbo.Events", "Complement", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
