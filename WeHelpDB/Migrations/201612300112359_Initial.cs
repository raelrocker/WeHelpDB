namespace WeHelpDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ongs",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Cnpj = c.String(nullable: false, maxLength: 18),
                        Photo = c.Binary(),
                        Street = c.String(nullable: false, maxLength: 50),
                        Complement = c.String(maxLength: 30),
                        Number = c.Int(),
                        Zip = c.String(nullable: false, maxLength: 9),
                        City = c.String(nullable: false, maxLength: 50),
                        State = c.String(nullable: false, maxLength: 2, fixedLength: true),
                        Lat = c.Decimal(nullable: false, precision: 17, scale: 14),
                        Lng = c.Decimal(nullable: false, precision: 17, scale: 14),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 100),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Photo = c.Binary(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "UserId", "dbo.Users");
            DropForeignKey("dbo.Ongs", "UserId", "dbo.Users");
            DropIndex("dbo.People", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Ongs", new[] { "UserId" });
            DropTable("dbo.People");
            DropTable("dbo.Users");
            DropTable("dbo.Ongs");
        }
    }
}
