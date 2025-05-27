// This project is for learning purposes only.
// UI built using Guna.UI2 under trial license.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dentistPage1.Visible = false;
            patientPage1.Visible = false;
            appointmentPage1.Visible = false;
            dashboardPage1.Visible = true;
            sessionPage1.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            appointmentPage1.Visible = true;
            dentistPage1.Visible = false;
            patientPage1.Visible = false;
            sessionPage1.Visible = false;   
            dashboardPage1.Visible = false;
        }

        private void btnSessions_Click(object sender, EventArgs e)
        {
            sessionPage1.Visible = true;
            appointmentPage1.Visible = false;
            dashboardPage1.Visible = false;
            patientPage1.Visible = false;
            dentistPage1.Visible=false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            patientPage1.Visible = true;
            dentistPage1.Visible = false;
            appointmentPage1.Visible = false;
            dashboardPage1.Visible = false;
            sessionPage1.Visible=false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            patientPage1.Visible = false;
            dentistPage1.Visible = false;
            appointmentPage1.Visible = false;
            dashboardPage1.Visible = false;   
            sessionPage1.Visible = false;
        }

        private void btnDentist_Click(object sender, EventArgs e)
        {
            dentistPage1.Visible = true;
            patientPage1.Visible = false;
            appointmentPage1.Visible = false;
            dashboardPage1.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thông báo", "Chắc chứ", MessageBoxButtons.OKCancel );
            
            if (result == DialogResult.OK) 
            {
                Application.Exit();
            }
        }
    }
}
