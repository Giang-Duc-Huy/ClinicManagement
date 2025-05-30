using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagement.Pages;

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
            SetupDataGridView();
            LoadTreatments();
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Note", "Ghi chú");
            dataGridView1.Columns.Add("Price", "Giá");
            dataGridView1.Columns.Add("Description", "Mô tả");
            dataGridView1.Columns["Note"].Width = 200;
            dataGridView1.Columns["Price"].Width = 100;
            dataGridView1.Columns["Description"].Width = 200;
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
                    dataGridView1.Rows.Add(t.CosulationNote, t.TreatmentCost, t.Precriptions);
                    total += t.TreatmentCost;
                }
                lblTotal.Text = total.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one treatment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var context = new ClinicManagement.Models.AppDbContext())
            {
                // Clear existing treatments for this appointment
                var existingTreatments = context.Treatments.Where(t => t.AppointmentID == _appointmentId);
                context.Treatments.RemoveRange(existingTreatments);

                // Add new treatments from DataGridView
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        var treatment = new ClinicManagement.Models.Treatment
                        {
                            AppointmentID = _appointmentId,
                            CosulationNote = row.Cells[0].Value.ToString(),
                            TreatmentCost = Convert.ToDouble(row.Cells[1].Value),
                            Precriptions = row.Cells[2].Value?.ToString() ?? "",
                            CreatedAt = DateTime.Now
                        };
                        context.Treatments.Add(treatment);
                    }
                }

                // Add history record
                var appt = context.Appointments.FirstOrDefault(a => a.Id == _appointmentId);
                var patient = context.Patients.FirstOrDefault(p => p.Id == appt.PatientID);
                var dentist = context.Dentists.FirstOrDefault(d => d.Id == appt.DentistID);
                var history = new ClinicManagement.Models.History
                {
                    AppointID = _appointmentId.ToString(),
                    PatientName = patient?.Name ?? "",
                    DentistName = dentist?.Name ?? "",
                    Amount = Convert.ToDouble(lblTotal.Text),
                    Description = string.Join(", ", dataGridView1.Rows.Cast<DataGridViewRow>()
                        .Select(r => $"{r.Cells[0].Value}: {r.Cells[1].Value}đ")
                        .ToArray()),
                    CreateAt = DateTime.Now
                };
                context.History.Add(history);

                context.SaveChanges();
                ((MainForm)Application.OpenForms["MainForm"])?.SessionPageInstance?.ReloadHistory();
                MessageBox.Show("Treatments saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double amount = 0;
            if (double.TryParse(guna2TextBox2.Text.Trim(), out amount))
            {
                dataGridView1.Rows.Add(guna2TextBox1.Text.Trim(), amount, guna2TextBox2.Text.Trim());
                guna2TextBox1.Clear();
                guna2TextBox2.Clear();
                CalculateTotal();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                CalculateTotal();
            }
            else
            {
                MessageBox.Show("Please select a row to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CalculateTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    total += Convert.ToDouble(row.Cells[1].Value);
                }
            }
            lblTotal.Text = total.ToString();
        }
    }
}
