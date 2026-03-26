using System;
using System.Windows.Forms;

namespace RestaurantMangementSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Authentication logic
            if (AuthenticateUser(username, password, out string role))
            {
                // Open main form with user role
                frmMain mainForm = new frmMain(role, username);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password, out string role)
        {
            // Predefined users
            var users = new[]
            {
                new { Username = "admin", Password = "admin123", Role = "Admin" },
                new { Username = "cashier", Password = "cashier123", Role = "Cashier" },
                new { Username = "manager", Password = "manager123", Role = "Admin" }
            };

            foreach (var user in users)
            {
                if (username == user.Username && password == user.Password)
                {
                    role = user.Role;
                    return true;
                }
            }

            role = "";
            return false;
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Default Credentials:\n\n" +
                          "Admin: admin / admin123\n" +
                          "Cashier: cashier / cashier123\n" +
                          "Manager: manager / manager123\n\n" +
                          "Please contact system administrator for password reset.",
                          "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}