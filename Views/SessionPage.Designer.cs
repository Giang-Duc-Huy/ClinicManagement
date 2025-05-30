namespace ClinicManagement.Pages
{
    partial class SessionPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionPage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            dgvSession1 = new DataGridView();
            Column1 = new DataGridViewImageColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewLinkColumn();
            Column6 = new DataGridViewLinkColumn();
            guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvSession1).BeginInit();
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
            guna2TextBox1.Location = new Point(15, 15);
            guna2TextBox1.Margin = new Padding(4, 5, 4, 5);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(364, 39);
            guna2TextBox1.TabIndex = 0;
           
            // 
            // dgvSession1
            // 
            dgvSession1.AllowUserToAddRows = false;
            dgvSession1.AllowUserToResizeColumns = false;
            dgvSession1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSession1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSession1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSession1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSession1.Columns.AddRange(new DataGridViewColumn[] { Column1, dataGridViewTextBoxColumn6, Column3, Column2, dataGridViewTextBoxColumn7, Column4, Column5, Column6 });
            dgvSession1.EnableHeadersVisualStyles = false;
            dgvSession1.Location = new Point(15, 118);
            dgvSession1.Name = "dgvSession1";
            dgvSession1.RowHeadersWidth = 62;
            dgvSession1.Size = new Size(1354, 443);
            dgvSession1.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.FillWeight = 24.9294567F;
            Column1.HeaderText = "";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.FillWeight = 188.8883F;
            dataGridViewTextBoxColumn6.HeaderText = "Patient";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Column3
            // 
            Column3.FillWeight = 229.289352F;
            Column3.HeaderText = "Dentist";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column2
            // 
            Column2.FillWeight = 84.17542F;
            Column2.HeaderText = "Date";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.FillWeight = 58.8803978F;
            dataGridViewTextBoxColumn7.HeaderText = "Time";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Column4
            // 
            Column4.FillWeight = 84.17542F;
            Column4.HeaderText = "CreatedAt";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.FillWeight = 35.9292259F;
            Column5.HeaderText = "";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.FillWeight = 33.6317863F;
            Column6.HeaderText = "";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // guna2DateTimePicker1
            // 
            guna2DateTimePicker1.Checked = true;
            guna2DateTimePicker1.CustomizableEdges = customizableEdges3;
            guna2DateTimePicker1.FillColor = Color.FromArgb(13, 138, 230);
            guna2DateTimePicker1.Font = new Font("Segoe UI", 9F);
            guna2DateTimePicker1.Format = DateTimePickerFormat.Long;
            guna2DateTimePicker1.Location = new Point(15, 62);
            guna2DateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            guna2DateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2DateTimePicker1.Size = new Size(290, 33);
            guna2DateTimePicker1.TabIndex = 4;
            guna2DateTimePicker1.Value = new DateTime(2025, 5, 27, 20, 45, 22, 923);
            // 
            // SessionPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2DateTimePicker1);
            Controls.Add(dgvSession1);
            Controls.Add(guna2TextBox1);
            Name = "SessionPage";
            Size = new Size(1385, 574);
            ((System.ComponentModel.ISupportInitialize)dgvSession1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private DataGridView dgvSession1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private DataGridViewImageColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewLinkColumn Column5;
        private DataGridViewLinkColumn Column6;
    }
}
