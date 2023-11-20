using Persistance.Common;
using Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Services.UserServices
{
    public class AddUserService
    {
        private readonly IModel1 _context;
        public AddUserService(IModel1 context)
        {
            _context = context;
        }

        public ResultDto Execute(string name, string lastName, string phoneNumber, string idCardNumebr, int age, string username, string password, ICollection<Role> roles)
        {
            Person person = new Person()
            {
                Name = name,
                LastName = lastName,
                Age = age,
                PhoneNumber = phoneNumber,
                IdCardNumber = idCardNumebr,
                Password = password,
                UserName = username
            };

            ICollection<PeopleRoles> peopleRoles = new List<PeopleRoles>();
            foreach (var role in roles)
            {
                Role theRole = _context.Roles.Where(p => p.Name == role.Name).FirstOrDefault();
                peopleRoles.Add(new PeopleRoles
                {
                    Person = person,
                    PersonId = person.PersonId,
                    RoleId = theRole.RoleId,
                    Role = theRole,
                });
            }
            person.PeopleRoles = peopleRoles;
            _context.People.Add(person);
            _context.SaveChanges();
            return new ResultDto { Message = "کاربر با موفقیت اضافه شد" ,Success = true};
        }
    }
}
