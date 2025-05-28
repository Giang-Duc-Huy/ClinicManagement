using ClinicManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicManagement.Controllers
{
    public class AppointmentController
    {
        private readonly AppDbContext _context;
        public AppointmentController()
        {
            _context = new AppDbContext();
        }

        public List<Appointment> GetAppointments(string status = "All", DateTime? date = null)
        {
            var query = _context.Appointments.AsQueryable();
            if (status == "Pending") query = query.Where(a => a.Pending && !a.Canceled && !a.Completed);
            else if (status == "Completed") query = query.Where(a => a.Completed);
            else if (status == "Canceled") query = query.Where(a => a.Canceled);
            if (date.HasValue)
            {
                var d = date.Value.Date;
                query = query.Where(a => a.Date.Date == d);
            }
            return query.OrderByDescending(a => a.DateCreated).ToList();
        }

        public bool AddAppointmentWithCheck(Appointment appt)
        {
            bool isDuplicate = _context.Appointments.Any(a =>
                a.DentistID == appt.DentistID &&
                a.PatientID == appt.PatientID &&
                a.Date.Date == appt.Date.Date &&
                a.Time == appt.Time &&
                !a.Canceled
            );
            if (isDuplicate)
                return false;
            appt.DateCreated = DateTime.Now;
            appt.Pending = true;
            appt.Canceled = false;
            appt.Completed = false;
            _context.Appointments.Add(appt);
            _context.SaveChanges();
            return true;
        }

        public List<Dentist> GetDentists()
        {
            return _context.Dentists.ToList();
        }
        public List<Patient> GetPatients()
        {
            return _context.Patients.ToList();
        }

        public void UpdateStatus(int appointmentId, string status)
        {
            var appt = _context.Appointments.FirstOrDefault(a => a.Id == appointmentId);
            if (appt == null) return;
            appt.Pending = status == "Pending";
            appt.Completed = status == "Completed";
            appt.Canceled = status == "Canceled";
            _context.SaveChanges();
        }
    }
} 