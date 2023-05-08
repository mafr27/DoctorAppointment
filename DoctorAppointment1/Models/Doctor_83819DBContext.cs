using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment1.Models
{
    public class Doctor_83819DBContext:DbContext
    {
        public Doctor_83819DBContext(DbContextOptions<Doctor_83819DBContext> options) : base(options) 
        {

        }
       public  DbSet<Doctor> Doctors { get; set; }
       public  DbSet<UserRegister> UserRegisters { get; set; }

    }
}
