using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Entities.Dtos
{
    public class UserDto
    {
        public string Name;
        public string LastName;
        public string PhoneNumber;
        public string IdCardNumebr;
        public int Age;
        public string Username;
        public string Password;
        public ICollection<Role> Roles;
    }
}
