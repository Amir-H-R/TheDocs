using Persistance.Common;
using Persistance.Entities;
using Persistance.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Services.UserServices
{
    public class EditUserService
    {
        IModel1 _model1;
        public EditUserService(IModel1 model1)
        {
            _model1 = model1;
        }
        public ResultDto Execute(UserDto userDto)
        {
            var validation = UserValidator.Validate(userDto, _model1);
            if (validation.Success)
            {
                var person = _model1.People.FirstOrDefault(p => p.PersonId == userDto.Id);
                person.IdCardNumber = userDto.IdCardNumber;
                person.PhoneNumber = userDto.PhoneNumber;
                person.Name = userDto.Name;
                person.LastName = userDto.LastName;
                person.Age = userDto.Age;
                person.Password = userDto.Password;
                person.UserName = userDto.Username;
                ICollection<PeopleRoles> roles = new List<PeopleRoles>();
                foreach (var role in userDto.Roles)
                {
                    var theRole = _model1.Roles.FirstOrDefault(p => p.RoleId == role.RoleId);
                    roles.Add(new PeopleRoles { PersonId = person.PersonId, Person = person, Role = theRole, RoleId = theRole.RoleId });
                }
                person.PeopleRoles = roles;
                _model1.SaveChanges();
                return new ResultDto() { Message = "تغییرات ثبت گردید", Success = true };
            }
            else
                return new ResultDto() { Message = validation.Message, Success = false };
        }
    }
}
