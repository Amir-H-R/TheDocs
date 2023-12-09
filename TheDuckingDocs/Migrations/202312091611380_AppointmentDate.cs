namespace TheDuckingDocs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppointmentDate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Addresses", "AddressId", "dbo.Patients");
            DropIndex("dbo.Appointments", new[] { "PatientId" });
            DropPrimaryKey("dbo.Patients");
            AddColumn("dbo.Patients", "AppointmentId", c => c.Int(nullable: false));
            AddColumn("dbo.Appointments", "AppointmentDate", c => c.DateTime());
            AlterColumn("dbo.Patients", "PatientId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Patients", "PatientId");
            CreateIndex("dbo.Patients", "PatientId");
            AddForeignKey("dbo.Patients", "PatientId", "dbo.Appointments", "AppointmentId");
            AddForeignKey("dbo.Addresses", "AddressId", "dbo.Patients", "PatientId");
            DropColumn("dbo.Appointments", "StartTime");
            DropColumn("dbo.Appointments", "EndTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "EndTime", c => c.DateTime());
            AddColumn("dbo.Appointments", "StartTime", c => c.DateTime());
            DropForeignKey("dbo.Addresses", "AddressId", "dbo.Patients");
            DropForeignKey("dbo.Patients", "PatientId", "dbo.Appointments");
            DropIndex("dbo.Patients", new[] { "PatientId" });
            DropPrimaryKey("dbo.Patients");
            AlterColumn("dbo.Patients", "PatientId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Appointments", "AppointmentDate");
            DropColumn("dbo.Patients", "AppointmentId");
            AddPrimaryKey("dbo.Patients", "PatientId");
            CreateIndex("dbo.Appointments", "PatientId");
            AddForeignKey("dbo.Addresses", "AddressId", "dbo.Patients", "PatientId");
            AddForeignKey("dbo.Appointments", "PatientId", "dbo.Patients", "PatientId", cascadeDelete: true);
        }
    }
}
