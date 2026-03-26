using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantMangementSystem
{
    public partial class POSForm : Form
    {
        private Order currentOrder;
        private Table selectedTable; // For dine-in

        // Color Scheme
        private Color primaryColor = Color.FromArgb(18, 36, 25);
        private Color secondaryColor = Color.FromArgb(52, 104, 80);
        private Color accentColor = Color.FromArgb(56, 142, 60);
        private Color lightGreen = Color.FromArgb(220, 245, 220);

        public POSForm()
        {
            InitializeComponent();
            StartNewOrder();
            LoadCategories();
            LoadProducts();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LoadCategories();
            LoadProducts();
            // If Dine-In panel is visible, refresh available tables
            if (pnlTableNumber.Visible)
                LoadAvailableTables();
        }

        private void StartNewOrder()
        {
            currentOrder = new Order();
            selectedTable = null;
            UpdateOrderDisplay();
            UpdateCartDisplay();
            txtOrderNumber.Text = currentOrder.OrderNumber;
            txtOrderDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            // Default to Dine-In
            currentOrder.Type = OrderType.DineIn;
            UpdateOrderTypeUI();
            pnlTableNumber.Visible = true;
            pnlDeliveryAddress.Visible = false;
            LoadAvailableTables();
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            var categories = ProductStorage.GetAllCategories();
            cmbCategory.Items.Add("All Categories");
            foreach (var category in categories)
            {
                cmbCategory.Items.Add(category);
            }
            cmbCategory.SelectedIndex = 0;
        }

        private void LoadProducts()
        {
            var products = ProductStorage.GetAllProducts().Where(p => p.IsAvailable).ToList();
            DisplayProducts(products);
        }

        private void DisplayProducts(List<Product> products)
        {
            flpProducts.SuspendLayout();
            flpProducts.Controls.Clear();

            int availableWidth = flpProducts.Width - 30;
            int cardWidth = (availableWidth / 2) - 10;
            if (cardWidth < 200) cardWidth = 200;
            if (cardWidth > 250) cardWidth = 250;
            int cardHeight = 170;

            foreach (var product in products)
            {
                var productCard = CreateProductCard(product, cardWidth, cardHeight);
                flpProducts.Controls.Add(productCard);
            }

            flpProducts.ResumeLayout();
        }

        private Panel CreateProductCard(Product product, int width, int height)
        {
            Panel card = new Panel
            {
                Width = width,
                Height = height,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5),
                Cursor = Cursors.Hand,
                Tag = product
            };

            PictureBox pb = new PictureBox
            {
                Size = new Size(50, 50),
                Location = new Point(5, 5),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.None
            };
            if (product.ProductImage != null && product.ProductImage.Length > 0)
            {
                try { pb.Image = product.GetImage(); } catch { pb.Image = null; }
            }

            Label lblName = new Label
            {
                Text = product.Name.Length > 18 ? product.Name.Substring(0, 18) + "..." : product.Name,
                Location = new Point(60, 5),
                Size = new Size(width - 70, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = primaryColor
            };

            Label lblCategory = new Label
            {
                Text = product.Category,
                Location = new Point(60, 28),
                Size = new Size(width - 70, 15),
                Font = new Font("Segoe UI", 7.5f, FontStyle.Italic),
                ForeColor = Color.Gray
            };

            Label lblPrice = new Label
            {
                Text = product.Price.ToString("C2", CultureInfo.CurrentCulture),
                Location = new Point(60, 45),
                Size = new Size(width - 70, 20),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = accentColor
            };

            Label lblStock = new Label
            {
                Text = $"Stock: {product.StockQuantity}",
                Location = new Point(60, 68),
                Size = new Size(width - 70, 15),
                Font = new Font("Segoe UI", 7.5f),
                ForeColor = product.StockQuantity <= 5 ? Color.Red :
                           product.StockQuantity <= 10 ? Color.Orange : Color.Green
            };

            Button btnAdd = new Button
            {
                Text = "ADD",
                Size = new Size(width - 20, 28),
                Location = new Point(10, 90),
                BackColor = secondaryColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                Tag = product,
                Cursor = Cursors.Hand
            };
            btnAdd.Click += (s, e) => AddProductToCart(product);

            card.MouseEnter += (s, e) => card.BackColor = Color.FromArgb(250, 255, 250);
            card.MouseLeave += (s, e) => card.BackColor = Color.White;

            card.Controls.Add(pb);
            card.Controls.Add(lblName);
            card.Controls.Add(lblCategory);
            card.Controls.Add(lblPrice);
            card.Controls.Add(lblStock);
            card.Controls.Add(btnAdd);

            return card;
        }

        private void AddProductToCart(Product product)
        {
            if (product.StockQuantity <= 0)
            {
                MessageBox.Show("This product is out of stock!", "Stock Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentOrder.AddItem(product, 1);
            UpdateCartDisplay();
            UpdateOrderDisplay();
        }

        private void UpdateCartDisplay()
        {
            dgvCart.Rows.Clear();

            foreach (var item in currentOrder.Items)
            {
                dgvCart.Rows.Add(
                    item.ProductName,
                    item.UnitPrice,
                    item.Quantity,
                    item.TotalPrice
                );
            }

            lblSubTotalValue.Text = currentOrder.SubTotal.ToString("C2");
            lblTaxValue.Text = currentOrder.Tax.ToString("C2");
            lblDiscountValue.Text = currentOrder.Discount.ToString("C2");
            lblTotalValue.Text = currentOrder.Total.ToString("C2");
        }

        private void UpdateOrderDisplay()
        {
            txtTotalItems.Text = currentOrder.Items.Sum(i => i.Quantity).ToString();
            txtTotalAmount.Text = currentOrder.Total.ToString("C2");
        }

        // Order type buttons
        private void BtnDineIn_Click(object sender, EventArgs e)
        {
            currentOrder.Type = OrderType.DineIn;
            UpdateOrderTypeUI();
            pnlTableNumber.Visible = true;
            pnlDeliveryAddress.Visible = false;
            LoadAvailableTables();
        }

        private void BtnTakeAway_Click(object sender, EventArgs e)
        {
            currentOrder.Type = OrderType.TakeAway;
            UpdateOrderTypeUI();
            pnlTableNumber.Visible = false;
            pnlDeliveryAddress.Visible = false;
            selectedTable = null;
        }

        private void BtnDelivery_Click(object sender, EventArgs e)
        {
            currentOrder.Type = OrderType.Delivery;
            UpdateOrderTypeUI();
            pnlTableNumber.Visible = false;
            pnlDeliveryAddress.Visible = true;
            selectedTable = null;
        }

        private void UpdateOrderTypeUI()
        {
            btnDineIn.BackColor = currentOrder.Type == OrderType.DineIn ? accentColor : primaryColor;
            btnTakeAway.BackColor = currentOrder.Type == OrderType.TakeAway ? accentColor : primaryColor;
            btnDelivery.BackColor = currentOrder.Type == OrderType.Delivery ? accentColor : primaryColor;
        }

        private void LoadAvailableTables()
        {
            cmbTables.Items.Clear();
            var availableTables = TableStorage.GetTablesByStatus("Available");
            foreach (var table in availableTables)
            {
                cmbTables.Items.Add(table);
            }
            if (cmbTables.Items.Count > 0)
                cmbTables.SelectedIndex = 0;
            else
                cmbTables.Text = "No tables available";
        }

        private void CmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTables.SelectedItem is Table table)
            {
                selectedTable = table;
                currentOrder.TableNumber = table.Name; // store table name for display
            }
        }

        // Customer info
        private void TxtCustomerName_TextChanged(object sender, EventArgs e)
        {
            currentOrder.CustomerName = txtCustomerName.Text;
        }

        private void TxtCustomerPhone_TextChanged(object sender, EventArgs e)
        {
            currentOrder.CustomerPhone = txtCustomerPhone.Text;
        }

        private void TxtDeliveryAddress_TextChanged(object sender, EventArgs e)
        {
            currentOrder.DeliveryAddress = txtDeliveryAddress.Text;
        }

        private void TxtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDiscount.Text, out decimal discount))
            {
                currentOrder.Discount = discount;
                currentOrder.CalculateTotals();
                UpdateCartDisplay();
            }
        }

        private void TxtNotes_TextChanged(object sender, EventArgs e)
        {
            currentOrder.Notes = txtNotes.Text;
        }

        // Cart controls
        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                string productName = dgvCart.SelectedRows[0].Cells[0].Value.ToString();
                var item = currentOrder.Items.FirstOrDefault(i => i.ProductName == productName);
                if (item != null)
                {
                    currentOrder.RemoveItem(item.ProductId);
                    UpdateCartDisplay();
                    UpdateOrderDisplay();
                }
            }
        }

        private void BtnUpdateQuantity_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0 && numQuantity.Value > 0)
            {
                string productName = dgvCart.SelectedRows[0].Cells[0].Value.ToString();
                var item = currentOrder.Items.FirstOrDefault(i => i.ProductName == productName);
                if (item != null)
                {
                    currentOrder.UpdateQuantity(item.ProductId, (int)numQuantity.Value);
                    UpdateCartDisplay();
                    UpdateOrderDisplay();
                }
            }
        }

        private void BtnClearCart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear all items from cart?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentOrder.Items.Clear();
                currentOrder.CalculateTotals();
                UpdateCartDisplay();
                UpdateOrderDisplay();
            }
        }

        // Checkout
        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            if (currentOrder.Items.Count == 0)
            {
                MessageBox.Show("Please add items to cart before checkout!",
                    "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentOrder.Type == OrderType.DineIn && selectedTable == null)
            {
                MessageBox.Show("Please select a table for Dine-In orders!",
                    "Table Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentOrder.Type == OrderType.Delivery && string.IsNullOrWhiteSpace(currentOrder.DeliveryAddress))
            {
                MessageBox.Show("Please enter delivery address for Delivery orders!",
                    "Address Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowPaymentDialog();
        }

        private void ShowPaymentDialog()
        {
            using (PaymentDialog paymentDialog = new PaymentDialog(currentOrder.Total))
            {
                if (paymentDialog.ShowDialog() == DialogResult.OK)
                {
                    currentOrder.PaymentMethod = paymentDialog.PaymentMethod;
                    currentOrder.IsPaid = true;
                    currentOrder.PaidDate = DateTime.Now;
                    currentOrder.Status = OrderStatus.Preparing;

                    // If dine-in, occupy the table
                    if (currentOrder.Type == OrderType.DineIn && selectedTable != null)
                    {
                        TableStorage.UpdateTableStatus(selectedTable.Id, "Occupied");
                    }

                    OrderStorage.AddOrder(currentOrder);
                    UpdateStockQuantities();

                    MessageBox.Show($"Order #{currentOrder.OrderNumber} has been sent to the kitchen!\n" +
                                  $"Status: {currentOrder.Status}\n" +
                                  $"Items: {currentOrder.Items.Count}",
                                  "Order Sent to Kitchen",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                    GenerateReceipt();
                    StartNewOrder();
                    ClearCustomerInfo();
                }
            }
        }

        private void UpdateStockQuantities()
        {
            foreach (var item in currentOrder.Items)
            {
                var product = ProductStorage.GetProductById(item.ProductId);
                if (product != null)
                {
                    product.StockQuantity -= item.Quantity;
                    ProductStorage.UpdateProduct(product);
                }
            }
            LoadProducts();
        }

        private void GenerateReceipt()
        {
            string receipt = GenerateReceiptText();
            MessageBox.Show(receipt, "Order Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GenerateReceiptText()
        {
            string receipt = $"================================\n";
            receipt += $"         RESTAURANT RECEIPT         \n";
            receipt += $"================================\n";
            receipt += $"Order #: {currentOrder.OrderNumber}\n";
            receipt += $"Date: {DateTime.Now:yyyy-MM-dd HH:mm}\n";
            receipt += $"Type: {currentOrder.Type}\n";

            if (currentOrder.Type == OrderType.DineIn && selectedTable != null)
                receipt += $"Table: {selectedTable.Name}\n";
            else if (currentOrder.Type == OrderType.Delivery)
                receipt += $"Address: {currentOrder.DeliveryAddress}\n";

            receipt += $"Customer: {currentOrder.CustomerName}\n";
            receipt += $"Phone: {currentOrder.CustomerPhone}\n";
            receipt += $"================================\n";
            receipt += $"ITEMS:\n";

            foreach (var item in currentOrder.Items)
            {
                receipt += $"{item.ProductName.PadRight(20)} {item.Quantity.ToString().PadLeft(3)} x {item.UnitPrice.ToString("C2")} = {item.TotalPrice.ToString("C2")}\n";
            }

            receipt += $"================================\n";
            receipt += $"Subtotal: {currentOrder.SubTotal.ToString("C2").PadLeft(24)}\n";
            receipt += $"Tax (10%): {currentOrder.Tax.ToString("C2").PadLeft(23)}\n";
            receipt += $"Discount: {currentOrder.Discount.ToString("C2").PadLeft(24)}\n";
            receipt += $"Total: {currentOrder.Total.ToString("C2").PadLeft(28)}\n";
            receipt += $"Payment: {currentOrder.PaymentMethod}\n";
            receipt += $"Status: {currentOrder.Status}\n";
            receipt += $"================================\n";
            receipt += $"        THANK YOU!                \n";
            receipt += $"================================\n";

            return receipt;
        }

        private void ClearCustomerInfo()
        {
            txtCustomerName.Clear();
            txtCustomerPhone.Clear();
            cmbTables.Items.Clear();
            txtDeliveryAddress.Clear();
            txtNotes.Clear();
            txtDiscount.Text = "0.00";
            selectedTable = null;
        }

        // Search and filter
        private void CmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem.ToString() == "All Categories")
            {
                LoadProducts();
            }
            else
            {
                var category = cmbCategory.SelectedItem.ToString();
                var products = ProductStorage.GetAllProducts()
                    .Where(p => p.Category == category && p.IsAvailable)
                    .ToList();
                DisplayProducts(products);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();
            var products = ProductStorage.GetAllProducts()
                .Where(p => p.IsAvailable &&
                           (p.Name.ToLower().Contains(searchTerm) ||
                            p.Category.ToLower().Contains(searchTerm)))
                .ToList();
            DisplayProducts(products);
        }

        private void DgvCart_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                if (dgvCart.SelectedRows[0].Cells[2].Value != null)
                {
                    numQuantity.Value = Convert.ToInt32(dgvCart.SelectedRows[0].Cells[2].Value);
                }
            }
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            if (currentOrder.Items.Count > 0)
            {
                if (MessageBox.Show("Start a new order? Current cart will be cleared.",
                    "Confirm New Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    StartNewOrder();
                    ClearCustomerInfo();
                }
            }
            else
            {
                StartNewOrder();
                ClearCustomerInfo();
            }
        }

        private void BtnManageProducts_Click(object sender, EventArgs e)
        {
            // Open products form (you can implement this)
            MessageBox.Show("Open Products Management form here.");
        }

        private void BtnOpenKitchen_Click(object sender, EventArgs e)
        {
            var kitchenOrders = OrderStorage.GetAllOrders()
                .Where(o => o.Status == OrderStatus.Pending ||
                           o.Status == OrderStatus.Preparing ||
                           o.Status == OrderStatus.Ready)
                .ToList();

            string message = kitchenOrders.Count == 0
                ? "✅ Kitchen is all caught up!\nNo orders to prepare."
                : $"📊 Kitchen has {kitchenOrders.Count} active orders\n" +
                  $"Check Kitchen Display for details.";

            MessageBox.Show(message, "Kitchen Status",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void POSForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentOrder != null && currentOrder.Items.Count > 0)
            {
                var result = MessageBox.Show("You have items in cart. Close anyway?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void lblTax_Click(object sender, EventArgs e) { }
        private void POSForm_Load(object sender, EventArgs e) { }
    }
}