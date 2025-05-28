using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagement.Controllers;

namespace ClinicManagement.Pages
{
    public partial class SessionPage : UserControl
    {
        private HistoryController _historyController = new HistoryController();
        public SessionPage()
        {
            InitializeComponent();
            Load();
        }

        private void Load(string keyword = "", DateTime? date = null)
        {
            dgvSession1.EnableHeadersVisualStyles = false;
            dgvSession1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 136, 236);
            dgvSession1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSession1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            var histories = _historyController.GetHistories(keyword, date);
            dgvSession1.Rows.Clear();
            foreach (var h in histories)
            {
                dgvSession1.Rows.Add(null, h.PatientName, h.DentistName, h.CreateAt.ToString("yyyy-MM-dd"), "", h.CreateAt.ToString("yyyy-MM-dd HH:mm"), null, null);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            Load(guna2TextBox1.Text, null);
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Load(guna2TextBox1.Text, guna2DateTimePicker1.Value.Date);
        }
    }
}
