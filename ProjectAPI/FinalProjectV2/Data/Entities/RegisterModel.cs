using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Data.Entities
{
    public class RegisterModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30,MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Surname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
