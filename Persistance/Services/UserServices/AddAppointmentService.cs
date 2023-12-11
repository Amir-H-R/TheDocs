using Persistance.Common;
using Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Services.UserServices
{
    public class AddAppointmentService
    {
        private readonly IModel1 _model1;
        public AddAppointmentService(IModel1 model1)
        {
            _model1 = model1;
        }
        public ResultDto Execute(Appointment appointment)
        {
            var doc = _model1.Doctors.Where(p => p.DoctorId == appointment.DoctorId).FirstOrDefault();
            var user = _model1.People.Where(p => p.PersonId == p.PersonId).FirstOrDefault();
            if (appointment.AppointmentDate.Value.Date > doc.StartTime.Date && appointment.AppointmentDate.Value.Date < doc.EndTime.Date)
            {
                var existingAppointment = _model1.Appointments.Where(p => p.AppointmentDate == appointment.AppointmentDate).FirstOrDefault();
                if (existingAppointment == null)
                {
                    Appointment newAppointment = new Appointment
                    {
                        AppointmentDate = appointment.AppointmentDate,
                        Status = appointment.Status,
                        Doctor = doc,
                        DoctorId = appointment.DoctorId,
                        Patient = appointment.Patient,
                        PatientId = appointment.PatientId
                    };
                    _model1.Appointments.Add(newAppointment);
                    _model1.SaveChanges();
                    return new ResultDto { Message = "نوبت با موفقیت ثبت شد", Success = true };
                }
                return new ResultDto { Message = "این تاریخ قبلا اشغال شده است", Success = false };

            }
            else
                return new ResultDto { Message = "زمان انتخاب شده خارج از بازه زمانی دکتر است", Success = false };

        }
    }
}
