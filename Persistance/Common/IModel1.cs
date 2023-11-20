using Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Common
{
    public interface IModel1
    {
         DbSet<Address> Addresses { get; set; }
         DbSet<Appointment> Appointments { get; set; }
         DbSet<Patient> Patients { get; set; }
         DbSet<Person> People { get; set; }
         DbSet<Staff> Staff { get; set; }
         DbSet<Role> Roles { get; set; }
         DbSet<PeopleRoles> PeopleRoles { get; set; }

        int SaveChanges();
    }
}
