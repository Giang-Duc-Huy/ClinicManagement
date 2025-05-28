using ClinicManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicManagement.Controllers
{
    public class HistoryController
    {
        private readonly AppDbContext _context;
        public HistoryController()
        {
            _context = new AppDbContext();
        }
        public List<History> GetHistories(string keyword = "", DateTime? date = null)
        {
            var query = _context.History.AsQueryable();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.ToLower();
                query = query.Where(h => h.PatientName.ToLower().Contains(keyword) || h.DentistName.ToLower().Contains(keyword));
            }
            if (date.HasValue)
            {
                var d = date.Value.Date;
                query = query.Where(h => h.CreateAt.Date == d);
            }
            return query.OrderByDescending(h => h.CreateAt).ToList();
        }
        public void AddHistory(History history)
        {
            _context.History.Add(history);
            _context.SaveChanges();
        }
    }
} 