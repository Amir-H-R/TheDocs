using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Entities
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public virtual Person DoctorInfo { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ICollection<Specialization> Specializations { get; set; }
        public ICollection<DoctorSpecialization> DoctorSpecializations { get; set; }

    }
    public class Specialization
    {
        public int SpecializationId { get; set; }
        public string Name { get; set; }
        public ICollection<DoctorSpecialization> DoctorSpecializations { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
    public class DoctorSpecialization
    {
        public int Id { get; set; }
        public Specialization Specialization { get; set; }
        public int SpecializationId { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
    }
}
