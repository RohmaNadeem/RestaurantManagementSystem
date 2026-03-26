namespace RestaurantMangementSystem
{
    partial class POSForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSearchFilter = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.pnlTotals = new System.Windows.Forms.Panel();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblTaxValue = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblSubTotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.pnlCartControls = new System.Windows.Forms.Panel();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnUpdateQuantity = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscountCart = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.pnlDeliveryAddress = new System.Windows.Forms.Panel();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTableNumber = new System.Windows.Forms.Panel();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlOrderType = new System.Windows.Forms.Panel();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.btnDineIn = new System.Windows.Forms.Button();
            this.pnlOrderInfo = new System.Windows.Forms.Panel();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlFooterRight = new System.Windows.Forms.Panel();
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnOpenKitchen = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.pnlFooterLeft = new System.Windows.Forms.Panel();
            this.txtTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalAmountText = new System.Windows.Forms.Label();
            this.txtTotalItems = new System.Windows.Forms.Label();
            this.lblTotalItemsText = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlSearchFilter.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlCart.SuspendLayout();
            this.pnlTotals.SuspendLayout();
            this.pnlCartControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.pnlCustomer.SuspendLayout();
            this.pnlDeliveryAddress.SuspendLayout();
            this.pnlTableNumber.SuspendLayout();
            this.pnlOrderType.SuspendLayout();
            this.pnlOrderInfo.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlFooterRight.SuspendLayout();
            this.pnlFooterLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitContainerMain);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1400, 850);
            this.pnlMain.TabIndex = 0;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.pnlLeft);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.pnlRight);
            this.splitContainerMain.Size = new System.Drawing.Size(1400, 780);
            this.splitContainerMain.SplitterDistance = 700;
            this.splitContainerMain.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.flpProducts);
            this.pnlLeft.Controls.Add(this.pnlSearchFilter);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(10);
            this.pnlLeft.Size = new System.Drawing.Size(700, 780);
            this.pnlLeft.TabIndex = 0;
            // 
            // flpProducts
            // 
            this.flpProducts.AutoScroll = true;
            this.flpProducts.BackColor = System.Drawing.Color.White;
            this.flpProducts.Location = new System.Drawing.Point(10, 60);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(690, 630);
            this.flpProducts.TabIndex = 1;
            // 
            // pnlSearchFilter
            // 
            this.pnlSearchFilter.Controls.Add(this.lblCategory);
            this.pnlSearchFilter.Controls.Add(this.cmbCategory);
            this.pnlSearchFilter.Controls.Add(this.txtSearch);
            this.pnlSearchFilter.Controls.Add(this.lblSearch);
            this.pnlSearchFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchFilter.Location = new System.Drawing.Point(10, 10);
            this.pnlSearchFilter.Name = "pnlSearchFilter";
            this.pnlSearchFilter.Size = new System.Drawing.Size(680, 50);
            this.pnlSearchFilter.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategory.Location = new System.Drawing.Point(320, 15);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(83, 23);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(390, 12);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 31);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.CmbCategory_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(70, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 30);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(10, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 23);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlCart);
            this.pnlRight.Controls.Add(this.pnlCustomer);
            this.pnlRight.Controls.Add(this.pnlDeliveryAddress);
            this.pnlRight.Controls.Add(this.pnlTableNumber);
            this.pnlRight.Controls.Add(this.pnlOrderType);
            this.pnlRight.Controls.Add(this.pnlOrderInfo);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(10);
            this.pnlRight.Size = new System.Drawing.Size(696, 780);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlCart
            // 
            this.pnlCart.Controls.Add(this.pnlTotals);
            this.pnlCart.Controls.Add(this.pnlCartControls);
            this.pnlCart.Controls.Add(this.dgvCart);
            this.pnlCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCart.Location = new System.Drawing.Point(10, 279);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(676, 491);
            this.pnlCart.TabIndex = 5;
            // 
            // pnlTotals
            // 
            this.pnlTotals.Controls.Add(this.lblTotalValue);
            this.pnlTotals.Controls.Add(this.lblDiscountValue);
            this.pnlTotals.Controls.Add(this.lblTaxValue);
            this.pnlTotals.Controls.Add(this.lblSubTotal);
            this.pnlTotals.Controls.Add(this.lblSubTotalValue);
            this.pnlTotals.Controls.Add(this.lblTotal);
            this.pnlTotals.Controls.Add(this.lblDiscount);
            this.pnlTotals.Controls.Add(this.lblTax);
            this.pnlTotals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotals.Location = new System.Drawing.Point(0, 373);
            this.pnlTotals.Name = "pnlTotals";
            this.pnlTotals.Size = new System.Drawing.Size(676, 118);
            this.pnlTotals.TabIndex = 2;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.lblTotalValue.Location = new System.Drawing.Point(250, 54);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(180, 20);
            this.lblTotalValue.TabIndex = 7;
            this.lblTotalValue.Text = "$0.00";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.Location = new System.Drawing.Point(250, 37);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(180, 22);
            this.lblDiscountValue.TabIndex = 6;
            this.lblDiscountValue.Text = "$0.00";
            this.lblDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxValue
            // 
            this.lblTaxValue.Location = new System.Drawing.Point(250, 19);
            this.lblTaxValue.Name = "lblTaxValue";
            this.lblTaxValue.Size = new System.Drawing.Size(180, 25);
            this.lblTaxValue.TabIndex = 5;
            this.lblTaxValue.Text = "$0.00";
            this.lblTaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(9, 2);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(68, 20);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // lblSubTotalValue
            // 
            this.lblSubTotalValue.Location = new System.Drawing.Point(250, 3);
            this.lblSubTotalValue.Name = "lblSubTotalValue";
            this.lblSubTotalValue.Size = new System.Drawing.Size(180, 20);
            this.lblSubTotalValue.TabIndex = 4;
            this.lblSubTotalValue.Text = "$0.00";
            this.lblSubTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(10, 53);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 23);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(8, 37);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(70, 20);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(9, 20);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(75, 20);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax (10%):";
            this.lblTax.Click += new System.EventHandler(this.lblTax_Click);
            // 
            // pnlCartControls
            // 
            this.pnlCartControls.Controls.Add(this.btnClearCart);
            this.pnlCartControls.Controls.Add(this.btnRemoveItem);
            this.pnlCartControls.Controls.Add(this.btnUpdateQuantity);
            this.pnlCartControls.Controls.Add(this.numQuantity);
            this.pnlCartControls.Controls.Add(this.label1);
            this.pnlCartControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCartControls.Location = new System.Drawing.Point(0, 334);
            this.pnlCartControls.Name = "pnlCartControls";
            this.pnlCartControls.Size = new System.Drawing.Size(676, 40);
            this.pnlCartControls.TabIndex = 1;
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnClearCart.FlatAppearance.BorderSize = 0;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearCart.ForeColor = System.Drawing.Color.White;
            this.btnClearCart.Location = new System.Drawing.Point(417, 7);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(80, 25);
            this.btnClearCart.TabIndex = 4;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.BtnClearCart_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(318, 8);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(80, 25);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.BtnRemoveItem_Click);
            // 
            // btnUpdateQuantity
            // 
            this.btnUpdateQuantity.BackColor = System.Drawing.Color.FromArgb(52, 104, 80);
            this.btnUpdateQuantity.FlatAppearance.BorderSize = 0;
            this.btnUpdateQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateQuantity.ForeColor = System.Drawing.Color.White;
            this.btnUpdateQuantity.Location = new System.Drawing.Point(215, 8);
            this.btnUpdateQuantity.Name = "btnUpdateQuantity";
            this.btnUpdateQuantity.Size = new System.Drawing.Size(80, 25);
            this.btnUpdateQuantity.TabIndex = 2;
            this.btnUpdateQuantity.Text = "Update";
            this.btnUpdateQuantity.UseVisualStyleBackColor = false;
            this.btnUpdateQuantity.Click += new System.EventHandler(this.BtnUpdateQuantity_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(122, 11);
            this.numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(60, 27);
            this.numQuantity.TabIndex = 1;
            this.numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Qty to:";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductName,
            this.colPrice,
            this.colQuantity,
            this.colTotal});
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCart.Location = new System.Drawing.Point(0, 0);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(676, 334);
            this.dgvCart.TabIndex = 0;
            this.dgvCart.SelectionChanged += new System.EventHandler(this.DgvCart_SelectionChanged);
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "Product";
            this.colProductName.MinimumWidth = 6;
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colPrice
            // 
            dataGridViewCellStyle1.Format = "C2";
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Qty";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colTotal
            // 
            dataGridViewCellStyle2.Format = "C2";
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Controls.Add(this.txtNotes);
            this.pnlCustomer.Controls.Add(this.lblNotes);
            this.pnlCustomer.Controls.Add(this.txtDiscount);
            this.pnlCustomer.Controls.Add(this.lblDiscountCart);
            this.pnlCustomer.Controls.Add(this.txtCustomerPhone);
            this.pnlCustomer.Controls.Add(this.lblCustomerPhone);
            this.pnlCustomer.Controls.Add(this.txtCustomerName);
            this.pnlCustomer.Controls.Add(this.lblCustomerName);
            this.pnlCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomer.Location = new System.Drawing.Point(10, 204);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(676, 75);
            this.pnlCustomer.TabIndex = 4;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.Location = new System.Drawing.Point(250, 40);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(180, 27);
            this.txtNotes.TabIndex = 7;
            this.txtNotes.TextChanged += new System.EventHandler(this.TxtNotes_TextChanged);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNotes.Location = new System.Drawing.Point(200, 43);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(51, 20);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notes:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiscount.Location = new System.Drawing.Point(82, 40);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 27);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.Text = "0.00";
            this.txtDiscount.TextChanged += new System.EventHandler(this.TxtDiscount_TextChanged);
            // 
            // lblDiscountCart
            // 
            this.lblDiscountCart.AutoSize = true;
            this.lblDiscountCart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiscountCart.Location = new System.Drawing.Point(10, 43);
            this.lblDiscountCart.Name = "lblDiscountCart";
            this.lblDiscountCart.Size = new System.Drawing.Size(70, 20);
            this.lblDiscountCart.TabIndex = 4;
            this.lblDiscountCart.Text = "Discount:";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerPhone.Location = new System.Drawing.Point(250, 10);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(180, 27);
            this.txtCustomerPhone.TabIndex = 3;
            this.txtCustomerPhone.TextChanged += new System.EventHandler(this.TxtCustomerPhone_TextChanged);
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustomerPhone.Location = new System.Drawing.Point(200, 13);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(53, 20);
            this.lblCustomerPhone.TabIndex = 2;
            this.lblCustomerPhone.Text = "Phone:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerName.Location = new System.Drawing.Point(70, 10);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(120, 27);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.TxtCustomerName_TextChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustomerName.Location = new System.Drawing.Point(10, 13);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(75, 20);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer:";
            // 
            // pnlDeliveryAddress
            // 
            this.pnlDeliveryAddress.Controls.Add(this.txtDeliveryAddress);
            this.pnlDeliveryAddress.Controls.Add(this.label3);
            this.pnlDeliveryAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDeliveryAddress.Location = new System.Drawing.Point(10, 170);
            this.pnlDeliveryAddress.Name = "pnlDeliveryAddress";
            this.pnlDeliveryAddress.Size = new System.Drawing.Size(676, 34);
            this.pnlDeliveryAddress.TabIndex = 3;
            this.pnlDeliveryAddress.Visible = false;
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDeliveryAddress.Location = new System.Drawing.Point(70, 3);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(387, 27);
            this.txtDeliveryAddress.TabIndex = 1;
            this.txtDeliveryAddress.TextChanged += new System.EventHandler(this.TxtDeliveryAddress_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(10, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address:";
            // 
            // pnlTableNumber
            // 
            this.pnlTableNumber.Controls.Add(this.cmbTables);
            this.pnlTableNumber.Controls.Add(this.label2);
            this.pnlTableNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTableNumber.Location = new System.Drawing.Point(10, 135);
            this.pnlTableNumber.Name = "pnlTableNumber";
            this.pnlTableNumber.Size = new System.Drawing.Size(676, 35);
            this.pnlTableNumber.TabIndex = 2;
            this.pnlTableNumber.Visible = true;
            // 
            // cmbTables
            // 
            this.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTables.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(70, 3);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(150, 28);
            this.cmbTables.TabIndex = 1;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.CmbTables_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(10, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Table #:";
            // 
            // pnlOrderType
            // 
            this.pnlOrderType.Controls.Add(this.btnDelivery);
            this.pnlOrderType.Controls.Add(this.btnTakeAway);
            this.pnlOrderType.Controls.Add(this.btnDineIn);
            this.pnlOrderType.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrderType.Location = new System.Drawing.Point(10, 94);
            this.pnlOrderType.Name = "pnlOrderType";
            this.pnlOrderType.Size = new System.Drawing.Size(676, 41);
            this.pnlOrderType.TabIndex = 1;
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.Color.FromArgb(18, 36, 25);
            this.btnDelivery.FlatAppearance.BorderSize = 0;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Location = new System.Drawing.Point(204, 7);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(113, 30);
            this.btnDelivery.TabIndex = 2;
            this.btnDelivery.Text = "DELIVERY";
            this.btnDelivery.UseVisualStyleBackColor = false;
            this.btnDelivery.Click += new System.EventHandler(this.BtnDelivery_Click);
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.BackColor = System.Drawing.Color.FromArgb(18, 36, 25);
            this.btnTakeAway.FlatAppearance.BorderSize = 0;
            this.btnTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAway.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTakeAway.ForeColor = System.Drawing.Color.White;
            this.btnTakeAway.Location = new System.Drawing.Point(99, 8);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(91, 30);
            this.btnTakeAway.TabIndex = 1;
            this.btnTakeAway.Text = "TAKE AWAY";
            this.btnTakeAway.UseVisualStyleBackColor = false;
            this.btnTakeAway.Click += new System.EventHandler(this.BtnTakeAway_Click);
            // 
            // btnDineIn
            // 
            this.btnDineIn.BackColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.btnDineIn.FlatAppearance.BorderSize = 0;
            this.btnDineIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDineIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDineIn.ForeColor = System.Drawing.Color.White;
            this.btnDineIn.Location = new System.Drawing.Point(10, 8);
            this.btnDineIn.Name = "btnDineIn";
            this.btnDineIn.Size = new System.Drawing.Size(83, 30);
            this.btnDineIn.TabIndex = 0;
            this.btnDineIn.Text = "DINE IN";
            this.btnDineIn.UseVisualStyleBackColor = false;
            this.btnDineIn.Click += new System.EventHandler(this.BtnDineIn_Click);
            // 
            // pnlOrderInfo
            // 
            this.pnlOrderInfo.Controls.Add(this.txtOrderDate);
            this.pnlOrderInfo.Controls.Add(this.lblOrderDate);
            this.pnlOrderInfo.Controls.Add(this.txtOrderNumber);
            this.pnlOrderInfo.Controls.Add(this.lblOrderNumber);
            this.pnlOrderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrderInfo.Location = new System.Drawing.Point(10, 10);
            this.pnlOrderInfo.Name = "pnlOrderInfo";
            this.pnlOrderInfo.Size = new System.Drawing.Size(676, 84);
            this.pnlOrderInfo.TabIndex = 0;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.BackColor = System.Drawing.Color.FromArgb(220, 245, 220);
            this.txtOrderDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOrderDate.Location = new System.Drawing.Point(100, 50);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(200, 30);
            this.txtOrderDate.TabIndex = 3;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOrderDate.Location = new System.Drawing.Point(20, 53);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(50, 23);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "Date:";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.BackColor = System.Drawing.Color.FromArgb(220, 245, 220);
            this.txtOrderNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOrderNumber.Location = new System.Drawing.Point(100, 15);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.ReadOnly = true;
            this.txtOrderNumber.Size = new System.Drawing.Size(200, 30);
            this.txtOrderNumber.TabIndex = 1;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOrderNumber.Location = new System.Drawing.Point(20, 18);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(73, 23);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Order #:";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.pnlFooterRight);
            this.pnlFooter.Controls.Add(this.pnlFooterLeft);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 780);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1400, 70);
            this.pnlFooter.TabIndex = 1;
            // 
            // pnlFooterRight
            // 
            this.pnlFooterRight.Controls.Add(this.btnManageProducts);
            this.pnlFooterRight.Controls.Add(this.btnOpenKitchen);
            this.pnlFooterRight.Controls.Add(this.btnCheckout);
            this.pnlFooterRight.Controls.Add(this.btnNewOrder);
            this.pnlFooterRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFooterRight.Location = new System.Drawing.Point(800, 0);
            this.pnlFooterRight.Name = "pnlFooterRight";
            this.pnlFooterRight.Size = new System.Drawing.Size(600, 70);
            this.pnlFooterRight.TabIndex = 1;
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnManageProducts.FlatAppearance.BorderSize = 0;
            this.btnManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProducts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageProducts.ForeColor = System.Drawing.Color.White;
            this.btnManageProducts.Location = new System.Drawing.Point(470, 15);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(120, 40);
            this.btnManageProducts.TabIndex = 3;
            this.btnManageProducts.Text = "PRODUCTS";
            this.btnManageProducts.UseVisualStyleBackColor = false;
            this.btnManageProducts.Click += new System.EventHandler(this.BtnManageProducts_Click);
            // 
            // btnOpenKitchen
            // 
            this.btnOpenKitchen.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnOpenKitchen.FlatAppearance.BorderSize = 0;
            this.btnOpenKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenKitchen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOpenKitchen.ForeColor = System.Drawing.Color.White;
            this.btnOpenKitchen.Location = new System.Drawing.Point(340, 15);
            this.btnOpenKitchen.Name = "btnOpenKitchen";
            this.btnOpenKitchen.Size = new System.Drawing.Size(120, 40);
            this.btnOpenKitchen.TabIndex = 2;
            this.btnOpenKitchen.Text = "KITCHEN";
            this.btnOpenKitchen.UseVisualStyleBackColor = false;
            this.btnOpenKitchen.Click += new System.EventHandler(this.BtnOpenKitchen_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(180, 15);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(150, 40);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "CHECKOUT";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.FromArgb(18, 36, 25);
            this.btnNewOrder.FlatAppearance.BorderSize = 0;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewOrder.Location = new System.Drawing.Point(50, 15);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(120, 40);
            this.btnNewOrder.TabIndex = 0;
            this.btnNewOrder.Text = "NEW ORDER";
            this.btnNewOrder.UseVisualStyleBackColor = false;
            this.btnNewOrder.Click += new System.EventHandler(this.BtnNewOrder_Click);
            // 
            // pnlFooterLeft
            // 
            this.pnlFooterLeft.Controls.Add(this.txtTotalAmount);
            this.pnlFooterLeft.Controls.Add(this.lblTotalAmountText);
            this.pnlFooterLeft.Controls.Add(this.txtTotalItems);
            this.pnlFooterLeft.Controls.Add(this.lblTotalItemsText);
            this.pnlFooterLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFooterLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlFooterLeft.Name = "pnlFooterLeft";
            this.pnlFooterLeft.Size = new System.Drawing.Size(500, 70);
            this.pnlFooterLeft.TabIndex = 0;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txtTotalAmount.ForeColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.txtTotalAmount.Location = new System.Drawing.Point(250, 30);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(240, 30);
            this.txtTotalAmount.TabIndex = 3;
            this.txtTotalAmount.Text = "$0.00";
            this.txtTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAmountText
            // 
            this.lblTotalAmountText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmountText.Location = new System.Drawing.Point(251, 3);
            this.lblTotalAmountText.Name = "lblTotalAmountText";
            this.lblTotalAmountText.Size = new System.Drawing.Size(240, 30);
            this.lblTotalAmountText.TabIndex = 2;
            this.lblTotalAmountText.Text = "TOTAL";
            this.lblTotalAmountText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txtTotalItems.Location = new System.Drawing.Point(50, 30);
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.Size = new System.Drawing.Size(140, 30);
            this.txtTotalItems.TabIndex = 1;
            this.txtTotalItems.Text = "0";
            this.txtTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalItemsText
            // 
            this.lblTotalItemsText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalItemsText.Location = new System.Drawing.Point(50, 0);
            this.lblTotalItemsText.Name = "lblTotalItemsText";
            this.lblTotalItemsText.Size = new System.Drawing.Size(140, 33);
            this.lblTotalItemsText.TabIndex = 0;
            this.lblTotalItemsText.Text = "ITEMS";
            this.lblTotalItemsText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 850);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.POSForm_FormClosing);
            this.Load += new System.EventHandler(this.POSForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlSearchFilter.ResumeLayout(false);
            this.pnlSearchFilter.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlCart.ResumeLayout(false);
            this.pnlTotals.ResumeLayout(false);
            this.pnlTotals.PerformLayout();
            this.pnlCartControls.ResumeLayout(false);
            this.pnlCartControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.pnlDeliveryAddress.ResumeLayout(false);
            this.pnlDeliveryAddress.PerformLayout();
            this.pnlTableNumber.ResumeLayout(false);
            this.pnlTableNumber.PerformLayout();
            this.pnlOrderType.ResumeLayout(false);
            this.pnlOrderInfo.ResumeLayout(false);
            this.pnlOrderInfo.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooterRight.ResumeLayout(false);
            this.pnlFooterLeft.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.Panel pnlSearchFilter;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.Panel pnlTotals;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.Label lblTaxValue;
        private System.Windows.Forms.Label lblSubTotalValue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Panel pnlCartControls;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnUpdateQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscountCart;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Panel pnlDeliveryAddress;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlTableNumber;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlOrderType;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnTakeAway;
        private System.Windows.Forms.Button btnDineIn;
        private System.Windows.Forms.Panel pnlOrderInfo;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlFooterRight;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnOpenKitchen;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Panel pnlFooterLeft;
        private System.Windows.Forms.Label txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmountText;
        private System.Windows.Forms.Label txtTotalItems;
        private System.Windows.Forms.Label lblTotalItemsText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}