using System;
using System.Net;
using System.Net.Mail;

namespace ClinicManagement.Models
{
    public class Gmail
    {
        public string Sender { get; set; }
        public string Password { get; set; }
        public string Receiver { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int Port { get; set; } = 587;
        public bool Send()
        {
            try
            {
                var smtp = new SmtpClient("smtp.gmail.com", Port)
                {
                    Credentials = new NetworkCredential(Sender, Password),
                    EnableSsl = true
                };
                var mail = new MailMessage(Sender, Receiver, Subject, Body);
                smtp.Send(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
