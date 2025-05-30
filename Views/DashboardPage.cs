using System;
using System.Linq;
using System.Windows.Forms;
using ClinicManagement.Models;

namespace ClinicManagement.Pages
{
    public partial class DashboardPage : UserControl
    {
        private AppDbContext _context;

        public DashboardPage()
        {
            InitializeComponent();
            _context = new AppDbContext();
            this.Load += DashboardPage_Load;
        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
            LoadStatistics();
            LoadRevenueReport();
            LoadAppointmentStatus();
        }

        private void LoadStatistics()
        {
        
            lblDentists.Text = _context.Dentists.Count().ToString();
            lblPatients.Text = _context.Patients.Count().ToString();
      
            lblAppointments.Text = _context.Appointments.Count().ToString();
          
            lblCancel.Text = _context.Appointments.Count(a => a.Canceled).ToString();
            lblComplete.Text = _context.Appointments.Count(a => a.Completed).ToString();
        }

        private void LoadRevenueReport()
        {
            dgvPeriodicReport.Rows.Clear();
            int currentYear = DateTime.Now.Year;
            var monthlyRevenue = _context.History
                .Where(h => h.CreateAt.Year == currentYear)
                .GroupBy(h => h.CreateAt.Month)
                .Select(g => new
                {
                    Month = g.Key,
                    TotalAmount = g.Sum(h => h.Amount)
                })
                .OrderBy(x => x.Month)
                .ToList();

            foreach (var revenue in monthlyRevenue)
            {
                dgvPeriodicReport.Rows.Add(
                    revenue.TotalAmount.ToString("N0"),
                    revenue.Month,
                    currentYear
                );
            }
        }

        private void LoadAppointmentStatus()
        {
            dgvASS.Rows.Clear();
            int total = _context.Appointments.Count();
            int completed = _context.Appointments.Count(a => a.Completed);
            int canceled = _context.Appointments.Count(a => a.Canceled);
            int pending = _context.Appointments.Count(a => a.Pending);

            double percentCompleted = total > 0 ? (double)completed / total * 100 : 0;
            double percentCanceled = total > 0 ? (double)canceled / total * 100 : 0;
            double percentPending = total > 0 ? (double)pending / total * 100 : 0;

            dgvASS.Rows.Add("Completed", completed, $"{percentCompleted:F1}%");
            dgvASS.Rows.Add("Canceled", canceled, $"{percentCanceled:F1}%");
            dgvASS.Rows.Add("Pending", pending, $"{percentPending:F1}%");
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

        public void RefreshDashboard()
        {
            LoadStatistics();
            LoadRevenueReport();
            LoadAppointmentStatus();
        }

        private void SaveReport()
        {
            var report = new ClinicManagement.Models.Report
            {
                DentistCount = _context.Dentists.Count(),
                PatientCount = _context.Patients.Count(),
                AppointmentCount = _context.Appointments.Count(),
                CompletedCount = _context.Appointments.Count(a => a.Completed),
                CanceledCount = _context.Appointments.Count(a => a.Canceled),
                PendingCount = _context.Appointments.Count(a => a.Pending),
                Revenue = _context.History.Sum(h => h.Amount),
                ReportDate = DateTime.Now
            };
            _context.Add(report);
            _context.SaveChanges();
        }
    }
}
