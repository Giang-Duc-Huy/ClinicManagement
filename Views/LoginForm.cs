// This project is for learning purposes only.
// UI built using Guna.UI2 under trial license.

namespace ClinicManagement
{
    using ClinicManagement.Controllers;
    using ClinicManagement.Models;

    public partial class LoginForm : Form
    {
        private UserController _userController = new UserController();

        public LoginForm()
        {
            MessageBox.Show(System.IO.Path.GetFullPath("clinic.db"));
            AppDbContext.SeedDefaultUser();
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            var user = _userController.Authenticate(username, password);
            if (user != null)
            {
                MainForm m = new MainForm();
                this.Hide();
                m.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (re == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
