using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement.Forms
{
    public partial class TreatmentForm : Form
    {
        private int _appointmentId;
        private string _patientId;
        private string _dentistId;
        public TreatmentForm(int appointmentId, string patientId, string dentistId, string patientName, string dentistName)
        {
            InitializeComponent();
            _appointmentId = appointmentId;
            _patientId = patientId;
            _dentistId = dentistId;
            linkLabel1.Text = appointmentId.ToString();
            linkLabel2.Text = patientName;
            linkLabel3.Text = dentistName;
            LoadTreatments();
        }
        private void LoadTreatments()
        {
            using (var context = new ClinicManagement.Models.AppDbContext())
            {
                var treatments = context.Treatments.Where(t => t.AppointmentID == _appointmentId).ToList();
                dataGridView1.Rows.Clear();
                double total = 0;
                foreach (var t in treatments)
                {
                    dataGridView1.Rows.Add(t.CosulationNote, t.TreatmentCost);
                    total += t.TreatmentCost;
                }
                lblTotal.Text = total.ToString();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new ClinicManagement.Models.AppDbContext())
            {
                double amount = 0;
                double.TryParse(guna2TextBox2.Text.Trim(), out amount);
                var treatment = new ClinicManagement.Models.Treatment
                {
                    AppointmentID = _appointmentId,
                    CosulationNote = guna2TextBox1.Text.Trim(),
                    Precriptions = guna2TextBox2.Text.Trim(),
                    TreatmentCost = amount,
                    CreatedAt = DateTime.Now
                };
                context.Treatments.Add(treatment);
                context.SaveChanges();
                // Thêm lịch sử khám
                var appt = context.Appointments.FirstOrDefault(a => a.Id == _appointmentId);
                var patient = context.Patients.FirstOrDefault(p => p.Id == appt.PatientID);
                var dentist = context.Dentists.FirstOrDefault(d => d.Id == appt.DentistID);
                var history = new ClinicManagement.Models.History
                {
                    AppointID = _appointmentId.ToString(),
                    PatientName = patient?.Name ?? "",
                    DentistName = dentist?.Name ?? "",
                    Amount = amount,
                    CreateAt = DateTime.Now
                };
                context.History.Add(history);
                context.SaveChanges();
            }
            LoadTreatments();
        }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            using (var context = new ClinicManagement.Models.AppDbContext())
            {
                double amount = 0;
                double.TryParse(guna2TextBox2.Text.Trim(), out amount);
                var treatment = new ClinicManagement.Models.Treatment
                {
                    AppointmentID = _appointmentId,
                    CosulationNote = guna2TextBox1.Text.Trim(),
                    Precriptions = guna2TextBox2.Text.Trim(),
                    TreatmentCost = amount,
                    CreatedAt = DateTime.Now
                };
                context.Treatments.Add(treatment);
                context.SaveChanges();
            }
            LoadTreatments();
        }
    }
}
