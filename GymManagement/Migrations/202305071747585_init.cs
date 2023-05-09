namespace GymManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminActivities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        AdminId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.AdminId)
                .Index(t => t.AdminId);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Family = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        AdminId = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.AdminId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.AdminId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Family = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        NationalCode = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        DurationStart = c.DateTime(nullable: false),
                        DurationEnd = c.DateTime(nullable: false),
                        AdminId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.AdminId)
                .Index(t => t.AdminId);
            
            CreateTable(
                "dbo.InstallmentOptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Tag = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Description = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdminActivities", "AdminId", "dbo.Admins");
            DropForeignKey("dbo.Transactions", "UserId", "dbo.Users");
            DropForeignKey("dbo.InstallmentOptions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "AdminId", "dbo.Admins");
            DropForeignKey("dbo.Transactions", "AdminId", "dbo.Admins");
            DropIndex("dbo.InstallmentOptions", new[] { "User_Id" });
            DropIndex("dbo.Users", new[] { "AdminId" });
            DropIndex("dbo.Transactions", new[] { "AdminId" });
            DropIndex("dbo.Transactions", new[] { "UserId" });
            DropIndex("dbo.AdminActivities", new[] { "AdminId" });
            DropTable("dbo.InstallmentOptions");
            DropTable("dbo.Users");
            DropTable("dbo.Transactions");
            DropTable("dbo.Admins");
            DropTable("dbo.AdminActivities");
        }
    }
}
