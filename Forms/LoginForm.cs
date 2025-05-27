// This project is for learning purposes only.
// UI built using Guna.UI2 under trial license.

namespace ClinicManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bbbbb", "bbbbbb", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (re == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
