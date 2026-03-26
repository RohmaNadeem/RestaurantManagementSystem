using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace RestaurantMangementSystem
{
    public partial class frmSettings : Form
    {
        private Settings settings;

        // Theme colors (used only for tab drawing)
        private Color primaryDark = Color.FromArgb(18, 36, 25);
        private Color primaryMedium = Color.FromArgb(52, 104, 80);
        private Color primaryLight = Color.FromArgb(56, 142, 60);
        private Color accentColor = Color.FromArgb(76, 220, 100);
        private Color bgLight = Color.FromArgb(240, 248, 242);

        public frmSettings()
        {
            InitializeComponent();
            StyleTabControl();
            LoadSettings();
            this.Dock = DockStyle.Fill;
        }

        private void StyleTabControl()
        {
            tabControlSettings.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControlSettings.DrawItem += TabControlSettings_DrawItem;
        }

        private void TabControlSettings_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabPage tabPage = tabControlSettings.TabPages[e.Index];
            Rectangle tabBounds = tabControlSettings.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                using (SolidBrush brush = new SolidBrush(primaryDark))
                    g.FillRectangle(brush, e.Bounds);
                using (Font font = new Font("Segoe UI Semibold", 10))
                using (SolidBrush textBrush = new SolidBrush(Color.White))
                    g.DrawString(tabPage.Text, font, textBrush, tabBounds.X + 15, tabBounds.Y + 8);
            }
            else
            {
                using (SolidBrush brush = new SolidBrush(primaryLight))
                    g.FillRectangle(brush, e.Bounds);
                using (Font font = new Font("Segoe UI", 10))
                using (SolidBrush textBrush = new SolidBrush(Color.White))
                    g.DrawString(tabPage.Text, font, textBrush, tabBounds.X + 15, tabBounds.Y + 8);
            }
        }

        private void LoadSettings()
        {
            settings = SettingsStorage.GetSettings();

            // General tab (no theme/currency now)
            chkAutoBackup.Checked = settings.AutoBackup;

            // Restaurant tab
            txtRestaurantName.Text = settings.RestaurantName;
            txtAddress.Text = settings.Address;
            txtPhone.Text = settings.Phone;
            txtEmail.Text = settings.Email;
            numTax.Value = settings.TaxRate;

            // POS tab
            txtHeader.Text = settings.ReceiptHeader;
            txtFooter.Text = settings.ReceiptFooter;
            chkPrintAuto.Checked = settings.AutoPrintReceipt;
            chkShowPreview.Checked = settings.ShowPreviewBeforePrint;
            chkAskTable.Checked = settings.AlwaysAskForTable;

            // Printer tab
            LoadPrinters();
            comboPrinter.Text = settings.SelectedPrinter;
            comboPaper.Text = settings.PaperSize;

            // Security tab
            chkAutoLock.Checked = settings.AutoLock;
            chkAuditLog.Checked = settings.AuditLog;
        }

        private void LoadPrinters()
        {
            comboPrinter.Items.Clear();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                comboPrinter.Items.Add(printer);
            }
            comboPrinter.Items.Add("Default Printer");
        }

        private void SaveAllSettings()
        {
            // General
            settings.AutoBackup = chkAutoBackup.Checked;

            // Restaurant
            settings.RestaurantName = txtRestaurantName.Text;
            settings.Address = txtAddress.Text;
            settings.Phone = txtPhone.Text;
            settings.Email = txtEmail.Text;
            settings.TaxRate = numTax.Value;

            // POS
            settings.ReceiptHeader = txtHeader.Text;
            settings.ReceiptFooter = txtFooter.Text;
            settings.AutoPrintReceipt = chkPrintAuto.Checked;
            settings.ShowPreviewBeforePrint = chkShowPreview.Checked;
            settings.AlwaysAskForTable = chkAskTable.Checked;

            // Printer
            settings.SelectedPrinter = comboPrinter.Text;
            settings.PaperSize = comboPaper.Text;

            // Security
            settings.AutoLock = chkAutoLock.Checked;
            settings.AuditLog = chkAuditLog.Checked;

            SettingsStorage.UpdateSettings(settings);
        }

        // ========== Save Buttons ==========
        private void btnSaveGeneral_Click(object sender, EventArgs e)
        {
            SaveAllSettings();
            MessageBox.Show("General settings saved successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveRestaurant_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRestaurantName.Text))
            {
                MessageBox.Show("Please enter restaurant name!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveAllSettings();
            MessageBox.Show("Restaurant information saved!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSavePOS_Click(object sender, EventArgs e)
        {
            SaveAllSettings();
            MessageBox.Show("POS settings saved!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSavePrinter_Click(object sender, EventArgs e)
        {
            SaveAllSettings();
            MessageBox.Show("Printer settings saved!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveSecurity_Click(object sender, EventArgs e)
        {
            SaveAllSettings();
            MessageBox.Show("Security settings saved!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ========== Password Change ==========
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string current = txtCurrentPass.Text;
            string newPass = txtNewPass.Text;
            string confirm = txtConfirm.Text;

            if (string.IsNullOrWhiteSpace(current))
            {
                MessageBox.Show("Please enter current password!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (current != settings.AdminPassword)
            {
                MessageBox.Show("Current password is incorrect!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(newPass))
            {
                MessageBox.Show("Please enter new password!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirm)
            {
                MessageBox.Show("New password and confirm password do not match!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPass.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            settings.AdminPassword = newPass;
            SettingsStorage.UpdateSettings(settings);

            MessageBox.Show("Password changed successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCurrentPass.Clear();
            txtNewPass.Clear();
            txtConfirm.Clear();
        }

        // ========== Test Print ==========
        private void btnTestPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                Graphics g = ev.Graphics;
                Font font = new Font("Segoe UI", 12);
                g.DrawString("TEST PRINT", font, Brushes.Black, 100, 100);
                g.DrawString($"Printer: {comboPrinter.Text}", font, Brushes.Black, 100, 150);
                g.DrawString($"Paper: {comboPaper.Text}", font, Brushes.Black, 100, 200);
                g.DrawString("If you see this, printer is working.", font, Brushes.Black, 100, 250);
            };

            try
            {
                if (comboPrinter.Text != "Default Printer")
                    pd.PrinterSettings.PrinterName = comboPrinter.Text;

                pd.Print();
                MessageBox.Show("Test print sent to printer.", "Test Print",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Print failed: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== Form Events ==========
        private void frmSettings_Load(object sender, EventArgs e)
        {
            // No theme/currency to initialize anymore
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (tabControlSettings != null)
            {
                tabControlSettings.Width = panelMain.ClientSize.Width - 40;
                tabControlSettings.Height = panelMain.ClientSize.Height - 100;
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e) { }

        private void tabPageGeneral_Click(object sender, EventArgs e)
        {

        }
    }
}