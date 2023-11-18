namespace TheDuckingDocs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false),
                        Country = c.String(),
                        Province = c.String(),
                        City = c.String(),
                        ZipCode = c.String(),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.Patients", t => t.AddressId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        BirthDate = c.DateTime(nullable: false),
                        AddressId = c.Int(nullable: false),
                        PatientInfo_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.PatientId)
                .ForeignKey("dbo.People", t => t.PatientInfo_PersonId)
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
                        PersonId = c.Int(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                        IdCardNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.PeopleRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.PersonId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
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
                "dbo.Staffs",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        StaffInfo_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.StaffId)
                .ForeignKey("dbo.People", t => t.StaffInfo_PersonId)
                .Index(t => t.StaffInfo_PersonId);
            
            CreateTable(
                "dbo.RolePersons",
                c => new
                    {
                        Role_RoleId = c.Int(nullable: false),
                        Person_PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_RoleId, t.Person_PersonId })
                .ForeignKey("dbo.Roles", t => t.Role_RoleId, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.Person_PersonId, cascadeDelete: true)
                .Index(t => t.Role_RoleId)
                .Index(t => t.Person_PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Staffs", "StaffInfo_PersonId", "dbo.People");
            DropForeignKey("dbo.Appointments", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Addresses", "AddressId", "dbo.Patients");
            DropForeignKey("dbo.Patients", "PatientInfo_PersonId", "dbo.People");
            DropForeignKey("dbo.PeopleRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.RolePersons", "Person_PersonId", "dbo.People");
            DropForeignKey("dbo.RolePersons", "Role_RoleId", "dbo.Roles");
            DropForeignKey("dbo.PeopleRoles", "PersonId", "dbo.People");
            DropForeignKey("dbo.UserCredentials", "Id", "dbo.People");
            DropIndex("dbo.RolePersons", new[] { "Person_PersonId" });
            DropIndex("dbo.RolePersons", new[] { "Role_RoleId" });
            DropIndex("dbo.Staffs", new[] { "StaffInfo_PersonId" });
            DropIndex("dbo.Appointments", new[] { "PatientId" });
            DropIndex("dbo.Appointments", new[] { "StaffId" });
            DropIndex("dbo.PeopleRoles", new[] { "RoleId" });
            DropIndex("dbo.PeopleRoles", new[] { "PersonId" });
            DropIndex("dbo.UserCredentials", new[] { "Id" });
            DropIndex("dbo.Patients", new[] { "PatientInfo_PersonId" });
            DropIndex("dbo.Addresses", new[] { "AddressId" });
            DropTable("dbo.RolePersons");
            DropTable("dbo.Staffs");
            DropTable("dbo.Appointments");
            DropTable("dbo.Roles");
            DropTable("dbo.PeopleRoles");
            DropTable("dbo.UserCredentials");
            DropTable("dbo.People");
            DropTable("dbo.Patients");
            DropTable("dbo.Addresses");
        }
    }
}
