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
        public virtual Staff Staff { get; set; }
        public int StaffId { get; set; }
        public virtual Patient Patient { get; set; }
        public int PatientId { get; set; }
    }
}
