namespace TheDuckingDocs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        Province = c.String(),
                        City = c.String(),
                        ZipCode = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        StaffId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.StaffId, cascadeDelete: true)
                .Index(t => t.StaffId)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        BirthDate = c.DateTime(nullable: false),
                        PatientAddress_AddressId = c.Int(),
                        PatientInfo_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.PatientId)
                .ForeignKey("dbo.Addresses", t => t.PatientAddress_AddressId)
                .ForeignKey("dbo.People", t => t.PatientInfo_PersonId)
                .Index(t => t.PatientAddress_AddressId)
                .Index(t => t.PatientInfo_PersonId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.UserCredentials",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        PersonId = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        IdCardNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        StaffAddress_AddressId = c.Int(),
                        StaffInfo_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.StaffId)
                .ForeignKey("dbo.Addresses", t => t.StaffAddress_AddressId)
                .ForeignKey("dbo.People", t => t.StaffInfo_PersonId)
                .Index(t => t.StaffAddress_AddressId)
                .Index(t => t.StaffInfo_PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Staffs", "StaffInfo_PersonId", "dbo.People");
            DropForeignKey("dbo.Staffs", "StaffAddress_AddressId", "dbo.Addresses");
            DropForeignKey("dbo.Appointments", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Patients", "PatientInfo_PersonId", "dbo.People");
            DropForeignKey("dbo.UserCredentials", "Id", "dbo.People");
            DropForeignKey("dbo.Patients", "PatientAddress_AddressId", "dbo.Addresses");
            DropIndex("dbo.Staffs", new[] { "StaffInfo_PersonId" });
            DropIndex("dbo.Staffs", new[] { "StaffAddress_AddressId" });
            DropIndex("dbo.UserCredentials", new[] { "Id" });
            DropIndex("dbo.Patients", new[] { "PatientInfo_PersonId" });
            DropIndex("dbo.Patients", new[] { "PatientAddress_AddressId" });
            DropIndex("dbo.Appointments", new[] { "PatientId" });
            DropIndex("dbo.Appointments", new[] { "StaffId" });
            DropTable("dbo.Staffs");
            DropTable("dbo.UserCredentials");
            DropTable("dbo.People");
            DropTable("dbo.Patients");
            DropTable("dbo.Appointments");
            DropTable("dbo.Addresses");
        }
    }
}
