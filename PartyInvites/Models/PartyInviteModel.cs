using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class PartyInviteModel
    {
        [Required(ErrorMessage ="Please enter your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter your email")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Please enter a valid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter a Phone number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="Please specify if you will attend")]
        public bool? willAttend { get; set; }
    }
}
