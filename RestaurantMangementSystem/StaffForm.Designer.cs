namespace RestaurantMangementSystem
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pnlThemeLine = new System.Windows.Forms.Panel();
            this.grpStaffList = new System.Windows.Forms.GroupBox();
            this.listBoxStaff = new System.Windows.Forms.ListBox();
            this.panelLeftButtons = new System.Windows.Forms.Panel();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddStaff = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.panelRight = new System.Windows.Forms.Panel();
            this.grpDataGrid = new System.Windows.Forms.GroupBox();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelStats = new System.Windows.Forms.Panel();
            this.lblThisMonthSalary = new System.Windows.Forms.Label();
            this.lblTotalSalary = new System.Windows.Forms.Label();
            this.lblOnLeave = new System.Windows.Forms.Label();
            this.lblActiveStaff = new System.Windows.Forms.Label();
            this.lblTotalStaff = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.grpStaffList.SuspendLayout();
            this.panelLeftButtons.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.grpDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.splitContainer1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(1200, 600);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelRight);
            this.splitContainer1.Size = new System.Drawing.Size(1180, 580);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.pnlThemeLine);
            this.panelLeft.Controls.Add(this.grpStaffList);
            this.panelLeft.Controls.Add(this.panelLeftButtons);
            this.panelLeft.Controls.Add(this.toolStrip1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(350, 580);
            this.panelLeft.TabIndex = 0;
            // 
            // pnlThemeLine
            // 
            this.pnlThemeLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThemeLine.Location = new System.Drawing.Point(0, 27);
            this.pnlThemeLine.Name = "pnlThemeLine";
            this.pnlThemeLine.Size = new System.Drawing.Size(350, 5);
            this.pnlThemeLine.TabIndex = 4;
            // 
            // grpStaffList
            // 
            this.grpStaffList.Controls.Add(this.listBoxStaff);
            this.grpStaffList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStaffList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpStaffList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(104)))), ((int)(((byte)(80)))));
            this.grpStaffList.Location = new System.Drawing.Point(0, 27);
            this.grpStaffList.Name = "grpStaffList";
            this.grpStaffList.Size = new System.Drawing.Size(350, 503);
            this.grpStaffList.TabIndex = 1;
            this.grpStaffList.TabStop = false;
            this.grpStaffList.Text = "Staff";
            // 
            // listBoxStaff
            // 
            this.listBoxStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.listBoxStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxStaff.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.listBoxStaff.FormattingEnabled = true;
            this.listBoxStaff.ItemHeight = 25;
            this.listBoxStaff.Location = new System.Drawing.Point(3, 26);
            this.listBoxStaff.Name = "listBoxStaff";
            this.listBoxStaff.Size = new System.Drawing.Size(344, 474);
            this.listBoxStaff.TabIndex = 0;
            this.listBoxStaff.SelectedIndexChanged += new System.EventHandler(this.listBoxStaff_SelectedIndexChanged);
            // 
            // panelLeftButtons
            // 
            this.panelLeftButtons.Controls.Add(this.btnEditStaff);
            this.panelLeftButtons.Controls.Add(this.btnDeleteStaff);
            this.panelLeftButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLeftButtons.Location = new System.Drawing.Point(0, 530);
            this.panelLeftButtons.Name = "panelLeftButtons";
            this.panelLeftButtons.Size = new System.Drawing.Size(350, 50);
            this.panelLeftButtons.TabIndex = 2;
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditStaff.ForeColor = System.Drawing.Color.White;
            this.btnEditStaff.Location = new System.Drawing.Point(10, 8);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(150, 35);
            this.btnEditStaff.TabIndex = 0;
            this.btnEditStaff.Text = "Edit";
            this.btnEditStaff.UseVisualStyleBackColor = false;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteStaff.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStaff.Location = new System.Drawing.Point(190, 8);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(150, 35);
            this.btnDeleteStaff.TabIndex = 1;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddStaff,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtSearch,
            this.btnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(350, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStaff.Image")));
            this.btnAddStaff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(29, 24);
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 24);
            this.toolStripLabel1.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 27);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 24);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.grpDataGrid);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelRight.Size = new System.Drawing.Size(826, 580);
            this.panelRight.TabIndex = 0;
            // 
            // grpDataGrid
            // 
            this.grpDataGrid.Controls.Add(this.dataGridViewStaff);
            this.grpDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDataGrid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDataGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(104)))), ((int)(((byte)(80)))));
            this.grpDataGrid.Location = new System.Drawing.Point(10, 0);
            this.grpDataGrid.Name = "grpDataGrid";
            this.grpDataGrid.Size = new System.Drawing.Size(816, 580);
            this.grpDataGrid.TabIndex = 0;
            this.grpDataGrid.TabStop = false;
            this.grpDataGrid.Text = "Staff Details";
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.AllowUserToAddRows = false;
            this.dataGridViewStaff.AllowUserToDeleteRows = false;
            this.dataGridViewStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStaff.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStaff.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(104)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStaff.EnableHeadersVisualStyles = false;
            this.dataGridViewStaff.Location = new System.Drawing.Point(3, 26);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.ReadOnly = true;
            this.dataGridViewStaff.RowHeadersVisible = false;
            this.dataGridViewStaff.RowHeadersWidth = 51;
            this.dataGridViewStaff.RowTemplate.Height = 35;
            this.dataGridViewStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStaff.Size = new System.Drawing.Size(810, 551);
            this.dataGridViewStaff.TabIndex = 0;
            this.dataGridViewStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaff_CellContentClick);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelStats);
            this.panelBottom.Controls.Add(this.panelStatus);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 600);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1200, 120);
            this.panelBottom.TabIndex = 2;
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.lblThisMonthSalary);
            this.panelStats.Controls.Add(this.lblTotalSalary);
            this.panelStats.Controls.Add(this.lblOnLeave);
            this.panelStats.Controls.Add(this.lblActiveStaff);
            this.panelStats.Controls.Add(this.lblTotalStaff);
            this.panelStats.Controls.Add(this.label6);
            this.panelStats.Controls.Add(this.label5);
            this.panelStats.Controls.Add(this.label4);
            this.panelStats.Controls.Add(this.label3);
            this.panelStats.Controls.Add(this.label2);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStats.Location = new System.Drawing.Point(0, 0);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(1200, 70);
            this.panelStats.TabIndex = 1;
            // 
            // lblThisMonthSalary
            // 
            this.lblThisMonthSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblThisMonthSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblThisMonthSalary.Location = new System.Drawing.Point(850, 30);
            this.lblThisMonthSalary.Name = "lblThisMonthSalary";
            this.lblThisMonthSalary.Size = new System.Drawing.Size(200, 25);
            this.lblThisMonthSalary.TabIndex = 9;
            this.lblThisMonthSalary.Text = "$0.00";
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.lblTotalSalary.Location = new System.Drawing.Point(850, 5);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(200, 25);
            this.lblTotalSalary.TabIndex = 8;
            this.lblTotalSalary.Text = "$0.00";
            // 
            // lblOnLeave
            // 
            this.lblOnLeave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOnLeave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lblOnLeave.Location = new System.Drawing.Point(550, 30);
            this.lblOnLeave.Name = "lblOnLeave";
            this.lblOnLeave.Size = new System.Drawing.Size(150, 25);
            this.lblOnLeave.TabIndex = 7;
            this.lblOnLeave.Text = "0";
            // 
            // lblActiveStaff
            // 
            this.lblActiveStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblActiveStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.lblActiveStaff.Location = new System.Drawing.Point(200, 30);
            this.lblActiveStaff.Name = "lblActiveStaff";
            this.lblActiveStaff.Size = new System.Drawing.Size(150, 25);
            this.lblActiveStaff.TabIndex = 6;
            this.lblActiveStaff.Text = "0";
            // 
            // lblTotalStaff
            // 
            this.lblTotalStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(104)))), ((int)(((byte)(80)))));
            this.lblTotalStaff.Location = new System.Drawing.Point(200, 5);
            this.lblTotalStaff.Name = "lblTotalStaff";
            this.lblTotalStaff.Size = new System.Drawing.Size(150, 25);
            this.lblTotalStaff.TabIndex = 5;
            this.lblTotalStaff.Text = "0";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(700, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "This Month Salary:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(700, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Monthly Salary:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(400, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "On Leave:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(50, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Active Staff:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(50, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Staff:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.panelStatus.Controls.Add(this.btnPrint);
            this.panelStatus.Controls.Add(this.btnExport);
            this.panelStatus.Controls.Add(this.lblStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 70);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(1200, 50);
            this.panelStatus.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1080, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(970, 10);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 30);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblStatus.Location = new System.Drawing.Point(20, 15);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 23);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Ready";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Management";
            this.panelMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.grpStaffList.ResumeLayout(false);
            this.panelLeftButtons.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.grpDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox grpStaffList;
        private System.Windows.Forms.ListBox listBoxStaff;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddStaff;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.Panel panelLeftButtons;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grpDataGrid;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblThisMonthSalary;
        private System.Windows.Forms.Label lblTotalSalary;
        private System.Windows.Forms.Label lblOnLeave;
        private System.Windows.Forms.Label lblActiveStaff;
        private System.Windows.Forms.Label lblTotalStaff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlThemeLine;
    }
}