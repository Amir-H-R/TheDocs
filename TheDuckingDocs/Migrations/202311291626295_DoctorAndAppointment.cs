namespace TheDuckingDocs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoctorAndAppointment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "StaffId", "dbo.Staffs");
            DropIndex("dbo.Appointments", new[] { "StaffId" });
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorId = c.Int(nullable: false, identity: true),
                        DoctorInfo_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.DoctorId)
                .ForeignKey("dbo.People", t => t.DoctorInfo_PersonId)
                .Index(t => t.DoctorInfo_PersonId);
            
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
                        Doctor_DoctorId = c.Int(),
                    })
                .PrimaryKey(t => t.SpecializationId)
                .ForeignKey("dbo.Doctors", t => t.Doctor_DoctorId)
                .Index(t => t.Doctor_DoctorId);
            
            AddColumn("dbo.Appointments", "DoctorId", c => c.Int(nullable: false));
            AddColumn("dbo.Appointments", "StartTime", c => c.DateTime());
            AddColumn("dbo.Appointments", "EndTime", c => c.DateTime());
            AddColumn("dbo.Appointments", "Status", c => c.Int(nullable: false));
            CreateIndex("dbo.Appointments", "DoctorId");
            AddForeignKey("dbo.Appointments", "DoctorId", "dbo.Doctors", "DoctorId", cascadeDelete: true);
            DropColumn("dbo.Appointments", "StaffId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "StaffId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Appointments", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Specializations", "Doctor_DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.DoctorSpecializations", "SpecializationId", "dbo.Specializations");
            DropForeignKey("dbo.DoctorSpecializations", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "DoctorInfo_PersonId", "dbo.People");
            DropIndex("dbo.Specializations", new[] { "Doctor_DoctorId" });
            DropIndex("dbo.DoctorSpecializations", new[] { "DoctorId" });
            DropIndex("dbo.DoctorSpecializations", new[] { "SpecializationId" });
            DropIndex("dbo.Doctors", new[] { "DoctorInfo_PersonId" });
            DropIndex("dbo.Appointments", new[] { "DoctorId" });
            DropColumn("dbo.Appointments", "Status");
            DropColumn("dbo.Appointments", "EndTime");
            DropColumn("dbo.Appointments", "StartTime");
            DropColumn("dbo.Appointments", "DoctorId");
            DropTable("dbo.Specializations");
            DropTable("dbo.DoctorSpecializations");
            DropTable("dbo.Doctors");
            CreateIndex("dbo.Appointments", "StaffId");
            AddForeignKey("dbo.Appointments", "StaffId", "dbo.Staffs", "StaffId", cascadeDelete: true);
        }
    }
}
