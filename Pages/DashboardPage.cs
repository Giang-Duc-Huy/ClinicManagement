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
    public partial class DashboardPage : UserControl
    {
        public DashboardPage()
        {
            InitializeComponent();
        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("Completed", 50, "25%");
            dataGridView2.Rows.Add("Canceled", 10, "5%");
            dataGridView2.Rows.Add("Pending", 140, "70%");
            dataGridView1.Rows.Add("15,000,000", 5, 2025);
            dataGridView1.Rows.Add("12,000,000", 4, 2025);
            dataGridView1.Rows.Add("10,500,000", 3, 2025);


        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void lblAppointments_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
