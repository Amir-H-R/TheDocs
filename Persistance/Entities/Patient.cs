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
        public virtual Person PatientInfo { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual Address PersonAddress { get; set; }
        public int AddressId {  get; set; }
    }
}
