﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Entities
{
    public class PeopleRoles
    {
        [Key]
        public int Id { get; set; }
        public virtual Person Person { get; set; }
        public int PersonId { get; set; }
        public virtual Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
