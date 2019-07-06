using SmartStore.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore.Models
{
    public class User : BaseEntity
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }

        [NotMapped]
        public string Token { get; set; }

        
    }
}
