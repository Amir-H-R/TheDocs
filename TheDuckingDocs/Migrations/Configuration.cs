namespace TheDuckingDocs.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Persistance.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<TheDuckingDocs.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TheDuckingDocs.Model1 context)
        {
            context.Roles.AddOrUpdate(new Role { RoleId = 1,Name = "Admin"});
            context.Roles.AddOrUpdate(new Role { RoleId = 2,Name = "Patient"});
            context.Roles.AddOrUpdate(new Role { RoleId = 3,Name = "Staff"});
            context.Roles.AddOrUpdate(new Role { RoleId = 4,Name = "Doctor"});
            context.Roles.AddOrUpdate(new Role { RoleId = 5,Name = "User"});
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
