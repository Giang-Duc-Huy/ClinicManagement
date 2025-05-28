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

namespace ClinicManagement.Pages
{
    public partial class DentistPage : UserControl
    {
        private readonly DentistController _dentistController;

        public DentistPage()
        {
            InitializeComponent();
            _dentistController = new DentistController();
            Load();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

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

                // Clear form fields
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
    }
}
