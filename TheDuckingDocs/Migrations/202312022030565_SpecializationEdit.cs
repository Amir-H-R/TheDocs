namespace TheDuckingDocs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpecializationEdit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Specializations", "Doctor_DoctorId", "dbo.Doctors");
            DropIndex("dbo.Specializations", new[] { "Doctor_DoctorId" });
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
            
            DropColumn("dbo.Specializations", "Doctor_DoctorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Specializations", "Doctor_DoctorId", c => c.Int());
            DropForeignKey("dbo.SpecializationDoctors", "Doctor_DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.SpecializationDoctors", "Specialization_SpecializationId", "dbo.Specializations");
            DropIndex("dbo.SpecializationDoctors", new[] { "Doctor_DoctorId" });
            DropIndex("dbo.SpecializationDoctors", new[] { "Specialization_SpecializationId" });
            DropTable("dbo.SpecializationDoctors");
            CreateIndex("dbo.Specializations", "Doctor_DoctorId");
            AddForeignKey("dbo.Specializations", "Doctor_DoctorId", "dbo.Doctors", "DoctorId");
        }
    }
}
