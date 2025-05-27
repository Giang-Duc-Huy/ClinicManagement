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
    public partial class PatientPage : UserControl
    {
        public PatientPage()
        {
            InitializeComponent();
            Load();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Load()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 136, 236);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            pnlAdd.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
        }
    }
}
