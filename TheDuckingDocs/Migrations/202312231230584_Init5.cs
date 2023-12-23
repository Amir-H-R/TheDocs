namespace TheDuckingDocs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        DoctorId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        AppointmentDate = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.AppointmentId)
                .Index(t => t.AppointmentId)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorId = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        DoctorInfo_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.DoctorId)
                .ForeignKey("dbo.People", t => t.DoctorInfo_PersonId)
                .Index(t => t.DoctorInfo_PersonId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        IdCardNumber = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
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
                "dbo.DoctorSpecializations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SpecializationId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Specializations", t => t.SpecializationId, cascadeDelete: true)
                .Index(t => t.SpecializationId)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Specializations",
                c => new
                    {
                        SpecializationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SpecializationId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        BirthDate = c.DateTime(nullable: false),
                        Address = c.String(),
                        AppointmentId = c.Int(nullable: false),
                        PatientInfo_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.PatientId)
                .ForeignKey("dbo.People", t => t.PatientInfo_PersonId)
                .Index(t => t.PatientInfo_PersonId);
            
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
            
            CreateTable(
                "dbo.SpecializationDoctors",
                c => new
                    {
                        Specialization_SpecializationId = c.Int(nullable: false),
                        Doctor_DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Specialization_SpecializationId, t.Doctor_DoctorId })
                .ForeignKey("dbo.Specializations", t => t.Specialization_SpecializationId, cascadeDelete: true)
                .ForeignKey("dbo.Doctors", t => t.Doctor_DoctorId, cascadeDelete: true)
                .Index(t => t.Specialization_SpecializationId)
                .Index(t => t.Doctor_DoctorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "StaffInfo_PersonId", "dbo.People");
            DropForeignKey("dbo.Appointments", "AppointmentId", "dbo.Patients");
            DropForeignKey("dbo.Patients", "PatientInfo_PersonId", "dbo.People");
            DropForeignKey("dbo.Appointments", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.DoctorSpecializations", "SpecializationId", "dbo.Specializations");
            DropForeignKey("dbo.SpecializationDoctors", "Doctor_DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.SpecializationDoctors", "Specialization_SpecializationId", "dbo.Specializations");
            DropForeignKey("dbo.DoctorSpecializations", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "DoctorInfo_PersonId", "dbo.People");
            DropForeignKey("dbo.PeopleRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.RolePersons", "Person_PersonId", "dbo.People");
            DropForeignKey("dbo.RolePersons", "Role_RoleId", "dbo.Roles");
            DropForeignKey("dbo.PeopleRoles", "PersonId", "dbo.People");
            DropIndex("dbo.SpecializationDoctors", new[] { "Doctor_DoctorId" });
            DropIndex("dbo.SpecializationDoctors", new[] { "Specialization_SpecializationId" });
            DropIndex("dbo.RolePersons", new[] { "Person_PersonId" });
            DropIndex("dbo.RolePersons", new[] { "Role_RoleId" });
            DropIndex("dbo.Staffs", new[] { "StaffInfo_PersonId" });
            DropIndex("dbo.Patients", new[] { "PatientInfo_PersonId" });
            DropIndex("dbo.DoctorSpecializations", new[] { "DoctorId" });
            DropIndex("dbo.DoctorSpecializations", new[] { "SpecializationId" });
            DropIndex("dbo.PeopleRoles", new[] { "RoleId" });
            DropIndex("dbo.PeopleRoles", new[] { "PersonId" });
            DropIndex("dbo.Doctors", new[] { "DoctorInfo_PersonId" });
            DropIndex("dbo.Appointments", new[] { "DoctorId" });
            DropIndex("dbo.Appointments", new[] { "AppointmentId" });
            DropTable("dbo.SpecializationDoctors");
            DropTable("dbo.RolePersons");
            DropTable("dbo.Staffs");
            DropTable("dbo.Patients");
            DropTable("dbo.Specializations");
            DropTable("dbo.DoctorSpecializations");
            DropTable("dbo.Roles");
            DropTable("dbo.PeopleRoles");
            DropTable("dbo.People");
            DropTable("dbo.Doctors");
            DropTable("dbo.Appointments");
        }
    }
}
