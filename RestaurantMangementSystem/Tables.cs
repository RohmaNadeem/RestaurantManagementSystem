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
    public partial class Tables : Form
    {
        private List<Table> tables;
        private BindingSource bindingSource = new BindingSource();

        // Print fields
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        private int currentRowIndex = 0;
        private int rowsPerPage = 20;
        private Font printFont = new Font("Segoe UI", 9);
        private Font headerFont = new Font("Segoe UI", 9, FontStyle.Bold);

        public Tables()
        {
            InitializeComponent();
           
            SetupPrinting();
            LoadTables();
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

        private void LoadTables()
        {
            tables = TableStorage.GetAllTables().Where(t => t.IsActive).ToList();
            RefreshListBox();
        }

        private void RefreshListBox(string filter = null)
        {
            listBoxTables.Items.Clear();
            var filtered = string.IsNullOrEmpty(filter)
                ? tables
                : tables.Where(t =>
                    (t.Name != null && t.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (t.Location != null && t.Location.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (t.Status != null && t.Status.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0));
            foreach (var table in filtered)
            {
                listBoxTables.Items.Add(table);
            }
        }

        private void SetupDataGridView()
        {
            dataGridViewTables.AutoGenerateColumns = false;
            dataGridViewTables.Columns.Clear();

            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 50
            };
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                DataPropertyName = "Name",
                Width = 100
            };
            DataGridViewTextBoxColumn capacityCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Capacity",
                DataPropertyName = "Capacity",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            };
            DataGridViewTextBoxColumn locationCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Location",
                DataPropertyName = "Location",
                Width = 80
            };
            DataGridViewTextBoxColumn statusCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status",
                Width = 90
            };
            DataGridViewTextBoxColumn minOrderCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Min Order",
                DataPropertyName = "MinimumOrder",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            };
            DataGridViewTextBoxColumn reservedCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Reserved For",
                DataPropertyName = "ReservedFor",
                Width = 120
            };

            dataGridViewTables.Columns.AddRange(idCol, nameCol, capacityCol, locationCol, statusCol, minOrderCol, reservedCol);

            // Color rows based on status (keeping original logic)
            dataGridViewTables.CellFormatting += (s, e) =>
            {
                if (e.RowIndex >= 0 && dataGridViewTables.Rows[e.RowIndex].DataBoundItem is Table t)
                {
                    switch (t.Status)
                    {
                        case "Available":
                            dataGridViewTables.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(232, 245, 233);
                            dataGridViewTables.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(56, 142, 60);
                            break;
                        case "Occupied":
                            dataGridViewTables.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238);
                            dataGridViewTables.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(211, 47, 47);
                            break;
                        case "Reserved":
                            dataGridViewTables.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 224);
                            dataGridViewTables.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(245, 124, 0);
                            break;
                        case "Cleaning":
                            dataGridViewTables.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(227, 242, 253);
                            dataGridViewTables.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(21, 101, 192);
                            break;
                    }
                }
            };

            bindingSource.DataSource = tables;
            dataGridViewTables.DataSource = bindingSource;
        }

        private void UpdateStatistics()
        {
            int total = TableStorage.GetTotalTables();
            int available = TableStorage.GetAvailableTables();
            int occupied = TableStorage.GetOccupiedTables();
            int reserved = TableStorage.GetReservedTables();
            int totalSeats = TableStorage.GetTotalSeats();
            int availableSeats = TableStorage.GetAvailableSeats();

            lblTotalTables.Text = total.ToString();
            lblAvailableTables.Text = available.ToString();
            lblOccupiedTables.Text = occupied.ToString();
            lblReservedTables.Text = reserved.ToString();
            lblTotalSeats.Text = totalSeats.ToString();
            lblAvailableSeats.Text = availableSeats.ToString();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            using (var form = new TableAddEditForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    TableStorage.AddTable(form.Table);
                    tables = TableStorage.GetAllTables().Where(t => t.IsActive).ToList();
                    RefreshListBox(txtSearch.Text);
                    bindingSource.DataSource = tables;
                    bindingSource.ResetBindings(false);
                    UpdateStatistics();
                    lblStatus.Text = $"Table '{form.Table.Name}' added.";
                }
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            if (listBoxTables.SelectedItem is Table selected)
            {
                using (var form = new TableAddEditForm(selected))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        TableStorage.UpdateTable(selected);
                        tables = TableStorage.GetAllTables().Where(t => t.IsActive).ToList();
                        RefreshListBox(txtSearch.Text);
                        bindingSource.DataSource = tables;
                        bindingSource.ResetBindings(false);
                        UpdateStatistics();
                        lblStatus.Text = $"Table '{selected.Name}' updated.";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a table to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            if (listBoxTables.SelectedItem is Table selected)
            {
                var result = MessageBox.Show($"Delete table '{selected.Name}'? (This will mark it as inactive.)", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    TableStorage.DeleteTable(selected.Id);
                    tables = TableStorage.GetAllTables().Where(t => t.IsActive).ToList();
                    RefreshListBox(txtSearch.Text);
                    bindingSource.DataSource = tables;
                    bindingSource.ResetBindings(false);
                    UpdateStatistics();
                    lblStatus.Text = $"Table '{selected.Name}' deleted.";
                }
            }
            else
            {
                MessageBox.Show("Please select a table to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void listBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTables.SelectedItem is Table selected)
            {
                foreach (DataGridViewRow row in dataGridViewTables.Rows)
                {
                    if (row.DataBoundItem is Table t && t.Id == selected.Id)
                    {
                        row.Selected = true;
                        dataGridViewTables.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
                lblStatus.Text = $"Selected: {selected.Name} ({selected.Status})";
            }
        }

        private void btnFloorPlan_Click(object sender, EventArgs e)
        {
            using (var floorPlanForm = new FloorPlanForm())
            {
                floorPlanForm.ShowDialog();
                LoadTables();
                UpdateStatistics();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV|*.csv", FileName = $"Tables_{DateTime.Now:yyyyMMdd}.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new System.IO.StreamWriter(sfd.FileName))
                {
                    sw.WriteLine("Id,Name,Capacity,Location,Status,MinimumOrder,ReservedFor,ReservationTime,ReservationNotes");
                    foreach (var t in tables)
                    {
                        string line = $"{t.Id},\"{t.Name}\",{t.Capacity},\"{t.Location}\",\"{t.Status}\",{t.MinimumOrder},\"{t.ReservedFor}\",{t.ReservationTime},{t.ReservationNotes}";
                        sw.WriteLine(line);
                    }
                }
                MessageBox.Show("Export completed.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ==================== PRINT ====================
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (tables == null || tables.Count == 0)
            {
                MessageBox.Show("No tables to print.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            string title = "Table List";
            e.Graphics.DrawString(title, new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, leftMargin, topMargin);
            yPos = topMargin + lineHeight + 10;

            string header = $"{"ID",-5} {"Name",-15} {"Capacity",-8} {"Location",-12} {"Status",-12} Min Order";
            e.Graphics.DrawString(header, headerFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight + 5;
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos - 2, e.MarginBounds.Right, yPos - 2);

            while (currentRowIndex < tables.Count && count < rowsPerPage)
            {
                var t = tables[currentRowIndex];
                string line = $"{t.Id,-5} {Truncate(t.Name, 15),-15} {t.Capacity,-8} {Truncate(t.Location, 12),-12} {Truncate(t.Status, 12),-12} {t.MinimumOrder,10:C2}";
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight;
                currentRowIndex++;
                count++;
            }

            if (currentRowIndex < tables.Count)
                e.HasMorePages = true;
        }

        private string Truncate(string text, int maxLength)
        {
            if (string.IsNullOrEmpty(text)) return "";
            return text.Length <= maxLength ? text : text.Substring(0, maxLength - 3) + "...";
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LoadTables();
            UpdateStatistics();
        }

        // ========== Global Settings Handling ==========
        private void OnSettingsChanged(object sender, EventArgs e)
        {
           
            LoadTables();          // refresh to update Min Order formatting
            UpdateStatistics();     // update stats labels
        }

      
       

        private void grpDataGrid_Enter(object sender, EventArgs e) { }

        private void dataGridViewTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}