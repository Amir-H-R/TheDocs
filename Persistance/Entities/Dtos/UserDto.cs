﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Entities.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name;
        public string LastName;
        public string PhoneNumber;
        public string IdCardNumber;
        public int Age;
        public string Username;
        public string Password;
        public string RePassword;
        public ICollection<Role> Roles;
    }
}
