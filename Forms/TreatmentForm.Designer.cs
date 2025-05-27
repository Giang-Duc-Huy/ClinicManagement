namespace ClinicManagement.Forms
{
    partial class TreatmentForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreatmentForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnClose = new Button();
            label1 = new Label();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            lblAppointment = new Label();
            panel3 = new Panel();
            linkLabel2 = new LinkLabel();
            lblPaient = new Label();
            panel4 = new Panel();
            linkLabel3 = new LinkLabel();
            lblDentist = new Label();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            label6 = new Label();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            label7 = new Label();
            lblTotal = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            picDelete = new PictureBox();
            picPlus = new PictureBox();
            picRefresh = new PictureBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRefresh).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 47);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.OrangeRed;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ControlLightLight;
            btnClose.Location = new Point(885, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 36);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "Treatment";
            // 
            // panel2
            // 
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(lblAppointment);
            panel2.Location = new Point(20, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 44);
            panel2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            linkLabel1.Location = new Point(175, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.RightToLeft = RightToLeft.No;
            linkLabel1.Size = new Size(95, 25);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Loading...";
            // 
            // lblAppointment
            // 
            lblAppointment.AutoSize = true;
            lblAppointment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAppointment.ForeColor = SystemColors.ControlDark;
            lblAppointment.Location = new Point(4, 9);
            lblAppointment.Name = "lblAppointment";
            lblAppointment.Size = new Size(149, 25);
            lblAppointment.TabIndex = 0;
            lblAppointment.Text = "Appointment ID";
            // 
            // panel3
            // 
            panel3.Controls.Add(linkLabel2);
            panel3.Controls.Add(lblPaient);
            panel3.Location = new Point(20, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(276, 44);
            panel3.TabIndex = 2;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            linkLabel2.Location = new Point(175, 9);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(95, 25);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Loading...";
            // 
            // lblPaient
            // 
            lblPaient.AutoSize = true;
            lblPaient.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPaient.ForeColor = SystemColors.ControlDark;
            lblPaient.Location = new Point(4, 9);
            lblPaient.Name = "lblPaient";
            lblPaient.Size = new Size(73, 25);
            lblPaient.TabIndex = 0;
            lblPaient.Text = "Patient";
            // 
            // panel4
            // 
            panel4.Controls.Add(linkLabel3);
            panel4.Controls.Add(lblDentist);
            panel4.Location = new Point(20, 153);
            panel4.Name = "panel4";
            panel4.Size = new Size(276, 44);
            panel4.TabIndex = 2;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            linkLabel3.Location = new Point(175, 9);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(95, 25);
            linkLabel3.TabIndex = 1;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Loading...";
            // 
            // lblDentist
            // 
            lblDentist.AutoSize = true;
            lblDentist.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDentist.ForeColor = SystemColors.ControlDark;
            lblDentist.Location = new Point(4, 9);
            lblDentist.Name = "lblDentist";
            lblDentist.Size = new Size(73, 25);
            lblDentist.TabIndex = 0;
            lblDentist.Text = "Dentist";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BackColor = Color.White;
            guna2TextBox1.BorderRadius = 17;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = Color.Gainsboro;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(20, 240);
            guna2TextBox1.Margin = new Padding(4, 5, 4, 5);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(360, 170);
            guna2TextBox1.TabIndex = 3;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.BackColor = Color.White;
            guna2TextBox2.BorderRadius = 17;
            guna2TextBox2.CustomizableEdges = customizableEdges3;
            guna2TextBox2.DefaultText = "";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.FillColor = Color.Gainsboro;
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Segoe UI", 9F);
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Location = new Point(20, 463);
            guna2TextBox2.Margin = new Padding(4, 5, 4, 5);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox2.Size = new Size(360, 170);
            guna2TextBox2.TabIndex = 4;
            guna2TextBox2.TextChanged += guna2TextBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 210);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 2;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 433);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 15;
            btnSave.CustomizableEdges = customizableEdges5;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(845, 601);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSave.Size = new Size(74, 32);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(411, 601);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 8;
            label7.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(470, 601);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(22, 25);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "0";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(411, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(508, 458);
            dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            Column1.HeaderText = "Desciption";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Amount";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(411, 91);
            label8.Name = "label8";
            label8.Size = new Size(66, 25);
            label8.TabIndex = 11;
            label8.Text = "Billing";
            // 
            // picDelete
            // 
            picDelete.BackgroundImage = (Image)resources.GetObject("picDelete.BackgroundImage");
            picDelete.BackgroundImageLayout = ImageLayout.Stretch;
            picDelete.Location = new Point(876, 91);
            picDelete.Name = "picDelete";
            picDelete.Size = new Size(30, 30);
            picDelete.TabIndex = 12;
            picDelete.TabStop = false;
            // 
            // picPlus
            // 
            picPlus.BackgroundImage = (Image)resources.GetObject("picPlus.BackgroundImage");
            picPlus.BackgroundImageLayout = ImageLayout.Stretch;
            picPlus.Location = new Point(829, 91);
            picPlus.Name = "picPlus";
            picPlus.Size = new Size(30, 30);
            picPlus.TabIndex = 13;
            picPlus.TabStop = false;
            // 
            // picRefresh
            // 
            picRefresh.BackgroundImage = (Image)resources.GetObject("picRefresh.BackgroundImage");
            picRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            picRefresh.Location = new Point(781, 91);
            picRefresh.Name = "picRefresh";
            picRefresh.Size = new Size(30, 30);
            picRefresh.TabIndex = 14;
            picRefresh.TabStop = false;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 15;
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(659, 601);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new Size(165, 32);
            guna2Button1.TabIndex = 15;
            guna2Button1.Text = "View Receipt";
            // 
            // TreatmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(931, 647);
            Controls.Add(guna2Button1);
            Controls.Add(picRefresh);
            Controls.Add(picPlus);
            Controls.Add(picDelete);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(lblTotal);
            Controls.Add(label7);
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(guna2TextBox2);
            Controls.Add(guna2TextBox1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "TreatmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TreatmentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlus).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRefresh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private LinkLabel linkLabel1;
        private Label lblAppointment;
        private Panel panel3;
        private LinkLabel linkLabel2;
        private Label lblPaient;
        private Panel panel4;
        private LinkLabel linkLabel3;
        private Label lblDentist;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Label label5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Label label7;
        private Label lblTotal;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label8;
        private PictureBox picDelete;
        private PictureBox picPlus;
        private PictureBox picRefresh;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Button btnClose;
    }
}