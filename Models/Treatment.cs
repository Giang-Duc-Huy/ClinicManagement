using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ClinicManagement.Models
{
    public class Treatment
    {
        [Key]
        public int ID { get; set; }
        public int AppointmentID { get; set; }
        public string CosulationNote { get; set; }
        public string Precriptions {  get; set; }
        public double TreatmentCost { get; set; }
        public double CosulationCost { get; set; }
        public double PrecriptionsCost { get; private set; }
        public DateTime CreatedAt { get; set; }
    }
}
