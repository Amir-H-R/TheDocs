namespace TheDuckingDocs.Migrations
{
    using Persistance.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TheDuckingDocs.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TheDuckingDocs.Model1 context)
        {
            context.Roles.AddOrUpdate(new Role { RoleId = 1, Name = "Admin" });
            context.Roles.AddOrUpdate(new Role { RoleId = 2, Name = "Patient" });
            context.Roles.AddOrUpdate(new Role { RoleId = 3, Name = "Staff" });
            context.Roles.AddOrUpdate(new Role { RoleId = 4, Name = "Doctor" });
            context.Roles.AddOrUpdate(new Role { RoleId = 5, Name = "User" });

            ICollection<PeopleRoles> peopleRoles = new List<PeopleRoles>();
            Person person = new Person
            {
                PersonId = 1,
                UserName = "admin",
                Password = "admin",
                Name = "admin",
                LastName = "admin",
                PhoneNumber = "0",
                IdCardNumber = "0",
                Age = 0,
            };
            Role role = context.Roles.Where(p => p.Name == "Admin").FirstOrDefault();
            peopleRoles.Add(new PeopleRoles
            {
                Person = person,
                PersonId = 1,
                RoleId = 1,
                Role = role
            });
            person.PeopleRoles = peopleRoles;
            context.People.AddOrUpdate(person);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
