namespace RestaurantMangementSystem
{
    partial class Tables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tables));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pnlThemeLine = new System.Windows.Forms.Panel();
            this.grpTableList = new System.Windows.Forms.GroupBox();
            this.listBoxTables = new System.Windows.Forms.ListBox();
            this.panelLeftButtons = new System.Windows.Forms.Panel();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddTable = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnFloorPlan = new System.Windows.Forms.ToolStripButton();
            this.panelRight = new System.Windows.Forms.Panel();
            this.grpDataGrid = new System.Windows.Forms.GroupBox();
            this.dataGridViewTables = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelStats = new System.Windows.Forms.Panel();
            this.lblAvailableSeats = new System.Windows.Forms.Label();
            this.lblTotalSeats = new System.Windows.Forms.Label();
            this.lblReservedTables = new System.Windows.Forms.Label();
            this.lblOccupiedTables = new System.Windows.Forms.Label();
            this.lblAvailableTables = new System.Windows.Forms.Label();
            this.lblTotalTables = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.grpTableList.SuspendLayout();
            this.panelLeftButtons.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.grpDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).BeginInit();
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
            this.panelLeft.Controls.Add(this.grpTableList);
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
            // grpTableList
            // 
            this.grpTableList.Controls.Add(this.listBoxTables);
            this.grpTableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTableList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTableList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpTableList.Location = new System.Drawing.Point(0, 27);
            this.grpTableList.Name = "grpTableList";
            this.grpTableList.Size = new System.Drawing.Size(350, 503);
            this.grpTableList.TabIndex = 1;
            this.grpTableList.TabStop = false;
            this.grpTableList.Text = "Tables";
            // 
            // listBoxTables
            // 
            this.listBoxTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.listBoxTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTables.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.listBoxTables.FormattingEnabled = true;
            this.listBoxTables.ItemHeight = 25;
            this.listBoxTables.Location = new System.Drawing.Point(3, 26);
            this.listBoxTables.Name = "listBoxTables";
            this.listBoxTables.Size = new System.Drawing.Size(344, 474);
            this.listBoxTables.TabIndex = 0;
            this.listBoxTables.SelectedIndexChanged += new System.EventHandler(this.listBoxTables_SelectedIndexChanged);
            // 
            // panelLeftButtons
            // 
            this.panelLeftButtons.Controls.Add(this.btnEditTable);
            this.panelLeftButtons.Controls.Add(this.btnDeleteTable);
            this.panelLeftButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLeftButtons.Location = new System.Drawing.Point(0, 530);
            this.panelLeftButtons.Name = "panelLeftButtons";
            this.panelLeftButtons.Size = new System.Drawing.Size(350, 50);
            this.panelLeftButtons.TabIndex = 2;
            // 
            // btnEditTable
            // 
            this.btnEditTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEditTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditTable.ForeColor = System.Drawing.Color.White;
            this.btnEditTable.Location = new System.Drawing.Point(10, 8);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(150, 35);
            this.btnEditTable.TabIndex = 0;
            this.btnEditTable.Text = "Edit";
            this.btnEditTable.UseVisualStyleBackColor = false;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeleteTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTable.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTable.Location = new System.Drawing.Point(190, 8);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(150, 35);
            this.btnDeleteTable.TabIndex = 1;
            this.btnDeleteTable.Text = "Delete";
            this.btnDeleteTable.UseVisualStyleBackColor = false;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTable,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtSearch,
            this.btnSearch,
            this.btnFloorPlan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(350, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // btnAddTable
            // 
            this.btnAddTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddTable.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTable.Image")));
            this.btnAddTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(29, 24);
            this.btnAddTable.Text = "Add Table";
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
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
            // btnFloorPlan
            // 
            this.btnFloorPlan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFloorPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnFloorPlan.Image")));
            this.btnFloorPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFloorPlan.Name = "btnFloorPlan";
            this.btnFloorPlan.Size = new System.Drawing.Size(29, 24);
            this.btnFloorPlan.Text = "Floor Plan";
            this.btnFloorPlan.Click += new System.EventHandler(this.btnFloorPlan_Click);
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
            this.grpDataGrid.Controls.Add(this.dataGridViewTables);
            this.grpDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDataGrid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDataGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpDataGrid.Location = new System.Drawing.Point(10, 0);
            this.grpDataGrid.Name = "grpDataGrid";
            this.grpDataGrid.Size = new System.Drawing.Size(816, 580);
            this.grpDataGrid.TabIndex = 0;
            this.grpDataGrid.TabStop = false;
            this.grpDataGrid.Text = "Table Details";
            this.grpDataGrid.Enter += new System.EventHandler(this.grpDataGrid_Enter);
            // 
            // dataGridViewTables
            // 
            this.dataGridViewTables.AllowUserToAddRows = false;
            this.dataGridViewTables.AllowUserToDeleteRows = false;
            this.dataGridViewTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTables.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTables.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTables.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTables.EnableHeadersVisualStyles = false;
            this.dataGridViewTables.Location = new System.Drawing.Point(3, 26);
            this.dataGridViewTables.Name = "dataGridViewTables";
            this.dataGridViewTables.ReadOnly = true;
            this.dataGridViewTables.RowHeadersVisible = false;
            this.dataGridViewTables.RowHeadersWidth = 51;
            this.dataGridViewTables.RowTemplate.Height = 35;
            this.dataGridViewTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTables.Size = new System.Drawing.Size(810, 551);
            this.dataGridViewTables.TabIndex = 0;
            this.dataGridViewTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTables_CellContentClick);
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
            this.panelStats.Controls.Add(this.lblAvailableSeats);
            this.panelStats.Controls.Add(this.lblTotalSeats);
            this.panelStats.Controls.Add(this.lblReservedTables);
            this.panelStats.Controls.Add(this.lblOccupiedTables);
            this.panelStats.Controls.Add(this.lblAvailableTables);
            this.panelStats.Controls.Add(this.lblTotalTables);
            this.panelStats.Controls.Add(this.label6);
            this.panelStats.Controls.Add(this.label5);
            this.panelStats.Controls.Add(this.label4);
            this.panelStats.Controls.Add(this.label3);
            this.panelStats.Controls.Add(this.label2);
            this.panelStats.Controls.Add(this.label1);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStats.Location = new System.Drawing.Point(0, 0);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(1200, 70);
            this.panelStats.TabIndex = 1;
            // 
            // lblAvailableSeats
            // 
            this.lblAvailableSeats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAvailableSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.lblAvailableSeats.Location = new System.Drawing.Point(1000, 30);
            this.lblAvailableSeats.Name = "lblAvailableSeats";
            this.lblAvailableSeats.Size = new System.Drawing.Size(150, 25);
            this.lblAvailableSeats.TabIndex = 11;
            this.lblAvailableSeats.Text = "0";
            // 
            // lblTotalSeats
            // 
            this.lblTotalSeats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTotalSeats.Location = new System.Drawing.Point(1000, 5);
            this.lblTotalSeats.Name = "lblTotalSeats";
            this.lblTotalSeats.Size = new System.Drawing.Size(150, 25);
            this.lblTotalSeats.TabIndex = 10;
            this.lblTotalSeats.Text = "0";
            // 
            // lblReservedTables
            // 
            this.lblReservedTables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblReservedTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.lblReservedTables.Location = new System.Drawing.Point(600, 30);
            this.lblReservedTables.Name = "lblReservedTables";
            this.lblReservedTables.Size = new System.Drawing.Size(150, 25);
            this.lblReservedTables.TabIndex = 9;
            this.lblReservedTables.Text = "0";
            // 
            // lblOccupiedTables
            // 
            this.lblOccupiedTables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOccupiedTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblOccupiedTables.Location = new System.Drawing.Point(600, 5);
            this.lblOccupiedTables.Name = "lblOccupiedTables";
            this.lblOccupiedTables.Size = new System.Drawing.Size(150, 25);
            this.lblOccupiedTables.TabIndex = 8;
            this.lblOccupiedTables.Text = "0";
            // 
            // lblAvailableTables
            // 
            this.lblAvailableTables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAvailableTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.lblAvailableTables.Location = new System.Drawing.Point(200, 30);
            this.lblAvailableTables.Name = "lblAvailableTables";
            this.lblAvailableTables.Size = new System.Drawing.Size(150, 25);
            this.lblAvailableTables.TabIndex = 7;
            this.lblAvailableTables.Text = "0";
            // 
            // lblTotalTables
            // 
            this.lblTotalTables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTotalTables.Location = new System.Drawing.Point(200, 5);
            this.lblTotalTables.Name = "lblTotalTables";
            this.lblTotalTables.Size = new System.Drawing.Size(150, 25);
            this.lblTotalTables.TabIndex = 6;
            this.lblTotalTables.Text = "0";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(850, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Available Seats:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(850, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Seats:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(450, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reserved Tables:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(450, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Occupied Tables:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(50, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Available Tables:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(50, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Tables:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Management";
            this.panelMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.grpTableList.ResumeLayout(false);
            this.panelLeftButtons.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.grpDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).EndInit();
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
        private System.Windows.Forms.GroupBox grpTableList;
        private System.Windows.Forms.ListBox listBoxTables;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddTable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnFloorPlan;
        private System.Windows.Forms.Panel panelLeftButtons;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grpDataGrid;
        private System.Windows.Forms.DataGridView dataGridViewTables;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblAvailableSeats;
        private System.Windows.Forms.Label lblTotalSeats;
        private System.Windows.Forms.Label lblReservedTables;
        private System.Windows.Forms.Label lblOccupiedTables;
        private System.Windows.Forms.Label lblAvailableTables;
        private System.Windows.Forms.Label lblTotalTables;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlThemeLine;
    }
}