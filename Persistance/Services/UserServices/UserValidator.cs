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
    public static class UserValidator
    {
        public static ResultDto Validate(UserDto dto, IModel1 context)
        {
            var username = context.People.Where(p => p.UserName == dto.Username).FirstOrDefault();
            var idCardNumber = context.People.Where(p => p.IdCardNumber == dto.IdCardNumebr).FirstOrDefault();
            if (dto.Username == null || dto.IdCardNumebr == null || dto.PhoneNumber == null || dto.LastName == null || dto.Name == null || dto.Age == null || dto.Password == null)
                return new ResultDto { Message = "لطفا همه مقادیر را وارد کنید", Success = false };
            if (String.IsNullOrWhiteSpace(dto.Username) || String.IsNullOrWhiteSpace(dto.IdCardNumebr) || String.IsNullOrWhiteSpace(dto.PhoneNumber) || String.IsNullOrWhiteSpace(dto.LastName) || String.IsNullOrWhiteSpace(dto.Name) || dto.Age == null || dto.Age == 0 || String.IsNullOrWhiteSpace(dto.Password))
                return new ResultDto { Message = "لطفا همه مقادیر را وارد کنید", Success = false };
            if (username != null)
                return new ResultDto { Message = "این نام کاربری قبلا استفاده شده است", Success = false };
            if (idCardNumber != null)
                return new ResultDto { Message = "این کد ملی قبلا استفاده شده است", Success = false };
            if (int.TryParse(dto.IdCardNumebr, out int e) == false)
                return new ResultDto { Message = "لطفا کد ملی خود را درست وارد نمایید", Success = false };
            if (dto.RePassword != dto.Password)
                return new ResultDto { Message = "پسورد با تکرار آن مطابقت ندارد", Success = false };

            return new ResultDto { Message = "", Success = true };
        }
    }
}
