using ClinicManagement.Models;
using ClinicManagement.Controllers;
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

namespace ClinicManagement.Pages
{
    public partial class DentistPage : UserControl
    {
        private readonly DentistController _dentistController;
        private Dentist _selectedDentist = null;

        public DentistPage()
        {
            InitializeComponent();
            _dentistController = new DentistController();
            Load();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            var dentists = _dentistController.SearchDentists(keyword);
            dataGridView1.DataSource = dentists;
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Createdat"].Visible = false;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                _selectedDentist = row.DataBoundItem as Dentist;
                if (_selectedDentist != null)
                {
                    guna2TextBox2.Text = _selectedDentist.Name;
                    guna2TextBox3.Text = _selectedDentist.Phone;
                    guna2TextBox4.Text = _selectedDentist.Email;
                    guna2TextBox5.Text = _selectedDentist.Address;
                    dateTimePicker1.Value = _selectedDentist.DOB;
                    comboBox2.SelectedItem = _selectedDentist.Gender;
                    pnlAdd.Visible = true;
                }
            }
        }

        private void Load()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(5, 136, 236);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            pnlAdd.Visible = false;
            LoadDentistsToGrid();
        }

        private void LoadDentistsToGrid()
        {
            var dentists = _dentistController.GetAllDentists();
            dataGridView1.DataSource = dentists;

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
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (_selectedDentist == null)
            {
                // Thêm mới
                var dentist = new Dentist
                {
                    Name = guna2TextBox2.Text.Trim(),
                    Phone = guna2TextBox3.Text.Trim(),
                    Email = guna2TextBox4.Text.Trim(),
                    Address = guna2TextBox5.Text.Trim(),
                    DOB = dateTimePicker1.Value,
                    Gender = comboBox2.SelectedItem?.ToString()
                };
                if (!_dentistController.ValidateDentist(dentist))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_dentistController.AddDentist(dentist))
                {
                    MessageBox.Show("Thêm bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((MainForm)Application.OpenForms["MainForm"])?.DashboardPageInstance?.RefreshDashboard();
                    guna2TextBox2.Clear();
                    guna2TextBox3.Clear();
                    guna2TextBox4.Clear();
                    guna2TextBox5.Clear();
                    dateTimePicker1.Value = DateTime.Now.Date;
                    comboBox2.SelectedIndex = -1;
                    pnlAdd.Visible = false;
                    LoadDentistsToGrid();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm bác sĩ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Sửa
                _selectedDentist.Name = guna2TextBox2.Text.Trim();
                _selectedDentist.Phone = guna2TextBox3.Text.Trim();
                _selectedDentist.Email = guna2TextBox4.Text.Trim();
                _selectedDentist.Address = guna2TextBox5.Text.Trim();
                _selectedDentist.DOB = dateTimePicker1.Value;
                _selectedDentist.Gender = comboBox2.SelectedItem?.ToString();
                if (!_dentistController.ValidateDentist(_selectedDentist))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_dentistController.UpdateDentist(_selectedDentist))
                {
                    MessageBox.Show("Cập nhật bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((MainForm)Application.OpenForms["MainForm"])?.DashboardPageInstance?.RefreshDashboard();
                    guna2TextBox2.Clear();
                    guna2TextBox3.Clear();
                    guna2TextBox4.Clear();
                    guna2TextBox5.Clear();
                    dateTimePicker1.Value = DateTime.Now.Date;
                    comboBox2.SelectedIndex = -1;
                    pnlAdd.Visible = false;
                    LoadDentistsToGrid();
                    _selectedDentist = null;
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi cập nhật bác sĩ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                var dentist = row.DataBoundItem as Dentist;
                if (dentist != null)
                {
                    var confirm = MessageBox.Show($"Bạn có chắc muốn xóa bác sĩ {dentist.Name}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        if (_dentistController.DeleteDentist(dentist.Id))
                        {
                            MessageBox.Show("Xóa bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDentistsToGrid();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra khi xóa bác sĩ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bác sĩ để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedDentist == null)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _selectedDentist.Name = guna2TextBox2.Text.Trim();
            _selectedDentist.Phone = guna2TextBox3.Text.Trim();
            _selectedDentist.Email = guna2TextBox4.Text.Trim();
            _selectedDentist.Address = guna2TextBox5.Text.Trim();
            _selectedDentist.DOB = dateTimePicker1.Value;
            _selectedDentist.Gender = comboBox2.SelectedItem?.ToString();
            if (_dentistController.UpdateDentist(_selectedDentist))
            {
                MessageBox.Show("Cập nhật bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((MainForm)Application.OpenForms["MainForm"])?.DashboardPageInstance?.RefreshDashboard();
                guna2TextBox2.Clear();
                guna2TextBox3.Clear();
                guna2TextBox4.Clear();
                guna2TextBox5.Clear();
                dateTimePicker1.Value = DateTime.Now.Date;
                comboBox2.SelectedIndex = -1;
                pnlAdd.Visible = false;
                LoadDentistsToGrid();
                _selectedDentist = null;
            }
            else
            {
                MessageBox.Show("Không tìm thấy bác sĩ để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
