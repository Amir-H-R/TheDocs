using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Entities
{
    public class UserCredential
    {
        public int Id { get; set; }
        [Required]
        public virtual Person Person { get; set; }
        public string PersonId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string IdCardNumber { get; set; }
    }
}
