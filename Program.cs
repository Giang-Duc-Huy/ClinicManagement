// This project is for learning purposes only.
// UI built using Guna.UI2 under trial license.

using ClinicManagement.Models;

namespace ClinicManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());

        }
    }
}