namespace Hostels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Damage",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 256, unicode: false),
                        Charges = c.Double(nullable: false),
                        StudentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 8000, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 8000, unicode: false),
                        Phone = c.String(nullable: false, maxLength: 8000, unicode: false),
                        Email = c.String(nullable: false, maxLength: 8000, unicode: false),
                        Room_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Room", t => t.Room_ID)
                .Index(t => t.Room_ID);
            
            CreateTable(
                "dbo.Room",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoomName = c.String(nullable: false, maxLength: 50, unicode: false),
                        FloorName = c.String(nullable: false, maxLength: 8000, unicode: false),
                        Condition = c.String(nullable: false, maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StudentPayment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PaidIn = c.Double(nullable: false),
                        Deposit = c.Double(nullable: false),
                        Damage = c.String(nullable: false, maxLength: 8000, unicode: false),
                        Balance = c.Double(nullable: false),
                        MpesaTransaction = c.String(maxLength: 8000, unicode: false),
                        StudentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.EmployeePayment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PaidOut = c.Double(nullable: false),
                        Damage = c.Double(nullable: false),
                        Balance = c.Double(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employee", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FrstName = c.String(nullable: false, maxLength: 256, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 256, unicode: false),
                        Phone = c.String(nullable: false, maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StudentDamage",
                c => new
                    {
                        Student_ID = c.Int(nullable: false),
                        Damage_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_ID, t.Damage_ID })
                .ForeignKey("dbo.Student", t => t.Student_ID, cascadeDelete: true)
                .ForeignKey("dbo.Damage", t => t.Damage_ID, cascadeDelete: true)
                .Index(t => t.Student_ID)
                .Index(t => t.Damage_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeePayment", "EmployeeID", "dbo.Employee");
            DropForeignKey("dbo.StudentPayment", "StudentID", "dbo.Student");
            DropForeignKey("dbo.Student", "Room_ID", "dbo.Room");
            DropForeignKey("dbo.StudentDamage", "Damage_ID", "dbo.Damage");
            DropForeignKey("dbo.StudentDamage", "Student_ID", "dbo.Student");
            DropIndex("dbo.StudentDamage", new[] { "Damage_ID" });
            DropIndex("dbo.StudentDamage", new[] { "Student_ID" });
            DropIndex("dbo.EmployeePayment", new[] { "EmployeeID" });
            DropIndex("dbo.StudentPayment", new[] { "StudentID" });
            DropIndex("dbo.Student", new[] { "Room_ID" });
            DropTable("dbo.StudentDamage");
            DropTable("dbo.Employee");
            DropTable("dbo.EmployeePayment");
            DropTable("dbo.StudentPayment");
            DropTable("dbo.Room");
            DropTable("dbo.Student");
            DropTable("dbo.Damage");
        }
    }
}
