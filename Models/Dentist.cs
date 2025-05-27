using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{

    public class Dentist
    {
        public string Id { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string Email { get; set; } = "";
        public DateTime DOB { get; set; } = DateTime.Now;
        public string Gender { get; set; } = "";

        public DateTime Createdat { get; set; } = DateTime.Now;
    
       

    } }
