using System;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantMangementSystem
{
    public partial class StaffAddEditForm : Form
    {
        public StaffMember StaffMember { get; private set; }

        public StaffAddEditForm(StaffMember staff = null)
        {
            InitializeComponent();

            // Set default selections
            cmbRole.SelectedIndex = 0;
            cmbShift.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;

            if (staff == null)
            {
                StaffMember = new StaffMember();
                this.Text = "Add Staff Member";
                dtpDateOfBirth.Value = DateTime.Now.AddYears(-25);
                dtpHireDate.Value = DateTime.Now;
                txtSalary.Text = "2500.00";
                chkActive.Checked = true;
            }
            else
            {
                StaffMember = staff;
                this.Text = "Edit Staff Member";
                txtFirstName.Text = staff.FirstName;
                txtLastName.Text = staff.LastName;
                cmbRole.Text = staff.Role;
                txtEmail.Text = staff.Email;
                txtPhone.Text = staff.Phone;
                txtAddress.Text = staff.Address;
                dtpDateOfBirth.Value = staff.DateOfBirth;
                dtpHireDate.Value = staff.HireDate;
                txtSalary.Text = staff.Salary.ToString("0.00");
                cmbShift.Text = staff.Shift;
                cmbStatus.Text = staff.Status;
                chkActive.Checked = staff.IsActive;
                txtEmergencyContact.Text = staff.EmergencyContact;
                txtEmergencyPhone.Text = staff.EmergencyPhone;
                txtNotes.Text = staff.Notes;
                txtUsername.Text = staff.Username;
                // Do not populate password fields for security
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone number is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtSalary.Text, out decimal salary) || salary <= 0)
            {
                MessageBox.Show("Please enter a valid salary amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbShift.SelectedItem == null)
            {
                MessageBox.Show("Please select a shift.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate username/password for new staff or if changed
            if (StaffMember.Id == 0 || !string.IsNullOrEmpty(txtUsername.Text))
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Username is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (StaffMember.Id == 0 && StaffStorage.UsernameExists(txtUsername.Text.Trim()))
                {
                    MessageBox.Show("Username already exists.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Password is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Update StaffMember object
            StaffMember.FirstName = txtFirstName.Text.Trim();
            StaffMember.LastName = txtLastName.Text.Trim();
            StaffMember.Role = cmbRole.Text;
            StaffMember.Email = txtEmail.Text.Trim();
            StaffMember.Phone = txtPhone.Text.Trim();
            StaffMember.Address = txtAddress.Text.Trim();
            StaffMember.DateOfBirth = dtpDateOfBirth.Value;
            StaffMember.HireDate = dtpHireDate.Value;
            StaffMember.Salary = salary;
            StaffMember.Shift = cmbShift.Text;
            StaffMember.Status = cmbStatus.Text;
            StaffMember.IsActive = chkActive.Checked;
            StaffMember.EmergencyContact = txtEmergencyContact.Text.Trim();
            StaffMember.EmergencyPhone = txtEmergencyPhone.Text.Trim();
            StaffMember.Notes = txtNotes.Text.Trim();
            StaffMember.Username = txtUsername.Text.Trim();
            if (!string.IsNullOrEmpty(txtPassword.Text))
                StaffMember.Password = txtPassword.Text; // In real app, hash it

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void btnGenerateUsername_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter first and last name first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string first = txtFirstName.Text.Trim().ToLower();
            string last = txtLastName.Text.Trim().ToLower();
            string baseUsername = $"{first}.{last}";
            string username = baseUsername;
            int counter = 1;
            while (StaffStorage.UsernameExists(username))
            {
                username = $"{baseUsername}{counter}";
                counter++;
            }
            txtUsername.Text = username;
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%";
            Random rand = new Random();
            string password = new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[rand.Next(s.Length)]).ToArray());
            txtPassword.Text = password;
            txtConfirmPassword.Text = password;
        }
    }
}