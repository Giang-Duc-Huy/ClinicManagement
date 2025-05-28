using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ClinicManagement.Models
{
    public class Patient
    {
        [Key]
        public string Id { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string Email { get; set; } = "";
        public DateTime DOB { get; set; } 
        public string Gender { get; set; } = "";
        public string Allergies { get; set; } = "";
        public DateTime Createdat { get; set; } = DateTime.Now;
        
    }
}
