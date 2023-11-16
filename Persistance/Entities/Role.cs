using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<PeopleRoles> PeopleRoles { get; set; }
    }
}
