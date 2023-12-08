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
    public class EditDoctorService
    {
        private readonly IModel1 _model1;
        public EditDoctorService(IModel1 model1)
        {
            _model1 = model1;
        }
        public ResultDto Execute(UserDto userDto, Doctor doctorDto)
        {
            EditUserService editUser = new EditUserService(_model1);
            var editResult = editUser.Execute(userDto);
            if (editResult.Success)
            {
                var doc = _model1.Doctors.Where(p => p.DoctorInfo.PersonId == editResult.Data).FirstOrDefault();
                doc.StartTime = doctorDto.StartTime;
                doc.EndTime = doctorDto.EndTime;
                _model1.SaveChanges();
                return new ResultDto { Message = "اطلاعات دکتر تغییر کرد", Success = true };
            }
            else
                return new ResultDto { Message = editResult.Message, Success = false };
        }
    }
}
