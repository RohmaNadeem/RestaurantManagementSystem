using System.Drawing;

namespace RestaurantMangementSystem
{
    partial class ReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabControlReports = new System.Windows.Forms.TabControl();
            this.tabPageSales = new System.Windows.Forms.TabPage();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAverageOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageItems = new System.Windows.Forms.TabPage();
            this.dgvPopularItems = new System.Windows.Forms.DataGridView();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantitySold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageOrderTypes = new System.Windows.Forms.TabPage();
            this.dgvOrderTypes = new System.Windows.Forms.DataGridView();
            this.colOrderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPopularItem = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAvgOrderValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.tabControlReports.SuspendLayout();
            this.tabPageSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.tabPageItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopularItems)).BeginInit();
            this.tabPageOrderTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderTypes)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabControlReports);
            this.pnlMain.Controls.Add(this.pnlControls);
            this.pnlMain.Controls.Add(this.pnlSummary);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1400, 850);
            this.pnlMain.TabIndex = 0;
            // 
            // tabControlReports
            // 
            this.tabControlReports.Controls.Add(this.tabPageSales);
            this.tabControlReports.Controls.Add(this.tabPageItems);
            this.tabControlReports.Controls.Add(this.tabPageOrderTypes);
            this.tabControlReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlReports.Location = new System.Drawing.Point(0, 200);
            this.tabControlReports.Name = "tabControlReports";
            this.tabControlReports.SelectedIndex = 0;
            this.tabControlReports.Size = new System.Drawing.Size(1400, 580);
            this.tabControlReports.TabIndex = 4;
            // 
            // tabPageSales
            // 
            this.tabPageSales.Controls.Add(this.dgvSales);
            this.tabPageSales.Location = new System.Drawing.Point(4, 29);
            this.tabPageSales.Name = "tabPageSales";
            this.tabPageSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSales.Size = new System.Drawing.Size(1392, 547);
            this.tabPageSales.TabIndex = 0;
            this.tabPageSales.Text = "Sales Report";
            this.tabPageSales.UseVisualStyleBackColor = true;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colOrders,
            this.colTotalSales,
            this.colAverageOrder});
            this.dgvSales.Location = new System.Drawing.Point(6, 6);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 29;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(560, 354);
            this.dgvSales.TabIndex = 0;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colOrders
            // 
            this.colOrders.HeaderText = "Orders";
            this.colOrders.MinimumWidth = 6;
            this.colOrders.Name = "colOrders";
            this.colOrders.ReadOnly = true;
            // 
            // colTotalSales
            // 
            dataGridViewCellStyle2.Format = "C2";
            this.colTotalSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTotalSales.HeaderText = "Total Sales";
            this.colTotalSales.MinimumWidth = 6;
            this.colTotalSales.Name = "colTotalSales";
            this.colTotalSales.ReadOnly = true;
            // 
            // colAverageOrder
            // 
            this.colAverageOrder.HeaderText = "Average Order";
            this.colAverageOrder.MinimumWidth = 6;
            this.colAverageOrder.Name = "colAverageOrder";
            this.colAverageOrder.ReadOnly = true;
            // 
            // tabPageItems
            // 
            this.tabPageItems.Controls.Add(this.dgvPopularItems);
            this.tabPageItems.Location = new System.Drawing.Point(4, 29);
            this.tabPageItems.Name = "tabPageItems";
            this.tabPageItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItems.Size = new System.Drawing.Size(1392, 547);
            this.tabPageItems.TabIndex = 1;
            this.tabPageItems.Text = "Popular Items";
            this.tabPageItems.UseVisualStyleBackColor = true;
            // 
            // dgvPopularItems
            // 
            this.dgvPopularItems.AllowUserToAddRows = false;
            this.dgvPopularItems.AllowUserToDeleteRows = false;
            this.dgvPopularItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopularItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvPopularItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPopularItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPopularItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopularItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRank,
            this.colProductName,
            this.colQuantitySold,
            this.colRevenue});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPopularItems.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPopularItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPopularItems.Location = new System.Drawing.Point(3, 3);
            this.dgvPopularItems.Name = "dgvPopularItems";
            this.dgvPopularItems.ReadOnly = true;
            this.dgvPopularItems.RowHeadersVisible = false;
            this.dgvPopularItems.RowHeadersWidth = 51;
            this.dgvPopularItems.RowTemplate.Height = 29;
            this.dgvPopularItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopularItems.Size = new System.Drawing.Size(1386, 541);
            this.dgvPopularItems.TabIndex = 0;
            // 
            // colRank
            // 
            this.colRank.HeaderText = "Rank";
            this.colRank.MinimumWidth = 6;
            this.colRank.Name = "colRank";
            this.colRank.ReadOnly = true;
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.MinimumWidth = 6;
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colQuantitySold
            // 
            this.colQuantitySold.HeaderText = "Quantity Sold";
            this.colQuantitySold.MinimumWidth = 6;
            this.colQuantitySold.Name = "colQuantitySold";
            this.colQuantitySold.ReadOnly = true;
            // 
            // colRevenue
            // 
            this.colRevenue.HeaderText = "Revenue";
            this.colRevenue.MinimumWidth = 6;
            this.colRevenue.Name = "colRevenue";
            this.colRevenue.ReadOnly = true;
            // 
            // tabPageOrderTypes
            // 
            this.tabPageOrderTypes.Controls.Add(this.dgvOrderTypes);
            this.tabPageOrderTypes.Location = new System.Drawing.Point(4, 29);
            this.tabPageOrderTypes.Name = "tabPageOrderTypes";
            this.tabPageOrderTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrderTypes.Size = new System.Drawing.Size(1392, 547);
            this.tabPageOrderTypes.TabIndex = 2;
            this.tabPageOrderTypes.Text = "Order Types";
            this.tabPageOrderTypes.UseVisualStyleBackColor = true;
            // 
            // dgvOrderTypes
            // 
            this.dgvOrderTypes.AllowUserToAddRows = false;
            this.dgvOrderTypes.AllowUserToDeleteRows = false;
            this.dgvOrderTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrderTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderType,
            this.colTypeCount,
            this.colPercentage,
            this.colTypeRevenue});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderTypes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrderTypes.Location = new System.Drawing.Point(520, 10);
            this.dgvOrderTypes.Name = "dgvOrderTypes";
            this.dgvOrderTypes.ReadOnly = true;
            this.dgvOrderTypes.RowHeadersVisible = false;
            this.dgvOrderTypes.RowHeadersWidth = 51;
            this.dgvOrderTypes.RowTemplate.Height = 29;
            this.dgvOrderTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderTypes.Size = new System.Drawing.Size(560, 350);
            this.dgvOrderTypes.TabIndex = 0;
            // 
            // colOrderType
            // 
            this.colOrderType.HeaderText = "Order Type";
            this.colOrderType.MinimumWidth = 6;
            this.colOrderType.Name = "colOrderType";
            this.colOrderType.ReadOnly = true;
            // 
            // colTypeCount
            // 
            this.colTypeCount.HeaderText = "Count";
            this.colTypeCount.MinimumWidth = 6;
            this.colTypeCount.Name = "colTypeCount";
            this.colTypeCount.ReadOnly = true;
            // 
            // colPercentage
            // 
            this.colPercentage.HeaderText = "Percentage";
            this.colPercentage.MinimumWidth = 6;
            this.colPercentage.Name = "colPercentage";
            this.colPercentage.ReadOnly = true;
            // 
            // colTypeRevenue
            // 
            this.colTypeRevenue.HeaderText = "Revenue";
            this.colTypeRevenue.MinimumWidth = 6;
            this.colTypeRevenue.Name = "colTypeRevenue";
            this.colTypeRevenue.ReadOnly = true;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.pnlControls.Controls.Add(this.btnLastMonth);
            this.pnlControls.Controls.Add(this.btnThisMonth);
            this.pnlControls.Controls.Add(this.btnLast7Days);
            this.pnlControls.Controls.Add(this.btnToday);
            this.pnlControls.Controls.Add(this.btnGenerateReport);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Controls.Add(this.dtpEndDate);
            this.pnlControls.Controls.Add(this.dtpStartDate);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 100);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1400, 100);
            this.pnlControls.TabIndex = 3;
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(104)))), ((int)(((byte)(80)))));
            this.btnLastMonth.FlatAppearance.BorderSize = 0;
            this.btnLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLastMonth.ForeColor = System.Drawing.Color.White;
            this.btnLastMonth.Location = new System.Drawing.Point(805, 20);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(100, 30);
            this.btnLastMonth.TabIndex = 8;
            this.btnLastMonth.Text = "Last Month";
            this.btnLastMonth.UseVisualStyleBackColor = false;
            this.btnLastMonth.Click += new System.EventHandler(this.BtnLastMonth_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(104)))), ((int)(((byte)(80)))));
            this.btnThisMonth.FlatAppearance.BorderSize = 0;
            this.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThisMonth.ForeColor = System.Drawing.Color.White;
            this.btnThisMonth.Location = new System.Drawing.Point(699, 20);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(100, 30);
            this.btnThisMonth.TabIndex = 7;
            this.btnThisMonth.Text = "This Month";
            this.btnThisMonth.UseVisualStyleBackColor = false;
            this.btnThisMonth.Click += new System.EventHandler(this.BtnThisMonth_Click);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(104)))), ((int)(((byte)(80)))));
            this.btnLast7Days.FlatAppearance.BorderSize = 0;
            this.btnLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast7Days.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLast7Days.ForeColor = System.Drawing.Color.White;
            this.btnLast7Days.Location = new System.Drawing.Point(593, 21);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(100, 30);
            this.btnLast7Days.TabIndex = 6;
            this.btnLast7Days.Text = "Last 7 Days";
            this.btnLast7Days.UseVisualStyleBackColor = false;
            this.btnLast7Days.Click += new System.EventHandler(this.BtnLast7Days_Click);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(104)))), ((int)(((byte)(80)))));
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.Location = new System.Drawing.Point(487, 22);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(100, 30);
            this.btnToday.TabIndex = 5;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.BtnToday_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(911, 20);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(150, 30);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(270, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "From:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(310, 22);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(150, 30);
            this.dtpEndDate.TabIndex = 1;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(90, 22);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(150, 30);
            this.dtpStartDate.TabIndex = 0;
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.White;
            this.pnlSummary.Controls.Add(this.panel4);
            this.pnlSummary.Controls.Add(this.panel3);
            this.pnlSummary.Controls.Add(this.panel2);
            this.pnlSummary.Controls.Add(this.panel1);
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummary.Location = new System.Drawing.Point(0, 0);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(1400, 100);
            this.pnlSummary.TabIndex = 2;
            this.pnlSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSummary_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(205)))));
            this.panel4.Controls.Add(this.lblPopularItem);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(626, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 80);
            this.panel4.TabIndex = 3;
            // 
            // lblPopularItem
            // 
            this.lblPopularItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPopularItem.Location = new System.Drawing.Point(10, 35);
            this.lblPopularItem.Name = "lblPopularItem";
            this.lblPopularItem.Size = new System.Drawing.Size(240, 35);
            this.lblPopularItem.TabIndex = 1;
            this.lblPopularItem.Text = "Cheese Burger (45 sold)";
            this.lblPopularItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(10, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "MOST POPULAR ITEM";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(237)))), ((int)(((byte)(218)))));
            this.panel3.Controls.Add(this.lblAvgOrderValue);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(414, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 80);
            this.panel3.TabIndex = 2;
            // 
            // lblAvgOrderValue
            // 
            this.lblAvgOrderValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAvgOrderValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.lblAvgOrderValue.Location = new System.Drawing.Point(10, 35);
            this.lblAvgOrderValue.Name = "lblAvgOrderValue";
            this.lblAvgOrderValue.Size = new System.Drawing.Size(122, 35);
            this.lblAvgOrderValue.TabIndex = 1;
            this.lblAvgOrderValue.Text = "$24.50";
            this.lblAvgOrderValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(10, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "AVERAGE ORDER VALUE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(220)))));
            this.panel2.Controls.Add(this.lblTotalOrders);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(257, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 80);
            this.panel2.TabIndex = 1;
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.lblTotalOrders.Location = new System.Drawing.Point(10, 30);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(94, 40);
            this.lblTotalOrders.TabIndex = 1;
            this.lblTotalOrders.Text = "124";
            this.lblTotalOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "TOTAL ORDERS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.lblTotalRevenue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(30, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 80);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(10, 30);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(191, 40);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "$3,038.00";
            this.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(23, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "TOTAL REVENUE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(104)))), ((int)(((byte)(80)))));
            this.pnlFooter.Controls.Add(this.btnPrint);
            this.pnlFooter.Controls.Add(this.btnExport);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 780);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1400, 70);
            this.pnlFooter.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(200, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 40);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "   PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(30, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(150, 40);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "   EXPORT";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 850);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabControlReports.ResumeLayout(false);
            this.tabPageSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.tabPageItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopularItems)).EndInit();
            this.tabPageOrderTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderTypes)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAvgOrderValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPopularItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TabControl tabControlReports;
        private System.Windows.Forms.TabPage tabPageSales;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.TabPage tabPageItems;
        private System.Windows.Forms.DataGridView dgvPopularItems;
        private System.Windows.Forms.TabPage tabPageOrderTypes;
        private System.Windows.Forms.DataGridView dgvOrderTypes;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnLastMonth;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
       
        
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAverageOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantitySold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeRevenue;
    }
}