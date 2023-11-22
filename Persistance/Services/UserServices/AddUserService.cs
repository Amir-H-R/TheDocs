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

        public ResultDto Execute(UserDto dto)
        {
            Person person = new Person()
            {
                Name = dto.Name,
                LastName = dto.LastName,
                Age = dto.Age,
                PhoneNumber = dto.PhoneNumber,
                IdCardNumber = dto.IdCardNumebr,
                Password = dto.Password,
                UserName = dto.Username
            };

            //check user existence
            //var username = _context.People.Where(p => p.UserName == dto.Username).FirstOrDefault();
            //var idCardNumber = _context.People.Where(p => p.IdCardNumber == dto.IdCardNumebr).FirstOrDefault();
            //if (dto.Username == null||dto.IdCardNumebr==null||dto.PhoneNumber==null||dto.LastName==null||dto.Name==null||dto.Age==null||dto.Password==null)
            //    return new ResultDto { Message = "لطفا همه مقادیر را وارد کنید", Success = false };
            //if (username != null)
            //    return new ResultDto { Message = "این نام کاربری قبلا استفاده شده است", Success = false };
            //if (idCardNumber != null)
            //    return new ResultDto { Message = "این کد ملی قبلا استفاده شده است", Success = false };
            var userValidation = UserValidator.Validate(dto, _context);
            if (userValidation.Success)
            {
                ICollection<PeopleRoles> peopleRoles = new List<PeopleRoles>();
                foreach (var role in dto.Roles)
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
                return new ResultDto { Message = "ثبت نام با موفقیت انجام شد", Success = true };
            }
            else 
            return new ResultDto {Message="عملیات با خطا مواجه شد", Success = false };
        }
    }
}
