using ClinicManagement.Forms;
using ClinicManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagement.Controllers;
using ClinicManagement.Pages;

namespace ClinicManagement.Pages
{
    public partial class AppointmentPage : UserControl
    {
        private AppointmentController _appointmentController = new AppointmentController();
        private int _selectedAppointmentId;
        private string _selectedPatientId;
        private string _selectedDentistId;
        private string _selectedPatientName;
        private string _selectedDentistName;
        private string _currentStatus = "All";
        public AppointmentPage()
        {
            InitializeComponent();
            Load();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Load()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(5, 136, 236);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            pnlAdd.Visible = false;
            // Nạp combobox bác sĩ, bệnh nhân
            cmbDentist.DataSource = _appointmentController.GetDentists();
            cmbDentist.DisplayMember = "Name";
            cmbDentist.ValueMember = "Id";
            cmbPatient.DataSource = _appointmentController.GetPatients();
            cmbPatient.DisplayMember = "Name";
            cmbPatient.ValueMember = "Id";
            // Nạp danh sách lịch khám
            LoadAppointmentsToGrid("All", null);
        }
        private void LoadAppointmentsToGrid(string status, DateTime? date)
        {
            var appts = _appointmentController.GetAppointments(status, date);
            dataGridView1.DataSource = appts.Select(a => new
            {
                a.Id,
                Patient = _appointmentController.GetPatients().FirstOrDefault(p => p.Id == a.PatientID.ToString())?.Name,
                Dentist = _appointmentController.GetDentists().FirstOrDefault(d => d.Id == a.DentistID.ToString())?.Name,
                Date = a.Date.ToString("yyyy-MM-dd"),
                a.Time,
                CreatedAt = a.DateCreated.ToString("yyyy-MM-dd HH:mm"),
                a.Notes,
                a.Pending,
                a.Completed,
                a.Canceled
            }).ToList();
            if (dataGridView1.Rows.Count > 0)
                dataGridView1.Rows[0].Selected = true;
        }
        private void btnAll_Click_1(object sender, EventArgs e) { _currentStatus = "All"; LoadAppointmentsToGrid(_currentStatus, null); }
        private void btnPending_Click_1(object sender, EventArgs e) { _currentStatus = "Pending"; LoadAppointmentsToGrid(_currentStatus, null); }
        private void btnComplete_Click(object sender, EventArgs e) { _currentStatus = "Completed"; LoadAppointmentsToGrid(_currentStatus, null); }
        private void btnCancel_Click(object sender, EventArgs e) { _currentStatus = "Canceled"; LoadAppointmentsToGrid(_currentStatus, null); }
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadAppointmentsToGrid(_currentStatus, guna2DateTimePicker1.Value.Date);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                _selectedAppointmentId = Convert.ToInt32(row.Cells["Id"].Value);
                var appt = _appointmentController.GetAppointments().FirstOrDefault(a => a.Id == _selectedAppointmentId);
                _selectedPatientId = appt?.PatientID;
                _selectedDentistId = appt?.DentistID;
                _selectedPatientName = row.Cells["Patient"].Value?.ToString();
                _selectedDentistName = row.Cells["Dentist"].Value?.ToString();
            }
        }

        private void btnOts_Click(object sender, EventArgs e)
        {
            if (_selectedAppointmentId == 0) { MessageBox.Show("Chọn một lịch khám!", "Thông báo"); return; }
            TreatmentForm form = new TreatmentForm(_selectedAppointmentId, _selectedPatientId, _selectedDentistId, _selectedPatientName, _selectedDentistName);
            form.ShowDialog();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (cmbDentist.SelectedValue == null || cmbPatient.SelectedValue == null || string.IsNullOrWhiteSpace(guna2TextBox5.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var appt = new Appointment
            {
                DentistID = cmbDentist.SelectedValue.ToString(),
                PatientID = cmbPatient.SelectedValue.ToString(),
                Date = dateTimePicker1.Value.Date,
                Time = guna2TextBox5.Text.Trim(),
                Notes = guna2TextBox6.Text.Trim(),
            };
            bool success = _appointmentController.AddAppointment(appt);
            if (!success)
            {
                MessageBox.Show("Lịch khám này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đặt lịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ((MainForm)Application.OpenForms["MainForm"])?.DashboardPageInstance?.RefreshDashboard();
            pnlAdd.Visible = false;
            LoadAppointmentsToGrid("All", null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = dataGridView1;
            if (e.RowIndex < 0 || e.RowIndex >= grid.Rows.Count) return;
            var row = grid.Rows[e.RowIndex];
            if (row.IsNewRow || row.Cells["Id"].Value == null) return;
            var id = Convert.ToInt32(row.Cells["Id"].Value);
            if (grid.Columns[e.ColumnIndex].Name == "Pending")
                _appointmentController.UpdateStatus(id, "Pending");
            else if (grid.Columns[e.ColumnIndex].Name == "Completed")
                _appointmentController.UpdateStatus(id, "Completed");
            else if (grid.Columns[e.ColumnIndex].Name == "Canceled")
                _appointmentController.UpdateStatus(id, "Canceled");
            ((MainForm)Application.OpenForms["MainForm"])?.DashboardPageInstance?.RefreshDashboard();
            LoadAppointmentsToGrid(_currentStatus, guna2DateTimePicker1.Value.Date);
            if (dataGridView1.Rows.Count == 0 && _currentStatus != "All")
            {
                _currentStatus = "All";
                LoadAppointmentsToGrid(_currentStatus, guna2DateTimePicker1.Value.Date);
            }
        }
    }
}
