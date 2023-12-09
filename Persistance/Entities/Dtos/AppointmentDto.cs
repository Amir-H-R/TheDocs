using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Entities.Dtos
{
    public class AppointmentDto
    {
        public int AppointmentId { get; set; }
        public string DoctorName {  get; set; }
        public int DoctorId { get; set; }
        public string PatientName {  get; set; }
        public int PatientId { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public Status Status { get; set; }
    }
}
