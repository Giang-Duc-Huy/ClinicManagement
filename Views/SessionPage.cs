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
            guna2DateTimePicker1.ValueChanged += guna2DateTimePicker1_ValueChanged;
            Load(guna2DateTimePicker1.Value.Date);
        }

        private void Load(DateTime? date = null)
        {
            dgvSession1.Columns.Clear();
            dgvSession1.Columns.Add("PatientName", "Patient");
            dgvSession1.Columns.Add("DentistName", "Dentist");
            dgvSession1.Columns.Add("Date", "Date");
            dgvSession1.Columns.Add("Time", "Time");
            dgvSession1.Columns.Add("Amount", "Amount");
            dgvSession1.Columns.Add("CreatedAt", "CreatedAt");
            // ... thêm các cột khác nếu cần

            dgvSession1.EnableHeadersVisualStyles = false;
            dgvSession1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 136, 236);
            dgvSession1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSession1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            var histories = _historyController.GetHistoriesForDisplay(date); 
            
            dgvSession1.Rows.Clear();
            foreach (var h in histories)
            {
                dgvSession1.Rows.Add(h.PatientName, h.DentistName, h.CreateAt.ToString("yyyy-MM-dd"), h.CreateAt.ToString("HH:mm"), h.Amount.ToString("N0"), h.CreateAt.ToString("yyyy-MM-dd HH:mm"));
            }
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Load(guna2DateTimePicker1.Value.Date);
        }

        public void ReloadHistory()
        {
            Load(guna2DateTimePicker1.Value.Date);
        }
    }
}
