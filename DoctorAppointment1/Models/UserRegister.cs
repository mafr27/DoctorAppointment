using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment1.Models
{
    
   public class UserRegister
    {
        [Key]
        [Required]
        public int UserId { get; set; }
        public string FirstName { get; set; }

        public string Lastname { get; set; }

        public DateTime? Dob { get; set; }

        public string Mobileno { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Gender { get; set; }
    }
}
