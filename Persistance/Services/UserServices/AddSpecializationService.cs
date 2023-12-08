using Persistance.Common;
using Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Services.UserServices
{
    public class AddSpecializationService
    {
        private readonly IModel1 _model1;
        public AddSpecializationService(IModel1 model1)
        {
            _model1 = model1;
        }
        public ResultDto Execute(int doctorId, Specialization specialization)
        {
            var doc = _model1.Doctors.Where(p => p.DoctorInfo.PersonId == doctorId).FirstOrDefault();

            doc.DoctorSpecializations.Add(new DoctorSpecialization { DoctorId = doc.DoctorId, Doctor = doc, SpecializationId = specialization.SpecializationId, Specialization = specialization });
            _model1.SaveChanges();
            return new ResultDto() { Message = "تخصص با موفقیت اضافه شد", Success = true };
        }
    }
}
