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
    public partial class SessionPage : UserControl
    {
        public SessionPage()
        {
            InitializeComponent();
            Load();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Load()
        {
            dgvSession1.EnableHeadersVisualStyles = false;
            dgvSession1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 136, 236);
            dgvSession1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSession1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

        }
    }
}
