using ClinicManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicManagement.Controllers
{
    public class PatientController
    {
        private readonly AppDbContext _context;

        public PatientController()
        {
            _context = new AppDbContext();
        }

        public List<Patient> SearchPatients(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return _context.Patients
                    .OrderByDescending(p => p.Createdat)
                    .ToList();
            }
            keyword = keyword.ToLower();
            return _context.Patients
                .Where(p =>
                    p.Name.ToLower().Contains(keyword) ||
                    p.Phone.ToLower().Contains(keyword) ||
                    p.Email.ToLower().Contains(keyword) ||
                    p.Address.ToLower().Contains(keyword)
                )
                .OrderByDescending(p => p.Createdat)
                .ToList();
        }

        public List<Patient> GetAllPatients()
        {
            return _context.Patients.OrderByDescending(p => p.Createdat).ToList();
        }

        public bool AddPatient(Patient patient)
        {
            try
            {
                _context.Patients.Add(patient);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdatePatient(Patient patient)
        {
            var p = _context.Patients.FirstOrDefault(x => x.Id == patient.Id);
            if (p == null) return false;
            p.Name = patient.Name;
            p.Phone = patient.Phone;
            p.Email = patient.Email;
            p.Address = patient.Address;
            p.DOB = patient.DOB;
            p.Gender = patient.Gender;
            p.Allergies = patient.Allergies;
            _context.SaveChanges();
            return true;
        }

        public bool DeletePatient(string id)
        {
            var p = _context.Patients.FirstOrDefault(x => x.Id == id);
            if (p == null) return false;
            _context.Patients.Remove(p);
            _context.SaveChanges();
            return true;
        }
    }
} 