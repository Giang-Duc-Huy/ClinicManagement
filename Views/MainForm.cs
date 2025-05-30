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
using ClinicManagement.Pages;

namespace ClinicManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Load1();
        }
        private void Load1()
        {
            patientPage1 = new ClinicManagement.Pages.PatientPage();
            patientPage1.Dock = DockStyle.Fill;
            patientPage1.BackColor = Color.White;
            panel2.Controls.Add(patientPage1);
            dentistPage1 = new ClinicManagement.Pages.DentistPage();
            dentistPage1.Dock = DockStyle.Fill;
            panel2.Controls.Add(dentistPage1);
            appointmentPage1 = new ClinicManagement.Pages.AppointmentPage();
            appointmentPage1.Dock = DockStyle.Fill;
            panel2.Controls.Add(appointmentPage1);
            sessionPage1 = new ClinicManagement.Pages.SessionPage();
            sessionPage1.Dock = DockStyle.Fill;
            sessionPage1.BackColor = Color.White;
            panel2.Controls.Add(sessionPage1);

        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dentistPage1.Visible = false;
            patientPage1.Visible = false;
            appointmentPage1.Visible = false;
            dashboardPage1.Visible = true;
            sessionPage1.Visible = false;
            emailPage1.Visible = false;
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
            emailPage1.Visible = false;
            dashboardPage1.Visible = false;
        }

        private void btnSessions_Click(object sender, EventArgs e)
        {
            sessionPage1.Visible = true;
            appointmentPage1.Visible = false;
            dashboardPage1.Visible = false;
            patientPage1.Visible = false;
            dentistPage1.Visible = false;
            emailPage1.Visible = false;
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
            sessionPage1.Visible = false;
            emailPage1.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            patientPage1.Visible = false;
            dentistPage1.Visible = false;
            appointmentPage1.Visible = false;
            dashboardPage1.Visible = false;
            sessionPage1.Visible = false;
            emailPage1.Visible = false;
        }

        private void btnDentist_Click(object sender, EventArgs e)
        {
            dentistPage1.Visible = true;
            patientPage1.Visible = false;
            appointmentPage1.Visible = false;
            dashboardPage1.Visible = false;
            sessionPage1.Visible = false;
            emailPage1.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dentistPage1.Visible = false;
            patientPage1.Visible = false;
            appointmentPage1.Visible = false;
            dashboardPage1.Visible = false;
            sessionPage1.Visible = false;
            emailPage1.Visible = true;
        }

        public DashboardPage DashboardPageInstance => dashboardPage1;
        public SessionPage SessionPageInstance => sessionPage1;
    }
}
