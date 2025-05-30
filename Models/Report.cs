using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class Report
    {
        public int Id { get; set; }
        public int DentistCount { get; set; }
        public int PatientCount { get; set; }
        public int AppointmentCount { get; set; }
        public int CompletedCount { get; set; }
        public int CanceledCount { get; set; }
        public int PendingCount { get; set; }
        public double Revenue { get; set; }
        public DateTime ReportDate { get; set; } = DateTime.Now;
    }
}
