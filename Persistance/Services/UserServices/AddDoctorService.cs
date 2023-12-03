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
    public class AddDoctorService
    {
        private readonly IModel1 _model1;
        public AddDoctorService(IModel1 model1)
        {
            _model1 = model1;
        }
        public ResultDto Execute(UserDto person, Doctor doctor)
        {
            AddUserService addUser = new AddUserService(_model1);
            var userResult = addUser.Execute(person);
            if (userResult.Success)
            {
                Doctor doc = new Doctor()
                {
                    DoctorInfo = userResult.Data,
                    EndTime = doctor.EndTime,
                    StartTime = doctor.StartTime,
                };
                ICollection<DoctorSpecialization> specializations = new List<DoctorSpecialization>();
                foreach (var item in doctor.Specializations)
                {
                    var specializaion = _model1.Specializations.Where(p => p.SpecializationId == item.SpecializationId).FirstOrDefault();
                    specializations.Add(new DoctorSpecialization
                    {
                        Doctor = doc,
                        DoctorId = doc.DoctorId,
                        Specialization = specializaion,
                        SpecializationId = specializaion.SpecializationId,
                    });
                }
                doc.DoctorSpecializations = specializations;
                _model1.Doctors.Add(doc);
                _model1.SaveChanges();
                return new ResultDto { Message = "دکتر با موفقیت اضافه شد", Success = true };
            }
            else
                return new ResultDto { Success = false, Message = userResult.Message };
        }
    }
}
