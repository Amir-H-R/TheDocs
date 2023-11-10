using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Entities
{
    public class Patient
    {
        public int PatientId { get; set; }
        public Person PatientInfo { get; set; }
        public DateTime BirthDate { get; set; }
        public Address PatientAddress { get; set; }
    }
}
