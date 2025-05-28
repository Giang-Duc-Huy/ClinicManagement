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
    }
} 