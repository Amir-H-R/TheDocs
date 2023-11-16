namespace TheDuckingDocs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddressToPatientEntityIdCardNumber : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "PersonId", "dbo.Addresses");
            DropForeignKey("dbo.Patients", "PatientAddress_AddressId", "dbo.Addresses");
            DropIndex("dbo.People", new[] { "PersonId" });
            DropIndex("dbo.Patients", new[] { "PatientAddress_AddressId" });
            DropPrimaryKey("dbo.Addresses");
            AddColumn("dbo.Addresses", "PatientId", c => c.Int(nullable: false));
            AddColumn("dbo.People", "IdCardNumber", c => c.String());
            AddColumn("dbo.Patients", "AddressId", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "AddressId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Addresses", "AddressId");
            CreateIndex("dbo.Addresses", "AddressId");
            AddForeignKey("dbo.Addresses", "AddressId", "dbo.Patients", "PatientId");
            DropColumn("dbo.Addresses", "PersonId");
            DropColumn("dbo.People", "AddressId");
            DropColumn("dbo.Patients", "PatientAddress_AddressId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Patients", "PatientAddress_AddressId", c => c.Int());
            AddColumn("dbo.People", "AddressId", c => c.Int(nullable: false));
            AddColumn("dbo.Addresses", "PersonId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Addresses", "AddressId", "dbo.Patients");
            DropIndex("dbo.Addresses", new[] { "AddressId" });
            DropPrimaryKey("dbo.Addresses");
            AlterColumn("dbo.Addresses", "AddressId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Patients", "AddressId");
            DropColumn("dbo.People", "IdCardNumber");
            DropColumn("dbo.Addresses", "PatientId");
            AddPrimaryKey("dbo.Addresses", "AddressId");
            CreateIndex("dbo.Patients", "PatientAddress_AddressId");
            CreateIndex("dbo.People", "PersonId");
            AddForeignKey("dbo.Patients", "PatientAddress_AddressId", "dbo.Addresses", "AddressId");
            AddForeignKey("dbo.People", "PersonId", "dbo.Addresses", "AddressId");
        }
    }
}
