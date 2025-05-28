using ClinicManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicManagement.Controllers
{
    public class DentistController
    {
        private readonly AppDbContext _context;

        public DentistController()
        {
            _context = new AppDbContext();
        }

        public List<Dentist> GetAllDentists()
        {
            return _context.Dentists
                .OrderByDescending(d => d.Createdat)
                .ToList();
        }

        public bool AddDentist(Dentist dentist)
        {
            try
            {
                dentist.Id = Guid.NewGuid().ToString();
                dentist.Createdat = DateTime.Now;
                
                _context.Dentists.Add(dentist);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ValidateDentist(Dentist dentist)
        {
            if (string.IsNullOrWhiteSpace(dentist.Name) ||
                string.IsNullOrWhiteSpace(dentist.Phone) ||
                string.IsNullOrWhiteSpace(dentist.Gender))
            {
                return false;
            }
            return true;
        }
    }
} 