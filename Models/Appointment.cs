using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public string PatientID { get; set; }
        public string DentistID { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Time {  get; set; }
        public bool Canceled { get; set; }
        public bool Pending { get; set; }
        public bool Completed { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
