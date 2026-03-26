using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;

namespace RestaurantMangementSystem
{
    public partial class categoryfrm : Form
    {
        private List<Category> categories;
        private BindingSource bindingSource = new BindingSource();

        // For printing
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        private int currentRowIndex = 0;
        private int rowsPerPage = 20;
        private Font printFont = new Font("Segoe UI", 10);
        private Font headerFont = new Font("Segoe UI", 10, FontStyle.Bold);

        public categoryfrm()
        {
            InitializeComponent();
            LoadCategories();
            SetupDataGridView();
            SetupPrinting();
            
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            
        }

        private void LoadCategories()
        {
            categories = CategoryStorage.GetAllCategories();
            if (categories.Count == 0)
            {
                var defaultCats = new[]
                {
                    new Category { Name = "Appetizers", Description = "Starters", IsActive = true },
                    new Category { Name = "Main Course", Description = "Main dishes", IsActive = true },
                    new Category { Name = "Desserts", Description = "Sweet treats", IsActive = true },
                    new Category { Name = "Beverages", Description = "Drinks", IsActive = true }
                };
                foreach (var cat in defaultCats)
                {
                    CategoryStorage.AddCategory(cat);
                }
                categories = CategoryStorage.GetAllCategories();
            }
            RefreshListBox();
        }

        private void RefreshListBox(string filter = null)
        {
            listBoxCategories.Items.Clear();
            var filtered = string.IsNullOrEmpty(filter)
                ? categories
                : categories.Where(c => c.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
            foreach (var cat in filtered)
            {
                listBoxCategories.Items.Add(cat);
            }
        }

        private void SetupDataGridView()
        {
            dataGridViewCategories.AutoGenerateColumns = false;
            dataGridViewCategories.Columns.Clear();

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
                Width = 200
            };
            DataGridViewTextBoxColumn descCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Description",
                DataPropertyName = "Description",
                Width = 300
            };
            DataGridViewCheckBoxColumn activeCol = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Active",
                DataPropertyName = "IsActive",
                Width = 60
            };
            DataGridViewTextBoxColumn dateCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Created",
                DataPropertyName = "CreatedDate",
                Width = 150
            };

            dataGridViewCategories.Columns.AddRange(idCol, nameCol, descCol, activeCol, dateCol);

            bindingSource.DataSource = categories;
            dataGridViewCategories.DataSource = bindingSource;
        }

        private void SetupPrinting()
        {
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            printPreviewDialog.Document = printDocument;
        }

        // ==================== PRINT ====================
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (categories.Count == 0)
            {
                MessageBox.Show("No categories to print.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            string header = "ID\tName\tDescription\tActive\tCreated";
            yPos = topMargin;
            e.Graphics.DrawString(header, headerFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight + 5;
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos - 2, e.MarginBounds.Right, yPos - 2);

            while (currentRowIndex < categories.Count && count < rowsPerPage)
            {
                var cat = categories[currentRowIndex];
                string line = $"{cat.Id}\t{cat.Name}\t{cat.Description}\t{(cat.IsActive ? "Yes" : "No")}\t{cat.CreatedDate:yyyy-MM-dd}";
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight;
                currentRowIndex++;
                count++;
            }

            if (currentRowIndex < categories.Count)
                e.HasMorePages = true;
        }

        // ==================== EXPORT ====================
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (categories.Count == 0)
            {
                MessageBox.Show("No categories to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                FileName = $"Categories_{DateTime.Now:yyyyMMdd}.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        sw.WriteLine("Id,Name,Description,IsActive,CreatedDate");
                        foreach (var cat in categories)
                        {
                            string line = $"{cat.Id},\"{cat.Name}\",\"{cat.Description}\",{cat.IsActive},{cat.CreatedDate:yyyy-MM-dd}";
                            sw.WriteLine(line);
                        }
                    }
                    MessageBox.Show($"Categories exported successfully to:\n{saveFileDialog.FileName}", "Export Complete",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblStatus.Text = $"Exported {categories.Count} categories to CSV.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error exporting: {ex.Message}", "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==================== CRUD ====================
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            using (var form = new CategoryAddEditForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CategoryStorage.AddCategory(form.Category);
                    categories = CategoryStorage.GetAllCategories();
                    RefreshListBox(txtSearch.Text.Trim());
                    bindingSource.DataSource = categories;
                    bindingSource.ResetBindings(false);
                    lblStatus.Text = $"Category '{form.Category.Name}' added.";
                }
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem is Category selected)
            {
                using (var form = new CategoryAddEditForm(selected))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        CategoryStorage.UpdateCategory(selected);
                        categories = CategoryStorage.GetAllCategories();
                        RefreshListBox(txtSearch.Text.Trim());
                        bindingSource.DataSource = categories;
                        bindingSource.ResetBindings(false);
                        lblStatus.Text = $"Category '{selected.Name}' updated.";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a category to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem is Category selected)
            {
                var result = MessageBox.Show($"Delete category '{selected.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CategoryStorage.DeleteCategory(selected.Id);
                    categories = CategoryStorage.GetAllCategories();
                    RefreshListBox(txtSearch.Text.Trim());
                    bindingSource.DataSource = categories;
                    bindingSource.ResetBindings(false);
                    lblStatus.Text = $"Category '{selected.Name}' deleted.";
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem is Category selected)
            {
                foreach (DataGridViewRow row in dataGridViewCategories.Rows)
                {
                    if (row.DataBoundItem is Category cat && cat.Id == selected.Id)
                    {
                        row.Selected = true;
                        dataGridViewCategories.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
                lblStatus.Text = $"Selected: {selected.Name}";
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e) { }

        // ========== Global Settings Handling ==========
       

      
    }
}