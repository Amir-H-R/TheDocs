using Persistance.Common;
using Persistance.Entities;
using Persistance.Entities.Dtos;
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

        public ResultDto<Person> Execute(UserDto dto)
        {
            Person person = new Person()
            {
                Name = dto.Name,
                LastName = dto.LastName,
                Age = dto.Age,
                PhoneNumber = dto.PhoneNumber,
                IdCardNumber = dto.IdCardNumber,
                Password = dto.Password,
                UserName = dto.Username
            };
            var userValidation = UserValidator.Validate(dto, _context);
            if (userValidation.Success)
            {
                ICollection<PeopleRoles> peopleRoles = new List<PeopleRoles>();
                foreach (var role in dto.Roles)
                {
                    Role theRole = _context.Roles.Where(p => p.Name == role.Name || p.RoleId == role.RoleId).FirstOrDefault();
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
                return new ResultDto<Person> { Data = person, Message = "ثبت نام با موفقیت انجام شد", Success = true };
            }
            else
                return new ResultDto<Person> { Data = person, Message = userValidation.Message, Success = false };
        }
    }
}
