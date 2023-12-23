using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Entities
{
    public class Appointment
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppointmentId { get; set; }
        [Required]
        public virtual Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
        [Required]
        public virtual Patient Patient { get; set; }
        public int PatientId { get; set; }
        public DateTime? AppointmentDate { get; set; }
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
