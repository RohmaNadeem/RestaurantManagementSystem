using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantMangementSystem
{
    public partial class frmMain : Form
    {
        private Form currentForm = null;
        private string userRole;
        private string userName;
        private Timer timer;

        public frmMain(string role, string username)
        {
            InitializeComponent();
            this.userRole = role;
            this.userName = username;

            InitializeRoleBasedAccess();
            UpdateWelcomeMessage();
            StartTimer();

            this.WindowState = FormWindowState.Maximized;
            ConnectButtonEvents();
        }

        public frmMain() : this("Admin", "Default") // Default constructor for testing
        {
        }

        private void InitializeRoleBasedAccess()
        {
            // Set window title with user info
            this.Text = $"Restaurant Management System - Logged in as: {userName} ({userRole})";

            // Hide/show buttons based on role
            if (userRole == "Cashier")
            {
                // Cashier can only see POS and Kitchen
                btnDashboard.Visible = false;
                btnCategories.Visible = false;
                btnProducts.Visible = false;
                btnTables.Visible = false;
                btnStaff.Visible = false;
                btnReports.Visible = false;
                btnSettings.Visible = false;

                // Show only POS and Kitchen
                btnPOS.Visible = true;
                btnKitchen.Visible = true;

                // Update header title for cashier
                lblHeaderTitle.Text = "POS Terminal - Cashier Mode";
            }
            else if (userRole == "Admin")
            {
                // Admin can see everything
                btnDashboard.Visible = true;
                btnCategories.Visible = true;
                btnProducts.Visible = true;
                btnTables.Visible = true;
                btnStaff.Visible = true;
                btnReports.Visible = true;
                btnSettings.Visible = true;
                btnPOS.Visible = true;
                btnKitchen.Visible = true;

                // Update header title for admin
                lblHeaderTitle.Text = "Dashboard - Admin Mode";
            }

            // Update stats visibility
            UpdateStatsVisibility();
        }

        private void UpdateStatsVisibility()
        {
            // Show stats for admin, hide for cashier
        }

        private void UpdateWelcomeMessage()
        {
            lblWelcome.Text = $"Welcome back, {userName}! ({userRole})\nHere's your restaurant overview for today.";

        }

        private void StartTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
            UpdateDateTime(); // Initial update
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void ConnectButtonEvents()
        {
            // Connect events that are not connected in designer
            btnCategories.Click += btnCategories_Click;
            btnProducts.Click += btnProducts_Click;
            btnTables.Click += btnTables_Click;
            btnStaff.Click += btnStaff_Click;
            btnPOS.Click += btnPOS_Click;
            btnKitchen.Click += btnKitchen_Click;
            btnReports.Click += btnReports_Click;
            btnSettings.Click += btnSettings_Click;
            btnDashboard.Click += btnDashboard_Click;
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        // Event handlers that match designer
        private void btnCategories_Click(object sender, EventArgs e)
        {
            if (userRole != "Admin")
            {
                MessageBox.Show("Access Denied! Only Admin can access Categories.", "Permission Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenChildForm(new categoryfrm());
            lblHeaderTitle.Text = "Category Management";
            SetActiveButton(btnCategories);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (userRole != "Admin")
            {
                MessageBox.Show("Access Denied! Only Admin can access Products.", "Permission Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            OpenChildForm(new productsForm());

            lblHeaderTitle.Text = "Product Management";
            SetActiveButton(btnProducts);
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            if (userRole != "Admin")
            {
                MessageBox.Show("Access Denied! Only Admin can access Tables.", "Permission Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OpenChildForm(new Tables());
            lblHeaderTitle.Text = "Table Management";
            SetActiveButton(btnTables);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (userRole != "Admin")
            {
                MessageBox.Show("Access Denied! Only Admin can access Staff.", "Permission Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenChildForm(new StaffForm() { Text = "Staff Management" });
            lblHeaderTitle.Text = "Staff Management";
            SetActiveButton(btnStaff);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            // Both Admin and Cashier can access POS
            OpenChildForm(new POSForm() { Text = "POS Terminal" });
            lblHeaderTitle.Text = "POS Terminal";
            SetActiveButton(btnPOS);
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            // Both Admin and Cashier can access Kitchen
            OpenChildForm(new KitchenForm() { Text = "Kitchen Display" });
            lblHeaderTitle.Text = "Kitchen Display";
            SetActiveButton(btnKitchen);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (userRole != "Admin")
            {
                MessageBox.Show("Access Denied! Only Admin can access Reports.", "Permission Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenChildForm(new ReportsForm() { Text = "Reports" });
            lblHeaderTitle.Text = "Reports";
            SetActiveButton(btnReports);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (userRole != "Admin")
            {
                MessageBox.Show("Access Denied! Only Admin can access Settings.", "Permission Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenChildForm(new frmSettings() { Text = "Settings" });
            lblHeaderTitle.Text = "Settings";
            SetActiveButton(btnSettings);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Clear current form and show dashboard
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm = null;
            }

            lblHeaderTitle.Text = "Dashboard";
            SetActiveButton(btnDashboard);

            // Show all dashboard panels

            lblWelcome.Visible = true;
            lblSystemInfo.Visible = true;

            UpdateStatsVisibility();
            if (userRole != "Admin")
            {
                MessageBox.Show("Access Denied! Only Admin can access Tables.", "Permission Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OpenChildForm(new DashboardForm());
            lblHeaderTitle.Text = "Table Management";
            SetActiveButton(btnTables);
        }

        // Helper method to highlight active button
        private void SetActiveButton(Button activeButton)
        {
            // Reset all buttons to default color
            foreach (Control control in panelMenu.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.FromArgb(18, 36, 25);
                }
            }

            // Set active button color
            activeButton.BackColor = Color.FromArgb(38, 76, 55);

            // Hide dashboard panels when other forms are open
            if (activeButton != btnDashboard && currentForm != null)
            {

                lblWelcome.Visible = false;
                lblSystemInfo.Visible = false;
            }
        }

        // ADD THESE MISSING METHODS FOR DESIGNER:

        private void frmMain_Load(object sender, EventArgs e)
        {
            // This is the Load event handler - can be empty
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnStaff_Click_1(object sender, EventArgs e)
        {
            // Call the main btnStaff_Click method
            btnStaff_Click(sender, e);
        }

        private void lblStat1Value_Click(object sender, EventArgs e)
        {
            // Empty handler for the label click event
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                timer?.Stop();
                this.Hide();
                new login().Show();
            }
        }

        // Also add these methods that were in your original code
        private void btnExit_Click(object sender, EventArgs e)
        {
            btnExit_Click_1(sender, e);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            btnMinimize_Click_1(sender, e);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            btnMaximize_Click_1(sender, e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            timer?.Stop();
        }

        // Logout functionality
        private void InitializeLogoutButton()
        {
            // Create logout button if not in designer
            Button btnLogout = new Button
            {
                Text = "LOGOUT",
                BackColor = Color.FromArgb(180, 50, 50),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Height = 50,
                Dock = DockStyle.Bottom,
                Cursor = Cursors.Hand
            };

            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Click += btnLogout_Click;

            panelSidebar.Controls.Add(btnLogout);
        }

        // Additional methods for future forms
        private void OpenCategoriesForm()
        {
            // Placeholder for category form
            Form categoryForm = new Form
            {
                Text = "Category Management",
                BackColor = Color.White
            };

            Label lblInfo = new Label
            {
                Text = "Category Management Form\n\nAdd, Edit, Delete Categories",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            categoryForm.Controls.Add(lblInfo);
            OpenChildForm(categoryForm);
        }

        private void OpenProductsForm()
        {
            // Placeholder for products form
            Form productsForm = new Form
            {
                Text = "Product Management",
                BackColor = Color.White
            };

            Label lblInfo = new Label
            {
                Text = "Product Management Form\n\nAdd, Edit, Delete Products",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            productsForm.Controls.Add(lblInfo);
            OpenChildForm(productsForm);
        }

        private void OpenTablesForm()
        {
            // Placeholder for tables form
            Form tablesForm = new Form
            {
                Text = "Table Management",
                BackColor = Color.White
            };

            Label lblInfo = new Label
            {
                Text = "Table Management Form\n\nManage Restaurant Tables",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            tablesForm.Controls.Add(lblInfo);
            OpenChildForm(tablesForm);
        }

        private void OpenPOSForm()
        {
            // Placeholder for POS form
            Form posForm = new Form
            {
                Text = "POS Terminal",
                BackColor = Color.White
            };

            Label lblInfo = new Label
            {
                Text = "POS Terminal\n\nTake Orders & Process Payments",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            posForm.Controls.Add(lblInfo);
            OpenChildForm(posForm);
        }

        private void OpenKitchenForm()
        {
            // Placeholder for kitchen form
            Form kitchenForm = new Form
            {
                Text = "Kitchen Display",
                BackColor = Color.Black,
                ForeColor = Color.White
            };

            Label lblInfo = new Label
            {
                Text = "KITCHEN DISPLAY\n\nActive Orders:\n1. Table 5 - Burger\n2. Table 8 - Pizza\n3. Table 3 - Salad",
                Font = new Font("Consolas", 16, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            kitchenForm.Controls.Add(lblInfo);
            OpenChildForm(kitchenForm);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}