using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public string TreatmentID { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
    }
}
