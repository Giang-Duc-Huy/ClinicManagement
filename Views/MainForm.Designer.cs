namespace ClinicManagement
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            btnDentist = new Guna.UI2.WinForms.Guna2Button();
            btnPatient = new Guna.UI2.WinForms.Guna2Button();
            btnAppointment = new Guna.UI2.WinForms.Guna2Button();
            btnSessions = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            emailPage1 = new Pages.EmailPage();
            dashboardPage1 = new Pages.DashboardPage();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 136, 236);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1413, 115);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.OrangeRed;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ControlLightLight;
            btnClose.Location = new Point(1352, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 47);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-57, -86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 313);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Black;
            btnDashboard.BackgroundImage = (Image)resources.GetObject("btnDashboard.BackgroundImage");
            btnDashboard.BackgroundImageLayout = ImageLayout.Stretch;
            btnDashboard.BorderRadius = 10;
            btnDashboard.BorderThickness = 2;
            btnDashboard.CustomizableEdges = customizableEdges1;
            btnDashboard.DisabledState.BorderColor = Color.DarkGray;
            btnDashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDashboard.FillColor = Color.FromArgb(31, 31, 31);
            btnDashboard.Font = new Font("Segoe UI", 9F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.HoverState.BorderColor = Color.White;
            btnDashboard.HoverState.FillColor = Color.Gray;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageOffset = new Point(-5, 0);
            btnDashboard.Location = new Point(12, 133);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDashboard.Size = new Size(218, 68);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "DashBoard";
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnDentist
            // 
            btnDentist.BackColor = Color.Black;
            btnDentist.BorderRadius = 10;
            btnDentist.BorderThickness = 2;
            btnDentist.CustomizableEdges = customizableEdges3;
            btnDentist.DisabledState.BorderColor = Color.DarkGray;
            btnDentist.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDentist.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDentist.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDentist.FillColor = Color.FromArgb(31, 31, 31);
            btnDentist.Font = new Font("Segoe UI", 9F);
            btnDentist.ForeColor = Color.White;
            btnDentist.HoverState.BorderColor = Color.White;
            btnDentist.HoverState.CustomBorderColor = Color.Transparent;
            btnDentist.HoverState.FillColor = Color.Gray;
            btnDentist.Image = (Image)resources.GetObject("btnDentist.Image");
            btnDentist.ImageOffset = new Point(-5, 0);
            btnDentist.Location = new Point(245, 133);
            btnDentist.Name = "btnDentist";
            btnDentist.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDentist.Size = new Size(218, 68);
            btnDentist.TabIndex = 1;
            btnDentist.Text = "Dentist";
            btnDentist.Click += btnDentist_Click;
            // 
            // btnPatient
            // 
            btnPatient.BackColor = Color.Black;
            btnPatient.BorderRadius = 10;
            btnPatient.BorderThickness = 2;
            btnPatient.CustomizableEdges = customizableEdges5;
            btnPatient.DisabledState.BorderColor = Color.DarkGray;
            btnPatient.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPatient.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPatient.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPatient.FillColor = Color.FromArgb(31, 31, 31);
            btnPatient.Font = new Font("Segoe UI", 9F);
            btnPatient.ForeColor = Color.White;
            btnPatient.HoverState.BorderColor = Color.White;
            btnPatient.HoverState.CustomBorderColor = Color.Transparent;
            btnPatient.HoverState.FillColor = Color.Gray;
            btnPatient.Image = (Image)resources.GetObject("btnPatient.Image");
            btnPatient.ImageOffset = new Point(-5, 0);
            btnPatient.Location = new Point(478, 133);
            btnPatient.Name = "btnPatient";
            btnPatient.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnPatient.Size = new Size(218, 68);
            btnPatient.TabIndex = 2;
            btnPatient.Text = "Patient";
            btnPatient.Click += btnPatient_Click;
            // 
            // btnAppointment
            // 
            btnAppointment.BackColor = Color.Black;
            btnAppointment.BorderRadius = 10;
            btnAppointment.BorderThickness = 2;
            btnAppointment.CustomizableEdges = customizableEdges7;
            btnAppointment.DisabledState.BorderColor = Color.DarkGray;
            btnAppointment.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAppointment.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAppointment.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAppointment.FillColor = Color.FromArgb(31, 31, 31);
            btnAppointment.Font = new Font("Segoe UI", 9F);
            btnAppointment.ForeColor = Color.White;
            btnAppointment.HoverState.BorderColor = Color.White;
            btnAppointment.HoverState.CustomBorderColor = Color.Transparent;
            btnAppointment.HoverState.FillColor = Color.Gray;
            btnAppointment.Image = (Image)resources.GetObject("btnAppointment.Image");
            btnAppointment.ImageOffset = new Point(-5, 0);
            btnAppointment.Location = new Point(712, 133);
            btnAppointment.Name = "btnAppointment";
            btnAppointment.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAppointment.Size = new Size(218, 68);
            btnAppointment.TabIndex = 3;
            btnAppointment.Text = "Appointment";
            btnAppointment.Click += btnAppointment_Click;
            // 
            // btnSessions
            // 
            btnSessions.BackColor = Color.Black;
            btnSessions.BorderRadius = 10;
            btnSessions.BorderThickness = 2;
            btnSessions.CustomizableEdges = customizableEdges9;
            btnSessions.DisabledState.BorderColor = Color.DarkGray;
            btnSessions.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSessions.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSessions.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSessions.FillColor = Color.FromArgb(31, 31, 31);
            btnSessions.Font = new Font("Segoe UI", 9F);
            btnSessions.ForeColor = Color.GhostWhite;
            btnSessions.HoverState.BorderColor = Color.White;
            btnSessions.HoverState.CustomBorderColor = Color.Transparent;
            btnSessions.HoverState.FillColor = Color.Gray;
            btnSessions.Image = (Image)resources.GetObject("btnSessions.Image");
            btnSessions.ImageOffset = new Point(-5, 0);
            btnSessions.Location = new Point(946, 133);
            btnSessions.Name = "btnSessions";
            btnSessions.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnSessions.Size = new Size(218, 68);
            btnSessions.TabIndex = 4;
            btnSessions.Text = "History";
            btnSessions.Click += btnSessions_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Black;
            guna2Button1.BorderRadius = 10;
            guna2Button1.BorderThickness = 2;
            guna2Button1.CustomizableEdges = customizableEdges11;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(31, 31, 31);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.GhostWhite;
            guna2Button1.HoverState.BorderColor = Color.White;
            guna2Button1.HoverState.CustomBorderColor = Color.Transparent;
            guna2Button1.HoverState.FillColor = Color.Gray;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.ImageOffset = new Point(-5, 0);
            guna2Button1.Location = new Point(1179, 133);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Button1.Size = new Size(218, 68);
            guna2Button1.TabIndex = 6;
            guna2Button1.Text = "Gmail";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(emailPage1);
            panel2.Controls.Add(dashboardPage1);
            panel2.Location = new Point(12, 216);
            panel2.Name = "panel2";
            panel2.Size = new Size(1385, 574);
            panel2.TabIndex = 7;
            // 
            // emailPage1
            // 
            emailPage1.BackColor = SystemColors.ControlLightLight;
            emailPage1.Dock = DockStyle.Fill;
            emailPage1.Location = new Point(0, 0);
            emailPage1.Name = "emailPage1";
            emailPage1.Size = new Size(1385, 574);
            emailPage1.TabIndex = 2;
            // 
            // dashboardPage1
            // 
            dashboardPage1.BackColor = SystemColors.ControlLightLight;
            dashboardPage1.Dock = DockStyle.Fill;
            dashboardPage1.Location = new Point(0, 0);
            dashboardPage1.Name = "dashboardPage1";
            dashboardPage1.Size = new Size(1385, 574);
            dashboardPage1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1413, 802);
            Controls.Add(panel2);
            Controls.Add(guna2Button1);
            Controls.Add(btnSessions);
            Controls.Add(btnAppointment);
            Controls.Add(btnPatient);
            Controls.Add(btnDentist);
            Controls.Add(btnDashboard);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnDentist;
        private Guna.UI2.WinForms.Guna2Button btnPatient;
        private Guna.UI2.WinForms.Guna2Button btnAppointment;
        private Guna.UI2.WinForms.Guna2Button btnSessions;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Pages.PatientPage patientPage1;
        private Pages.DentistPage dentistPage1;
        private Button btnClose;
        private Pages.AppointmentPage appointmentPage1;
        private Pages.DashboardPage dashboardPage1;
        private Pages.SessionPage sessionPage1;
        private Pages.EmailPage emailPage1;
    }
}