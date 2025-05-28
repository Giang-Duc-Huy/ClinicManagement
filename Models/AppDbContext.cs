using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagement.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=clinic.db");
            }
        }
        public DbSet<Dentist> Dentists { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Clinic> Clinic { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<User> Users { get; set; }
        public static void SeedDefaultUser()
        {
            using (var context = new AppDbContext())
            {
                if (!context.Users.Any(u => u.Username == "admin"))
                {
                    context.Users.Add(new User { Username = "admin", Password = "123456" });
                    context.SaveChanges();
                }
            }
        }

    }
}
