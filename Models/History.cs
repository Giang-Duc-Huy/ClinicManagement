using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ClinicManagement.Models
{
    public class History
    {
        [Key]
        public int Id { get; set; }
        public string AppointID { get; set; }
        public string PatientName { get; set; }
        public string DentistName { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
    }
}
