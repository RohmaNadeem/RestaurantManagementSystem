using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RestaurantMangementSystem
{
    public partial class StaffForm : Form
    {
        private List<StaffMember> staffList;
        private BindingSource bindingSource = new BindingSource();

        // Print fields
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        private int currentRowIndex = 0;
        private int rowsPerPage = 20;
        private Font printFont = new Font("Segoe UI", 9);
        private Font headerFont = new Font("Segoe UI", 9, FontStyle.Bold);

        public StaffForm()
        {
            InitializeComponent();
            
            SetupPrinting();
            LoadStaff();
            SetupDataGridView();
            UpdateStatistics();
           
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
           
        }

        private void SetupPrinting()
        {
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            printPreviewDialog.Document = printDocument;
        }

        private void LoadStaff()
        {
            staffList = StaffStorage.GetAllStaff().Where(s => s.IsActive).ToList();
            RefreshListBox();
        }

        private void RefreshListBox(string filter = null)
        {
            listBoxStaff.Items.Clear();
            var filtered = string.IsNullOrEmpty(filter)
                ? staffList
                : staffList.Where(s =>
                    (s.FirstName != null && s.FirstName.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (s.LastName != null && s.LastName.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (s.Role != null && s.Role.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (s.EmployeeId != null && s.EmployeeId.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0));
            foreach (var staff in filtered)
            {
                listBoxStaff.Items.Add(staff);
            }
        }

        private void SetupDataGridView()
        {
            dataGridViewStaff.AutoGenerateColumns = false;
            dataGridViewStaff.Columns.Clear();

            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "EmployeeId",
                Width = 80
            };
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                DataPropertyName = "FullName",
                Width = 150
            };
            DataGridViewTextBoxColumn roleCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Role",
                DataPropertyName = "Role",
                Width = 100
            };
            DataGridViewTextBoxColumn shiftCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Shift",
                DataPropertyName = "Shift",
                Width = 80
            };
            DataGridViewTextBoxColumn phoneCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Phone",
                DataPropertyName = "Phone",
                Width = 100
            };
            DataGridViewTextBoxColumn salaryCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Salary",
                DataPropertyName = "Salary",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            };
            DataGridViewTextBoxColumn statusCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status",
                Width = 90
            };
            DataGridViewCheckBoxColumn activeCol = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Active",
                DataPropertyName = "IsActive",
                Width = 60
            };

            dataGridViewStaff.Columns.AddRange(idCol, nameCol, roleCol, shiftCol, phoneCol, salaryCol, statusCol, activeCol);

            // Row coloring
            dataGridViewStaff.CellFormatting += (s, e) =>
            {
                if (e.RowIndex >= 0 && dataGridViewStaff.Rows[e.RowIndex].DataBoundItem is StaffMember staff)
                {
                    if (!staff.IsActive)
                    {
                        dataGridViewStaff.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                    }
                    else if (staff.Status == "On Leave")
                    {
                        dataGridViewStaff.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 224);
                    }
                }
            };

            bindingSource.DataSource = staffList;
            dataGridViewStaff.DataSource = bindingSource;
        }

        private void UpdateStatistics()
        {
            int total = StaffStorage.GetTotalStaff();
            int active = StaffStorage.GetActiveStaffCount();
            int onLeave = StaffStorage.GetStaffOnLeaveCount();
            decimal totalSalary = StaffStorage.GetTotalMonthlySalary();
            decimal thisMonthSalary = StaffStorage.GetTotalSalaryThisMonth();

            lblTotalStaff.Text = total.ToString();
            lblActiveStaff.Text = active.ToString();
            lblOnLeave.Text = onLeave.ToString();
            lblTotalSalary.Text = totalSalary.ToString("C2", CultureInfo.CurrentCulture);
            lblThisMonthSalary.Text = thisMonthSalary.ToString("C2", CultureInfo.CurrentCulture);
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            using (var form = new StaffAddEditForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    StaffStorage.AddStaff(form.StaffMember);
                    staffList = StaffStorage.GetAllStaff().Where(s => s.IsActive).ToList();
                    RefreshListBox(txtSearch.Text);
                    bindingSource.DataSource = staffList;
                    bindingSource.ResetBindings(false);
                    UpdateStatistics();
                    lblStatus.Text = $"Staff '{form.StaffMember.FullName}' added.";
                }
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (listBoxStaff.SelectedItem is StaffMember selected)
            {
                using (var form = new StaffAddEditForm(selected))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        StaffStorage.UpdateStaff(selected);
                        staffList = StaffStorage.GetAllStaff().Where(s => s.IsActive).ToList();
                        RefreshListBox(txtSearch.Text);
                        bindingSource.DataSource = staffList;
                        bindingSource.ResetBindings(false);
                        UpdateStatistics();
                        lblStatus.Text = $"Staff '{selected.FullName}' updated.";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (listBoxStaff.SelectedItem is StaffMember selected)
            {
                var result = MessageBox.Show($"Mark '{selected.FullName}' as resigned (deactivate)?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    StaffStorage.DeleteStaff(selected.Id);
                    staffList = StaffStorage.GetAllStaff().Where(s => s.IsActive).ToList();
                    RefreshListBox(txtSearch.Text);
                    bindingSource.DataSource = staffList;
                    bindingSource.ResetBindings(false);
                    UpdateStatistics();
                    lblStatus.Text = $"Staff '{selected.FullName}' deactivated.";
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshListBox(txtSearch.Text.Trim());
            lblStatus.Text = $"Search: '{txtSearch.Text}'";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshListBox(txtSearch.Text.Trim());
        }

        private void listBoxStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStaff.SelectedItem is StaffMember selected)
            {
                foreach (DataGridViewRow row in dataGridViewStaff.Rows)
                {
                    if (row.DataBoundItem is StaffMember s && s.Id == selected.Id)
                    {
                        row.Selected = true;
                        dataGridViewStaff.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
                lblStatus.Text = $"Selected: {selected.FullName} ({selected.Role})";
            }
        }

        // ==================== PRINT ====================
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (staffList == null || staffList.Count == 0)
            {
                MessageBox.Show("No staff to print.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            currentRowIndex = 0;
            printPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPos = 0;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float lineHeight = printFont.GetHeight(e.Graphics);

            string title = "Staff List";
            e.Graphics.DrawString(title, new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, leftMargin, topMargin);
            yPos = topMargin + lineHeight + 10;

            string header = $"{"ID",-8} {"Name",-20} {"Role",-15} {"Shift",-10} {"Phone",-15} {"Salary",-12} Status";
            e.Graphics.DrawString(header, headerFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight + 5;
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos - 2, e.MarginBounds.Right, yPos - 2);

            while (currentRowIndex < staffList.Count && count < rowsPerPage)
            {
                var s = staffList[currentRowIndex];
                string line = $"{s.EmployeeId,-8} {Truncate(s.FullName, 20),-20} {Truncate(s.Role, 15),-15} {Truncate(s.Shift, 10),-10} {Truncate(s.Phone, 15),-15} {s.Salary,12:C2} {s.Status}";
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight;
                currentRowIndex++;
                count++;
            }

            if (currentRowIndex < staffList.Count)
                e.HasMorePages = true;
        }

        private string Truncate(string text, int maxLength)
        {
            if (string.IsNullOrEmpty(text)) return "";
            return text.Length <= maxLength ? text : text.Substring(0, maxLength - 3) + "...";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV|*.csv", FileName = $"Staff_{DateTime.Now:yyyyMMdd}.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new System.IO.StreamWriter(sfd.FileName))
                {
                    sw.WriteLine("EmployeeId,FirstName,LastName,Role,Email,Phone,Salary,Shift,Status,Active");
                    foreach (var s in staffList)
                    {
                        sw.WriteLine($"{s.EmployeeId},\"{s.FirstName}\",\"{s.LastName}\",\"{s.Role}\",\"{s.Email}\",\"{s.Phone}\",{s.Salary},\"{s.Shift}\",\"{s.Status}\",{s.IsActive}");
                    }
                }
                MessageBox.Show("Export completed.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LoadStaff();
            UpdateStatistics();
        }

        // ========== Global Settings Handling ==========
        private void OnSettingsChanged(object sender, EventArgs e)
        {
           
            RefreshListBox(txtSearch.Text); // refresh display
            UpdateStatistics(); // update salary formats
        }

       
      
        private void panelMain_Paint(object sender, PaintEventArgs e) { }

        private void dataGridViewStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}