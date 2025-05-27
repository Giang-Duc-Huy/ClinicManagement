using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientID { get; set; }
        public int DentistID { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Time {  get; set; }
        public bool Canceled { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
