namespace RestaurantMangementSystem
{
    partial class KitchenForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvKitchenOrders = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMarkServed = new System.Windows.Forms.Button();
            this.btnMarkReady = new System.Windows.Forms.Button();
            this.btnStartPreparing = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitchenOrders)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvKitchenOrders);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1200, 650);
            this.pnlMain.TabIndex = 0;
            // 
            // dgvKitchenOrders
            // 
            this.dgvKitchenOrders.AllowUserToAddRows = false;
            this.dgvKitchenOrders.AllowUserToDeleteRows = false;
            this.dgvKitchenOrders.AllowUserToResizeRows = false;
            this.dgvKitchenOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitchenOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvKitchenOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKitchenOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKitchenOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(104)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKitchenOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKitchenOrders.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKitchenOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKitchenOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKitchenOrders.EnableHeadersVisualStyles = false;
            this.dgvKitchenOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvKitchenOrders.Location = new System.Drawing.Point(0, 80);
            this.dgvKitchenOrders.Name = "dgvKitchenOrders";
            this.dgvKitchenOrders.ReadOnly = true;
            this.dgvKitchenOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKitchenOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKitchenOrders.RowHeadersVisible = false;
            this.dgvKitchenOrders.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.dgvKitchenOrders.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKitchenOrders.RowTemplate.Height = 40;
            this.dgvKitchenOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitchenOrders.Size = new System.Drawing.Size(1200, 570);
            this.dgvKitchenOrders.TabIndex = 0;
            this.dgvKitchenOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKitchenOrders_CellContentClick);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.btnMarkServed);
            this.pnlHeader.Controls.Add(this.btnMarkReady);
            this.pnlHeader.Controls.Add(this.btnStartPreparing);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1030, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 50);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnMarkServed
            // 
            this.btnMarkServed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnMarkServed.FlatAppearance.BorderSize = 0;
            this.btnMarkServed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkServed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkServed.ForeColor = System.Drawing.Color.White;
            this.btnMarkServed.Location = new System.Drawing.Point(870, 15);
            this.btnMarkServed.Name = "btnMarkServed";
            this.btnMarkServed.Size = new System.Drawing.Size(150, 50);
            this.btnMarkServed.TabIndex = 3;
            this.btnMarkServed.Text = "MARK SERVED";
            this.btnMarkServed.UseVisualStyleBackColor = false;
            this.btnMarkServed.Click += new System.EventHandler(this.BtnMarkServed_Click);
            // 
            // btnMarkReady
            // 
            this.btnMarkReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnMarkReady.FlatAppearance.BorderSize = 0;
            this.btnMarkReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkReady.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkReady.ForeColor = System.Drawing.Color.Black;
            this.btnMarkReady.Location = new System.Drawing.Point(710, 15);
            this.btnMarkReady.Name = "btnMarkReady";
            this.btnMarkReady.Size = new System.Drawing.Size(150, 50);
            this.btnMarkReady.TabIndex = 2;
            this.btnMarkReady.Text = "MARK READY";
            this.btnMarkReady.UseVisualStyleBackColor = false;
            this.btnMarkReady.Click += new System.EventHandler(this.BtnMarkReady_Click);
            // 
            // btnStartPreparing
            // 
            this.btnStartPreparing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnStartPreparing.FlatAppearance.BorderSize = 0;
            this.btnStartPreparing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartPreparing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnStartPreparing.ForeColor = System.Drawing.Color.White;
            this.btnStartPreparing.Location = new System.Drawing.Point(550, 15);
            this.btnStartPreparing.Name = "btnStartPreparing";
            this.btnStartPreparing.Size = new System.Drawing.Size(150, 50);
            this.btnStartPreparing.TabIndex = 1;
            this.btnStartPreparing.Text = "START PREPARING";
            this.btnStartPreparing.UseVisualStyleBackColor = false;
            this.btnStartPreparing.Click += new System.EventHandler(this.BtnStartPreparing_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(500, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "KITCHEN ORDERS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 5000;
            this.refreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // KitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.pnlMain);
            this.Name = "KitchenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitchen Display";
            this.Load += new System.EventHandler(this.KitchenForm_Load);
            this.Resize += new System.EventHandler(this.KitchenForm_Resize);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitchenOrders)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvKitchenOrders;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStartPreparing;
        private System.Windows.Forms.Button btnMarkReady;
        private System.Windows.Forms.Button btnMarkServed;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer refreshTimer;

    }
}