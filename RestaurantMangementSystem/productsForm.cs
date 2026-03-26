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
    public partial class productsForm : Form
    {
        private List<Category> categories;
        private List<Product> products;
        private BindingSource bindingSource = new BindingSource();

        // For printing
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        private int currentRowIndex = 0;
        private int rowsPerPage = 20;
        private Font printFont = new Font("Segoe UI", 9);
        private Font headerFont = new Font("Segoe UI", 9, FontStyle.Bold);

        public productsForm()
        {
            InitializeComponent();
           
            products = new List<Product>();
            LoadProducts();
            LoadCategories();
            SetupDataGridView();
            UpdateStatistics();
            SetupPrinting();
            
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            
        }

        private void LoadCategories()
        {
            categories = CategoryStorage.GetAllCategories();
            listBoxCategories.Items.Clear();
            listBoxCategories.Items.Add("All Categories");
            foreach (var cat in categories)
            {
                listBoxCategories.Items.Add(cat);
            }
            listBoxCategories.SelectedIndex = 0;
        }

        private void LoadProducts()
        {
            products = ProductStorage.GetAllProducts() ?? new List<Product>();
        }

        private void ApplyFilterAndBind()
        {
            if (products == null) return;

            string searchText = txtSearch.Text.Trim().ToLower();
            string selectedCategory = (listBoxCategories.SelectedItem as Category)?.Name;

            var filtered = products.AsEnumerable();

            if (!string.IsNullOrEmpty(searchText))
            {
                filtered = filtered.Where(p =>
                    (p.Name != null && p.Name.ToLower().Contains(searchText)) ||
                    (p.Description != null && p.Description.ToLower().Contains(searchText)));
            }

            if (selectedCategory != null && listBoxCategories.SelectedIndex > 0)
            {
                filtered = filtered.Where(p => p.Category == selectedCategory);
            }

            bindingSource.DataSource = filtered.ToList();
            dataGridViewProducts.DataSource = bindingSource;
        }

        private void SetupDataGridView()
        {
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.Columns.Clear();

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
                Width = 150
            };
            DataGridViewTextBoxColumn categoryCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Category",
                DataPropertyName = "Category",
                Width = 120
            };
            DataGridViewTextBoxColumn priceCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Price",
                DataPropertyName = "Price",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            };
            DataGridViewTextBoxColumn costCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Cost",
                DataPropertyName = "Cost",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            };
            DataGridViewTextBoxColumn stockCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Stock",
                DataPropertyName = "StockQuantity",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            };
            DataGridViewTextBoxColumn unitCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Unit",
                DataPropertyName = "Unit",
                Width = 80
            };
            DataGridViewCheckBoxColumn availableCol = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Available",
                DataPropertyName = "IsAvailable",
                Width = 80
            };

            dataGridViewProducts.Columns.AddRange(idCol, nameCol, categoryCol, priceCol, costCol, stockCol, unitCol, availableCol);

            dataGridViewProducts.CellFormatting += (s, e) =>
            {
                if (e.RowIndex >= 0 && dataGridViewProducts.Rows[e.RowIndex].DataBoundItem is Product p)
                {
                    if (p.StockQuantity <= 5)
                        dataGridViewProducts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 230);
                    else if (!p.IsAvailable)
                        dataGridViewProducts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                    else
                        dataGridViewProducts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            };
        }

        private void UpdateStatistics()
        {
            int total = ProductStorage.GetTotalProducts();
            int lowStock = ProductStorage.GetLowStockProducts(5);
            decimal inventoryValue = ProductStorage.GetTotalInventoryValue();

            lblTotalProducts.Text = total.ToString();
            lblLowStock.Text = lowStock.ToString();
            lblLowStock.ForeColor = lowStock > 0 ? Color.Red : Color.FromArgb(39, 174, 96);
            lblInventoryValue.Text = inventoryValue.ToString("C2", CultureInfo.CurrentCulture);
        }

        // ==================== PRINT SETUP ====================
        private void SetupPrinting()
        {
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            printPreviewDialog.Document = printDocument;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var productsToPrint = bindingSource.DataSource as List<Product>;
            if (productsToPrint == null || productsToPrint.Count == 0)
            {
                MessageBox.Show("No products to print.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            var productsToPrint = bindingSource.DataSource as List<Product>;

            if (productsToPrint == null) return;

            string title = "Product List";
            e.Graphics.DrawString(title, new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, leftMargin, topMargin);
            yPos = topMargin + lineHeight + 10;

            string header = $"{"ID",-5} {"Name",-20} {"Category",-15} {"Price",-10} {"Cost",-10} {"Stock",-8} {"Unit",-10} Available";
            e.Graphics.DrawString(header, headerFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight + 5;
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos - 2, e.MarginBounds.Right, yPos - 2);

            while (currentRowIndex < productsToPrint.Count && count < rowsPerPage)
            {
                var p = productsToPrint[currentRowIndex];
                string line = $"{p.Id,-5} {Truncate(p.Name, 20),-20} {Truncate(p.Category, 15),-15} {p.Price,10:C2} {p.Cost,10:C2} {p.StockQuantity,8} {Truncate(p.Unit, 10),-10} {(p.IsAvailable ? "Yes" : "No")}";
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight;
                currentRowIndex++;
                count++;
            }

            if (currentRowIndex < productsToPrint.Count)
                e.HasMorePages = true;
        }

        private string Truncate(string text, int maxLength)
        {
            if (string.IsNullOrEmpty(text)) return "";
            return text.Length <= maxLength ? text : text.Substring(0, maxLength - 3) + "...";
        }

        // ==================== CRUD ====================
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (var form = new ProductAddEditForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ProductStorage.AddProduct(form.Product);
                    products = ProductStorage.GetAllProducts();
                    ApplyFilterAndBind();
                    UpdateStatistics();
                    lblStatus.Text = $"Product '{form.Product.Name}' added.";
                }
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = dataGridViewProducts.SelectedRows[0].DataBoundItem as Product;
            if (selected != null)
            {
                using (var form = new ProductAddEditForm(selected))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        ProductStorage.UpdateProduct(selected);
                        products = ProductStorage.GetAllProducts();
                        ApplyFilterAndBind();
                        UpdateStatistics();
                        lblStatus.Text = $"Product '{selected.Name}' updated.";
                    }
                }
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = dataGridViewProducts.SelectedRows[0].DataBoundItem as Product;
            if (selected != null)
            {
                var result = MessageBox.Show($"Delete product '{selected.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ProductStorage.DeleteProduct(selected.Id);
                    products = ProductStorage.GetAllProducts();
                    ApplyFilterAndBind();
                    UpdateStatistics();
                    lblStatus.Text = $"Product '{selected.Name}' deleted.";
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilterAndBind();
            lblStatus.Text = $"Search: '{txtSearch.Text}'";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilterAndBind();
        }

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilterAndBind();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            using (var statsForm = new StatisticsForm(products))
            {
                statsForm.ShowDialog();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV|*.csv", FileName = $"Products_{DateTime.Now:yyyyMMdd}.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new System.IO.StreamWriter(sfd.FileName))
                {
                    sw.WriteLine("Id,Name,Category,Description,Price,Cost,Stock,Unit,Available");
                    foreach (var p in products)
                    {
                        sw.WriteLine($"{p.Id},\"{p.Name}\",\"{p.Category}\",\"{p.Description}\",{p.Price},{p.Cost},{p.StockQuantity},{p.Unit},{p.IsAvailable}");
                    }
                }
                MessageBox.Show("Export completed.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LoadCategories();
            ApplyFilterAndBind();
        }

        // ========== Global Settings Handling ==========
        private void OnSettingsChanged(object sender, EventArgs e)
        {
            
           
            // Refresh product list to update price formatting
            ApplyFilterAndBind();
            UpdateStatistics();
        }

       
       

        private void panelMain_Paint(object sender, PaintEventArgs e) { }

        private void grpDataGrid_Enter(object sender, EventArgs e)
        {

        }
    }
}