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
        public ResultDto<int> Execute(UserDto userDto)
        {
            try
            {
                var person = _model1.People.FirstOrDefault(p => p.PersonId == userDto.Id);
                person.IdCardNumber = userDto.IdCardNumber;
                person.PhoneNumber = userDto.PhoneNumber;
                person.Name = userDto.Name;
                person.LastName = userDto.LastName;
                person.Age = userDto.Age;
                person.Password = userDto.Password;
                person.UserName = userDto.Username;
                _model1.SaveChanges();
                return new ResultDto<int>() { Data = person.PersonId, Message = "تغییرات کاربر ثبت گردید", Success = true };
            }
            catch (Exception)
            {
                return new ResultDto<int>() {Message = "عملیات با خطا مواجه شد" ,Success = false};
            }

        }
    }
}
