using ClinicManagement.Models;
using System.Linq;

namespace ClinicManagement.Controllers
{
    public class UserController
    {
        private readonly AppDbContext _context;
        public UserController()
        {
            _context = new AppDbContext();
        }

        public User Authenticate(string username, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
} 