using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment1.Models
{
    public class Doctor
    {
        [Key]
        [Required]
        public int DoctorId { get; set; }

        public string Fname { get; set; }

        public string Lname { get; set; }

        public string Contactno { get; set; }

        public string Specialization { get; set; }
    }
}
