using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Entities
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public virtual Address PersonAddress { get; set; }
        public int AddressId { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<PeopleRoles> PeopleRoles { get; set; }
        public virtual UserCredential Credential { get; set; }
    }
}
