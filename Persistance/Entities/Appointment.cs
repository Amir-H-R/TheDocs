using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Entities
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
        public virtual Patient Patient { get; set; }
        public int PatientId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public Status Status { get; set; }
    }
    public enum Status
    {
        Active = 0,
        Hiatus = 1,
        Cancelled = 2,
        Complete = 3
    }
}
