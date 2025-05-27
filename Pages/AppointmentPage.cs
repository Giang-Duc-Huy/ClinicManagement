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

namespace ClinicManagement.Pages
{
    public partial class AppointmentPage : UserControl
    {
        public AppointmentPage()
        {
            InitializeComponent();
            Load();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Load()
        {
            //dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(5, 136, 236);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            pnlAdd.Visible = false;
            List<Dentist> list = new List<Dentist>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Dentist { Name = "Giang", Email = "ddđ", Phone = "2322222" });
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = list;

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

        private void btnComplete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnOts_Click(object sender, EventArgs e)
        {
            TreatmentForm form = new TreatmentForm();
            form.ShowDialog();
        }
    }
}
