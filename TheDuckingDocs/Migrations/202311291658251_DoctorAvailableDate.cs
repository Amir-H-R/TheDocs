namespace TheDuckingDocs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoctorAvailableDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "StartTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Doctors", "EndTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doctors", "EndTime");
            DropColumn("dbo.Doctors", "StartTime");
        }
    }
}
