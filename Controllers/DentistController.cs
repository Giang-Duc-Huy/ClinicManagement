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

        public bool UpdateDentist(Dentist dentist)
        {
            var d = _context.Dentists.FirstOrDefault(x => x.Id == dentist.Id);
            if (d == null) return false;
            d.Name = dentist.Name;
            d.Phone = dentist.Phone;
            d.Email = dentist.Email;
            d.Address = dentist.Address;
            d.DOB = dentist.DOB;
            d.Gender = dentist.Gender;
            _context.SaveChanges();
            return true;
        }

        public bool DeleteDentist(string id)
        {
            var d = _context.Dentists.FirstOrDefault(x => x.Id == id);
            if (d == null) return false;
            _context.Dentists.Remove(d);
            _context.SaveChanges();
            return true;
        }

        public List<Dentist> SearchDentists(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return GetAllDentists();
            keyword = keyword.ToLower();
            return _context.Dentists
                .Where(d => d.Name.ToLower().Contains(keyword) ||
                            d.Phone.ToLower().Contains(keyword) ||
                            d.Email.ToLower().Contains(keyword))
                .OrderByDescending(d => d.Createdat)
                .ToList();
        }
    }
} 