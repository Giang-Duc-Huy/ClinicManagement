using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagement.Models;

namespace ClinicManagement.Pages
{
    public partial class EmailPage : UserControl
    {
        public EmailPage()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            var gmail = new Gmail
            {
                Sender = txtSender.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Receiver = txtReceiver.Text.Trim(),
                Subject = txtSubject.Text.Trim(),
                Body = guna2TextBox5.Text.Trim(),
                Port = int.TryParse(txtPort.Text.Trim(), out int port) ? port : 587
            };
            bool result = gmail.Send();
            if (result)
            {
                MessageBox.Show("Gửi email thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Lưu log gửi email nếu cần
            }
            else
            {
                MessageBox.Show("Gửi email thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
