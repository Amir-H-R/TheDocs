namespace TheDuckingDocs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserCredentialMergedToUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserCredentials", "Id", "dbo.People");
            DropIndex("dbo.UserCredentials", new[] { "Id" });
            AddColumn("dbo.People", "UserName", c => c.String());
            AddColumn("dbo.People", "Password", c => c.String());
            AddColumn("dbo.People", "IdCardNumber", c => c.String());
            DropTable("dbo.UserCredentials");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.People", "IdCardNumber");
            DropColumn("dbo.People", "Password");
            DropColumn("dbo.People", "UserName");
            CreateIndex("dbo.UserCredentials", "Id");
            AddForeignKey("dbo.UserCredentials", "Id", "dbo.People", "PersonId");
        }
    }
}
