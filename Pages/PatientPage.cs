using ClinicManagement.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ClinicManagement.Controllers;

namespace ClinicManagement.Pages
{
    public partial class PatientPage : UserControl
    {
        private PatientController _patientController = new PatientController();

        public PatientPage()
        {
            InitializeComponent();
            Load();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = guna2TextBox1.Text.Trim();
            var patients = _patientController.SearchPatients(keyword);
            dataGridView1.DataSource = patients;
            ConfigureGridColumns();
        }

        private void Load()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 136, 236);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            pnlAdd.Visible = false;
            LoadPatientsToGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(guna2TextBox2.Text) ||
                string.IsNullOrWhiteSpace(guna2TextBox3.Text) ||
                comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new AppDbContext())
            {
                var patient = new Patient
                {
                    Id = Guid.NewGuid().ToString(), // Generate unique ID
                    Name = guna2TextBox2.Text.Trim(),
                    Phone = guna2TextBox3.Text.Trim(),
                    Email = guna2TextBox4.Text.Trim(),
                    Address = guna2TextBox5.Text.Trim(),
                    DOB = dateTimePicker1.Value,
                    Gender = comboBox2.SelectedItem.ToString(),
                    Allergies = guna2TextBox6.Text.Trim(),
                    Createdat = DateTime.Now
                };

                context.Patients.Add(patient);
                context.SaveChanges();
            }

            MessageBox.Show("Thêm bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form fields
            guna2TextBox2.Clear();
            guna2TextBox3.Clear();
            guna2TextBox4.Clear();
            guna2TextBox5.Clear();
            guna2TextBox6.Clear();
            dateTimePicker1.Value = DateTime.Now.Date;
            comboBox2.SelectedIndex = -1;

            pnlAdd.Visible = false;
            LoadPatientsToGrid();
        }

        private void LoadPatientsToGrid()
        {
            var patients = _patientController.SearchPatients("");
            dataGridView1.DataSource = patients;
            ConfigureGridColumns();
        }

        private void ConfigureGridColumns()
        {
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Createdat"].Visible = false;

                // Set column headers
                dataGridView1.Columns["Name"].HeaderText = "Name";
                dataGridView1.Columns["Phone"].HeaderText = "Phone";
                dataGridView1.Columns["Email"].HeaderText = "Email";
                dataGridView1.Columns["Address"].HeaderText = "Address";
                dataGridView1.Columns["DOB"].HeaderText = "DOB";
                dataGridView1.Columns["Gender"].HeaderText = "Gender";
                dataGridView1.Columns["Allergies"].HeaderText = "Allergies";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
        }
    }
}
