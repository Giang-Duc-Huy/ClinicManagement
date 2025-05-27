namespace ClinicManagement.Pages
{
    partial class PatientPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientPage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            dataGridView1 = new DataGridView();
            clmName = new DataGridViewTextBoxColumn();
            clmPhone = new DataGridViewTextBoxColumn();
            clmEmail = new DataGridViewTextBoxColumn();
            clmAddress = new DataGridViewTextBoxColumn();
            clmDOB = new DataGridViewTextBoxColumn();
            clmGender = new DataGridViewTextBoxColumn();
            clmAllergies = new DataGridViewTextBoxColumn();
            clmCreatedAt = new DataGridViewTextBoxColumn();
            btnAddPatient = new Guna.UI2.WinForms.Guna2Button();
            pnlAdd = new Guna.UI2.WinForms.Guna2ShadowPanel();
            checkBox1 = new CheckBox();
            panel7 = new Panel();
            btnExit = new Button();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            label8 = new Label();
            guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            panel4 = new Panel();
            guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            panel3 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            panel2 = new Panel();
            cmbPatient = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            cmbDentist = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlAdd.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderRadius = 15;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = Color.Silver;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.IconRight = (Image)resources.GetObject("guna2TextBox1.IconRight");
            guna2TextBox1.IconRightOffset = new Point(9, 0);
            guna2TextBox1.IconRightSize = new Size(25, 25);
            guna2TextBox1.Location = new Point(13, 15);
            guna2TextBox1.Margin = new Padding(4, 5, 4, 5);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(443, 39);
            guna2TextBox1.TabIndex = 0;
            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmName, clmPhone, clmEmail, clmAddress, clmDOB, clmGender, clmAllergies, clmCreatedAt });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(13, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1357, 486);
            dataGridView1.TabIndex = 1;
            // 
            // clmName
            // 
            clmName.FillWeight = 119.63736F;
            clmName.HeaderText = "Name";
            clmName.MinimumWidth = 8;
            clmName.Name = "clmName";
            // 
            // clmPhone
            // 
            clmPhone.FillWeight = 34.60718F;
            clmPhone.HeaderText = "Phone";
            clmPhone.MinimumWidth = 8;
            clmPhone.Name = "clmPhone";
            // 
            // clmEmail
            // 
            clmEmail.FillWeight = 34.60718F;
            clmEmail.HeaderText = "Email";
            clmEmail.MinimumWidth = 8;
            clmEmail.Name = "clmEmail";
            // 
            // clmAddress
            // 
            clmAddress.FillWeight = 34.60718F;
            clmAddress.HeaderText = "Address";
            clmAddress.MinimumWidth = 8;
            clmAddress.Name = "clmAddress";
            // 
            // clmDOB
            // 
            clmDOB.FillWeight = 34.60718F;
            clmDOB.HeaderText = "DOB";
            clmDOB.MinimumWidth = 8;
            clmDOB.Name = "clmDOB";
            // 
            // clmGender
            // 
            clmGender.FillWeight = 69.949646F;
            clmGender.HeaderText = "Gender";
            clmGender.MinimumWidth = 8;
            clmGender.Name = "clmGender";
            // 
            // clmAllergies
            // 
            clmAllergies.FillWeight = 69.949646F;
            clmAllergies.HeaderText = "Allergies";
            clmAllergies.MinimumWidth = 8;
            clmAllergies.Name = "clmAllergies";
            // 
            // clmCreatedAt
            // 
            clmCreatedAt.FillWeight = 69.949646F;
            clmCreatedAt.HeaderText = "CreatedAt";
            clmCreatedAt.MinimumWidth = 8;
            clmCreatedAt.Name = "clmCreatedAt";
            // 
            // btnAddPatient
            // 
            btnAddPatient.BorderRadius = 20;
            btnAddPatient.CustomizableEdges = customizableEdges3;
            btnAddPatient.DisabledState.BorderColor = Color.DarkGray;
            btnAddPatient.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddPatient.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddPatient.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddPatient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPatient.ForeColor = Color.White;
            btnAddPatient.Location = new Point(1240, 15);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAddPatient.Size = new Size(130, 41);
            btnAddPatient.TabIndex = 2;
            btnAddPatient.Text = "Add";
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // pnlAdd
            // 
            pnlAdd.BackColor = Color.Transparent;
            pnlAdd.Controls.Add(checkBox1);
            pnlAdd.Controls.Add(panel7);
            pnlAdd.Controls.Add(btnSave);
            pnlAdd.Controls.Add(label8);
            pnlAdd.Controls.Add(guna2TextBox6);
            pnlAdd.Controls.Add(panel4);
            pnlAdd.Controls.Add(panel3);
            pnlAdd.Controls.Add(panel2);
            pnlAdd.Controls.Add(panel1);
            pnlAdd.Controls.Add(label1);
            pnlAdd.Dock = DockStyle.Right;
            pnlAdd.FillColor = Color.White;
            pnlAdd.Location = new Point(789, 0);
            pnlAdd.Name = "pnlAdd";
            pnlAdd.ShadowColor = Color.Black;
            pnlAdd.Size = new Size(596, 583);
            pnlAdd.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(163, 516);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(113, 29);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Cancelled";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(15, 136, 236);
            panel7.Controls.Add(btnExit);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(596, 60);
            panel7.TabIndex = 8;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.OrangeRed;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Location = new Point(16, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(37, 39);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 20;
            btnSave.CustomizableEdges = customizableEdges5;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(465, 516);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSave.Size = new Size(90, 45);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlLightLight;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(34, 323);
            label8.Name = "label8";
            label8.Size = new Size(64, 28);
            label8.TabIndex = 3;
            label8.Text = "Notes";
            // 
            // guna2TextBox6
            // 
            guna2TextBox6.BorderRadius = 15;
            guna2TextBox6.CustomizableEdges = customizableEdges7;
            guna2TextBox6.DefaultText = "";
            guna2TextBox6.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox6.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox6.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox6.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox6.FillColor = Color.Gainsboro;
            guna2TextBox6.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox6.Font = new Font("Segoe UI", 9F);
            guna2TextBox6.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox6.Location = new Point(159, 323);
            guna2TextBox6.Margin = new Padding(4, 5, 4, 5);
            guna2TextBox6.Name = "guna2TextBox6";
            guna2TextBox6.PlaceholderText = "";
            guna2TextBox6.SelectedText = "";
            guna2TextBox6.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2TextBox6.Size = new Size(400, 185);
            guna2TextBox6.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(guna2TextBox5);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(34, 262);
            panel4.Name = "panel4";
            panel4.Size = new Size(525, 49);
            panel4.TabIndex = 4;
            // 
            // guna2TextBox5
            // 
            guna2TextBox5.BackColor = Color.Transparent;
            guna2TextBox5.BorderRadius = 15;
            guna2TextBox5.CustomizableEdges = customizableEdges9;
            guna2TextBox5.DefaultText = "";
            guna2TextBox5.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox5.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox5.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox5.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox5.FillColor = Color.LightGray;
            guna2TextBox5.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox5.Font = new Font("Segoe UI", 9F);
            guna2TextBox5.ForeColor = Color.Black;
            guna2TextBox5.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox5.Location = new Point(125, 5);
            guna2TextBox5.Margin = new Padding(4, 5, 4, 5);
            guna2TextBox5.Name = "guna2TextBox5";
            guna2TextBox5.PlaceholderForeColor = Color.DimGray;
            guna2TextBox5.PlaceholderText = "00 : 00";
            guna2TextBox5.SelectedText = "";
            guna2TextBox5.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2TextBox5.Size = new Size(396, 38);
            guna2TextBox5.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 0;
            label5.Text = "Time";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(34, 207);
            panel3.Name = "panel3";
            panel3.Size = new Size(525, 49);
            panel3.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Wheat;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.AppWorkspace;
            dateTimePicker1.Location = new Point(125, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(396, 31);
            dateTimePicker1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(53, 28);
            label4.TabIndex = 0;
            label4.Text = "Date";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(cmbPatient);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(34, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(525, 49);
            panel2.TabIndex = 3;
            // 
            // cmbPatient
            // 
            cmbPatient.BackColor = Color.Gainsboro;
            cmbPatient.FlatStyle = FlatStyle.Popup;
            cmbPatient.FormattingEnabled = true;
            cmbPatient.Location = new Point(125, 10);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(396, 33);
            cmbPatient.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 0;
            label3.Text = "Patient";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(cmbDentist);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(34, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 49);
            panel1.TabIndex = 2;
            // 
            // cmbDentist
            // 
            cmbDentist.BackColor = Color.Gainsboro;
            cmbDentist.FlatStyle = FlatStyle.Popup;
            cmbDentist.FormattingEnabled = true;
            cmbDentist.Location = new Point(125, 10);
            cmbDentist.Name = "cmbDentist";
            cmbDentist.Size = new Size(396, 33);
            cmbDentist.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 0;
            label2.Text = "Dentist";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 57);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 1;
            label1.Text = "Add record";
            // 
            // PatientPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlAdd);
            Controls.Add(btnAddPatient);
            Controls.Add(dataGridView1);
            Controls.Add(guna2TextBox1);
            Name = "PatientPage";
            Size = new Size(1385, 583);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlAdd.ResumeLayout(false);
            pnlAdd.PerformLayout();
            panel7.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmPhone;
        private DataGridViewTextBoxColumn clmEmail;
        private DataGridViewTextBoxColumn clmAddress;
        private DataGridViewTextBoxColumn clmDOB;
        private DataGridViewTextBoxColumn clmGender;
        private DataGridViewTextBoxColumn clmAllergies;
        private DataGridViewTextBoxColumn clmCreatedAt;
        private Guna.UI2.WinForms.Guna2Button btnAddPatient;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlAdd;
        private CheckBox checkBox1;
        private Panel panel7;
        private Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Label label8;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private Label label5;
        private Panel panel3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Panel panel2;
        private ComboBox cmbPatient;
        private Label label3;
        private Panel panel1;
        private ComboBox cmbDentist;
        private Label label2;
        private Label label1;
    }
}
