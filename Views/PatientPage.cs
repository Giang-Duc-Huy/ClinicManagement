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
        private Patient _selectedPatient = null;

        public PatientPage()
        {
            InitializeComponent();
            Load();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            var patients = _patientController.SearchPatients(keyword);
            dataGridView1.DataSource = patients;
            ConfigureGridColumns();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                if (row.DataBoundItem is Patient patient)
                {
                    _selectedPatient = patient;
                    guna2TextBox2.Text = patient.Name;
                    guna2TextBox3.Text = patient.Phone;
                    guna2TextBox4.Text = patient.Email;
                    guna2TextBox5.Text = patient.Address;
                    dateTimePicker1.Value = patient.DOB;
                    comboBox2.SelectedItem = patient.Gender;
                    guna2TextBox6.Text = patient.Allergies;
                    pnlAdd.Visible = true;
                }
            }
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

            if (_selectedPatient == null)
            {
                var patient = new Patient
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = guna2TextBox2.Text.Trim(),
                    Phone = guna2TextBox3.Text.Trim(),
                    Email = guna2TextBox4.Text.Trim(),
                    Address = guna2TextBox5.Text.Trim(),
                    DOB = dateTimePicker1.Value,
                    Gender = comboBox2.SelectedItem.ToString(),
                    Allergies = guna2TextBox6.Text.Trim(),
                    Createdat = DateTime.Now
                };
                if (_patientController.AddPatient(patient))
                {
                    MessageBox.Show("Thêm bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm bệnh nhân!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _selectedPatient.Name = guna2TextBox2.Text.Trim();
                _selectedPatient.Phone = guna2TextBox3.Text.Trim();
                _selectedPatient.Email = guna2TextBox4.Text.Trim();
                _selectedPatient.Address = guna2TextBox5.Text.Trim();
                _selectedPatient.DOB = dateTimePicker1.Value;
                _selectedPatient.Gender = comboBox2.SelectedItem.ToString();
                _selectedPatient.Allergies = guna2TextBox6.Text.Trim();
                if (_patientController.UpdatePatient(_selectedPatient))
                {
                    MessageBox.Show("Cập nhật bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi cập nhật bệnh nhân!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                var patient = row.DataBoundItem as Patient;
                if (patient != null)
                {
                    var confirm = MessageBox.Show($"Bạn có chắc muốn xóa bệnh nhân {patient.Name}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        if (_patientController.DeletePatient(patient.Id))
                        {
                            MessageBox.Show("Xóa bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPatientsToGrid();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra khi xóa bệnh nhân!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedPatient == null)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _selectedPatient.Name = guna2TextBox2.Text.Trim();
            _selectedPatient.Phone = guna2TextBox3.Text.Trim();
            _selectedPatient.Email = guna2TextBox4.Text.Trim();
            _selectedPatient.Address = guna2TextBox5.Text.Trim();
            _selectedPatient.DOB = dateTimePicker1.Value;
            _selectedPatient.Gender = comboBox2.SelectedItem.ToString();
            _selectedPatient.Allergies = guna2TextBox6.Text.Trim();
            if (_patientController.UpdatePatient(_selectedPatient))
            {
                MessageBox.Show("Cập nhật bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guna2TextBox2.Clear();
                guna2TextBox3.Clear();
                guna2TextBox4.Clear();
                guna2TextBox5.Clear();
                guna2TextBox6.Clear();
                dateTimePicker1.Value = DateTime.Now.Date;
                comboBox2.SelectedIndex = -1;
                pnlAdd.Visible = false;
                LoadPatientsToGrid();
                _selectedPatient = null;
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật bệnh nhân!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
