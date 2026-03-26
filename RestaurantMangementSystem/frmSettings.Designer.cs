namespace RestaurantMangementSystem
{
    partial class frmSettings
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.btnSaveGeneral = new System.Windows.Forms.Button();
            this.chkAutoBackup = new System.Windows.Forms.CheckBox();
            this.tabPageRestaurant = new System.Windows.Forms.TabPage();
            this.btnSaveRestaurant = new System.Windows.Forms.Button();
            this.numTax = new System.Windows.Forms.NumericUpDown();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtRestaurantName = new System.Windows.Forms.TextBox();
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.tabPagePOS = new System.Windows.Forms.TabPage();
            this.btnSavePOS = new System.Windows.Forms.Button();
            this.chkAskTable = new System.Windows.Forms.CheckBox();
            this.chkShowPreview = new System.Windows.Forms.CheckBox();
            this.chkPrintAuto = new System.Windows.Forms.CheckBox();
            this.txtFooter = new System.Windows.Forms.TextBox();
            this.lblFooter = new System.Windows.Forms.Label();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tabPagePrinter = new System.Windows.Forms.TabPage();
            this.btnSavePrinter = new System.Windows.Forms.Button();
            this.btnTestPrint = new System.Windows.Forms.Button();
            this.comboPaper = new System.Windows.Forms.ComboBox();
            this.lblPaper = new System.Windows.Forms.Label();
            this.comboPrinter = new System.Windows.Forms.ComboBox();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.tabPageSecurity = new System.Windows.Forms.TabPage();
            this.btnSaveSecurity = new System.Windows.Forms.Button();
            this.chkAuditLog = new System.Windows.Forms.CheckBox();
            this.chkAutoLock = new System.Windows.Forms.CheckBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.lblCurrentPass = new System.Windows.Forms.Label();
            this.lblPassTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPageRestaurant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTax)).BeginInit();
            this.tabPagePOS.SuspendLayout();
            this.tabPagePrinter.SuspendLayout();
            this.tabPageSecurity.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.panelMain.Controls.Add(this.tabControlSettings);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1100, 700);
            this.panelMain.TabIndex = 0;
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageGeneral);
            this.tabControlSettings.Controls.Add(this.tabPageRestaurant);
            this.tabControlSettings.Controls.Add(this.tabPagePOS);
            this.tabControlSettings.Controls.Add(this.tabPagePrinter);
            this.tabControlSettings.Controls.Add(this.tabPageSecurity);
            this.tabControlSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlSettings.Location = new System.Drawing.Point(23, 80);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.Padding = new System.Drawing.Point(15, 10);
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(1054, 580);
            this.tabControlSettings.TabIndex = 1;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.tabPageGeneral.Controls.Add(this.btnSaveGeneral);
            this.tabPageGeneral.Controls.Add(this.chkAutoBackup);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 46);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(20);
            this.tabPageGeneral.Size = new System.Drawing.Size(1046, 530);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            // 
            // btnSaveGeneral
            // 
            this.btnSaveGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(40)))));
            this.btnSaveGeneral.FlatAppearance.BorderSize = 0;
            this.btnSaveGeneral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.btnSaveGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            this.btnSaveGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveGeneral.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnSaveGeneral.ForeColor = System.Drawing.Color.White;
            this.btnSaveGeneral.Location = new System.Drawing.Point(23, 130);
            this.btnSaveGeneral.Name = "btnSaveGeneral";
            this.btnSaveGeneral.Size = new System.Drawing.Size(250, 45);
            this.btnSaveGeneral.TabIndex = 7;
            this.btnSaveGeneral.Text = "Save General Settings";
            this.btnSaveGeneral.UseVisualStyleBackColor = false;
            this.btnSaveGeneral.Click += new System.EventHandler(this.btnSaveGeneral_Click);
            // 
            // chkAutoBackup
            // 
            this.chkAutoBackup.AutoSize = true;
            this.chkAutoBackup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAutoBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.chkAutoBackup.Location = new System.Drawing.Point(23, 70);
            this.chkAutoBackup.Name = "chkAutoBackup";
            this.chkAutoBackup.Size = new System.Drawing.Size(185, 27);
            this.chkAutoBackup.TabIndex = 6;
            this.chkAutoBackup.Text = "Enable Auto Backup";
            this.chkAutoBackup.UseVisualStyleBackColor = true;
            // 
            // tabPageRestaurant
            // 
            this.tabPageRestaurant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.tabPageRestaurant.Controls.Add(this.btnSaveRestaurant);
            this.tabPageRestaurant.Controls.Add(this.numTax);
            this.tabPageRestaurant.Controls.Add(this.lblTax);
            this.tabPageRestaurant.Controls.Add(this.txtEmail);
            this.tabPageRestaurant.Controls.Add(this.lblEmail);
            this.tabPageRestaurant.Controls.Add(this.txtPhone);
            this.tabPageRestaurant.Controls.Add(this.lblPhone);
            this.tabPageRestaurant.Controls.Add(this.txtAddress);
            this.tabPageRestaurant.Controls.Add(this.lblAddress);
            this.tabPageRestaurant.Controls.Add(this.txtRestaurantName);
            this.tabPageRestaurant.Controls.Add(this.lblRestaurantName);
            this.tabPageRestaurant.Location = new System.Drawing.Point(4, 46);
            this.tabPageRestaurant.Name = "tabPageRestaurant";
            this.tabPageRestaurant.Padding = new System.Windows.Forms.Padding(20);
            this.tabPageRestaurant.Size = new System.Drawing.Size(1046, 530);
            this.tabPageRestaurant.TabIndex = 1;
            this.tabPageRestaurant.Text = "Restaurant Info";
            // 
            // btnSaveRestaurant
            // 
            this.btnSaveRestaurant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(40)))));
            this.btnSaveRestaurant.FlatAppearance.BorderSize = 0;
            this.btnSaveRestaurant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.btnSaveRestaurant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            this.btnSaveRestaurant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRestaurant.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnSaveRestaurant.ForeColor = System.Drawing.Color.White;
            this.btnSaveRestaurant.Location = new System.Drawing.Point(23, 450);
            this.btnSaveRestaurant.Name = "btnSaveRestaurant";
            this.btnSaveRestaurant.Size = new System.Drawing.Size(250, 45);
            this.btnSaveRestaurant.TabIndex = 10;
            this.btnSaveRestaurant.Text = "Save Restaurant Info";
            this.btnSaveRestaurant.UseVisualStyleBackColor = false;
            this.btnSaveRestaurant.Click += new System.EventHandler(this.btnSaveRestaurant_Click);
            // 
            // numTax
            // 
            this.numTax.DecimalPlaces = 2;
            this.numTax.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numTax.Location = new System.Drawing.Point(23, 390);
            this.numTax.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numTax.Name = "numTax";
            this.numTax.Size = new System.Drawing.Size(150, 30);
            this.numTax.TabIndex = 9;
            this.numTax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblTax.Location = new System.Drawing.Point(20, 360);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(117, 25);
            this.lblTax.TabIndex = 8;
            this.lblTax.Text = "Tax Rate (%)";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(23, 320);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 30);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Text = "info@greenleafrestaurant.com";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblEmail.Location = new System.Drawing.Point(20, 290);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 25);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(23, 250);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 30);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.Text = "+1 (555) 123-4567";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblPhone.Location = new System.Drawing.Point(20, 220);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(142, 25);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone Number";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.Location = new System.Drawing.Point(23, 180);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(400, 30);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "123 Green Street, City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblAddress.Location = new System.Drawing.Point(20, 150);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 25);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // txtRestaurantName
            // 
            this.txtRestaurantName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRestaurantName.Location = new System.Drawing.Point(23, 110);
            this.txtRestaurantName.Name = "txtRestaurantName";
            this.txtRestaurantName.Size = new System.Drawing.Size(400, 30);
            this.txtRestaurantName.TabIndex = 1;
            this.txtRestaurantName.Text = "Green Leaf Restaurant";
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblRestaurantName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblRestaurantName.Location = new System.Drawing.Point(20, 80);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(161, 25);
            this.lblRestaurantName.TabIndex = 0;
            this.lblRestaurantName.Text = "Restaurant Name";
            // 
            // tabPagePOS
            // 
            this.tabPagePOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.tabPagePOS.Controls.Add(this.btnSavePOS);
            this.tabPagePOS.Controls.Add(this.chkAskTable);
            this.tabPagePOS.Controls.Add(this.chkShowPreview);
            this.tabPagePOS.Controls.Add(this.chkPrintAuto);
            this.tabPagePOS.Controls.Add(this.txtFooter);
            this.tabPagePOS.Controls.Add(this.lblFooter);
            this.tabPagePOS.Controls.Add(this.txtHeader);
            this.tabPagePOS.Controls.Add(this.lblHeader);
            this.tabPagePOS.Location = new System.Drawing.Point(4, 46);
            this.tabPagePOS.Name = "tabPagePOS";
            this.tabPagePOS.Padding = new System.Windows.Forms.Padding(20);
            this.tabPagePOS.Size = new System.Drawing.Size(1046, 530);
            this.tabPagePOS.TabIndex = 2;
            this.tabPagePOS.Text = "POS";
            // 
            // btnSavePOS
            // 
            this.btnSavePOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(40)))));
            this.btnSavePOS.FlatAppearance.BorderSize = 0;
            this.btnSavePOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.btnSavePOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            this.btnSavePOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePOS.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnSavePOS.ForeColor = System.Drawing.Color.White;
            this.btnSavePOS.Location = new System.Drawing.Point(23, 350);
            this.btnSavePOS.Name = "btnSavePOS";
            this.btnSavePOS.Size = new System.Drawing.Size(250, 45);
            this.btnSavePOS.TabIndex = 7;
            this.btnSavePOS.Text = "Save POS Settings";
            this.btnSavePOS.UseVisualStyleBackColor = false;
            this.btnSavePOS.Click += new System.EventHandler(this.btnSavePOS_Click);
            // 
            // chkAskTable
            // 
            this.chkAskTable.AutoSize = true;
            this.chkAskTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAskTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.chkAskTable.Location = new System.Drawing.Point(23, 300);
            this.chkAskTable.Name = "chkAskTable";
            this.chkAskTable.Size = new System.Drawing.Size(252, 27);
            this.chkAskTable.TabIndex = 6;
            this.chkAskTable.Text = "Always Ask for Table Number";
            this.chkAskTable.UseVisualStyleBackColor = true;
            // 
            // chkShowPreview
            // 
            this.chkShowPreview.AutoSize = true;
            this.chkShowPreview.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkShowPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.chkShowPreview.Location = new System.Drawing.Point(23, 270);
            this.chkShowPreview.Name = "chkShowPreview";
            this.chkShowPreview.Size = new System.Drawing.Size(231, 27);
            this.chkShowPreview.TabIndex = 5;
            this.chkShowPreview.Text = "Show Preview Before Print";
            this.chkShowPreview.UseVisualStyleBackColor = true;
            // 
            // chkPrintAuto
            // 
            this.chkPrintAuto.AutoSize = true;
            this.chkPrintAuto.Checked = true;
            this.chkPrintAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrintAuto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkPrintAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.chkPrintAuto.Location = new System.Drawing.Point(23, 240);
            this.chkPrintAuto.Name = "chkPrintAuto";
            this.chkPrintAuto.Size = new System.Drawing.Size(171, 27);
            this.chkPrintAuto.TabIndex = 4;
            this.chkPrintAuto.Text = "Auto Print Receipt";
            this.chkPrintAuto.UseVisualStyleBackColor = true;
            // 
            // txtFooter
            // 
            this.txtFooter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFooter.Location = new System.Drawing.Point(23, 190);
            this.txtFooter.Name = "txtFooter";
            this.txtFooter.Size = new System.Drawing.Size(400, 30);
            this.txtFooter.TabIndex = 3;
            this.txtFooter.Text = "Visit us again soon!";
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblFooter.Location = new System.Drawing.Point(20, 160);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(176, 25);
            this.lblFooter.TabIndex = 2;
            this.lblFooter.Text = "Receipt Footer Text";
            // 
            // txtHeader
            // 
            this.txtHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHeader.Location = new System.Drawing.Point(23, 110);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(400, 30);
            this.txtHeader.TabIndex = 1;
            this.txtHeader.Text = "Thank you for dining with us!";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblHeader.Location = new System.Drawing.Point(20, 80);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(182, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Receipt Header Text";
            // 
            // tabPagePrinter
            // 
            this.tabPagePrinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.tabPagePrinter.Controls.Add(this.btnSavePrinter);
            this.tabPagePrinter.Controls.Add(this.btnTestPrint);
            this.tabPagePrinter.Controls.Add(this.comboPaper);
            this.tabPagePrinter.Controls.Add(this.lblPaper);
            this.tabPagePrinter.Controls.Add(this.comboPrinter);
            this.tabPagePrinter.Controls.Add(this.lblPrinter);
            this.tabPagePrinter.Location = new System.Drawing.Point(4, 46);
            this.tabPagePrinter.Name = "tabPagePrinter";
            this.tabPagePrinter.Padding = new System.Windows.Forms.Padding(20);
            this.tabPagePrinter.Size = new System.Drawing.Size(1046, 530);
            this.tabPagePrinter.TabIndex = 3;
            this.tabPagePrinter.Text = "Printer";
            // 
            // btnSavePrinter
            // 
            this.btnSavePrinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(40)))));
            this.btnSavePrinter.FlatAppearance.BorderSize = 0;
            this.btnSavePrinter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.btnSavePrinter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            this.btnSavePrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrinter.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnSavePrinter.ForeColor = System.Drawing.Color.White;
            this.btnSavePrinter.Location = new System.Drawing.Point(23, 250);
            this.btnSavePrinter.Name = "btnSavePrinter";
            this.btnSavePrinter.Size = new System.Drawing.Size(250, 45);
            this.btnSavePrinter.TabIndex = 5;
            this.btnSavePrinter.Text = "Save Printer Settings";
            this.btnSavePrinter.UseVisualStyleBackColor = false;
            this.btnSavePrinter.Click += new System.EventHandler(this.btnSavePrinter_Click);
            // 
            // btnTestPrint
            // 
            this.btnTestPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(220)))), ((int)(((byte)(100)))));
            this.btnTestPrint.FlatAppearance.BorderSize = 0;
            this.btnTestPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(240)))), ((int)(((byte)(120)))));
            this.btnTestPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
            this.btnTestPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnTestPrint.ForeColor = System.Drawing.Color.White;
            this.btnTestPrint.Location = new System.Drawing.Point(23, 190);
            this.btnTestPrint.Name = "btnTestPrint";
            this.btnTestPrint.Size = new System.Drawing.Size(200, 45);
            this.btnTestPrint.TabIndex = 4;
            this.btnTestPrint.Text = "Test Print";
            this.btnTestPrint.UseVisualStyleBackColor = false;
            this.btnTestPrint.Click += new System.EventHandler(this.btnTestPrint_Click);
            // 
            // comboPaper
            // 
            this.comboPaper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaper.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboPaper.FormattingEnabled = true;
            this.comboPaper.Items.AddRange(new object[] {
            "80mm",
            "58mm",
            "A4"});
            this.comboPaper.Location = new System.Drawing.Point(23, 140);
            this.comboPaper.Name = "comboPaper";
            this.comboPaper.Size = new System.Drawing.Size(250, 31);
            this.comboPaper.TabIndex = 3;
            // 
            // lblPaper
            // 
            this.lblPaper.AutoSize = true;
            this.lblPaper.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblPaper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblPaper.Location = new System.Drawing.Point(20, 110);
            this.lblPaper.Name = "lblPaper";
            this.lblPaper.Size = new System.Drawing.Size(99, 25);
            this.lblPaper.TabIndex = 2;
            this.lblPaper.Text = "Paper Size";
            // 
            // comboPrinter
            // 
            this.comboPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrinter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboPrinter.FormattingEnabled = true;
            this.comboPrinter.Items.AddRange(new object[] {
            "EPSON TM-T88V",
            "Citizen CT-S310",
            "Default Printer"});
            this.comboPrinter.Location = new System.Drawing.Point(23, 70);
            this.comboPrinter.Name = "comboPrinter";
            this.comboPrinter.Size = new System.Drawing.Size(300, 31);
            this.comboPrinter.TabIndex = 1;
            // 
            // lblPrinter
            // 
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblPrinter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblPrinter.Location = new System.Drawing.Point(20, 40);
            this.lblPrinter.Name = "lblPrinter";
            this.lblPrinter.Size = new System.Drawing.Size(126, 25);
            this.lblPrinter.TabIndex = 0;
            this.lblPrinter.Text = "Select Printer";
            // 
            // tabPageSecurity
            // 
            this.tabPageSecurity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.tabPageSecurity.Controls.Add(this.btnSaveSecurity);
            this.tabPageSecurity.Controls.Add(this.chkAuditLog);
            this.tabPageSecurity.Controls.Add(this.chkAutoLock);
            this.tabPageSecurity.Controls.Add(this.lblOptions);
            this.tabPageSecurity.Controls.Add(this.btnChangePass);
            this.tabPageSecurity.Controls.Add(this.txtConfirm);
            this.tabPageSecurity.Controls.Add(this.lblConfirm);
            this.tabPageSecurity.Controls.Add(this.txtNewPass);
            this.tabPageSecurity.Controls.Add(this.lblNewPass);
            this.tabPageSecurity.Controls.Add(this.txtCurrentPass);
            this.tabPageSecurity.Controls.Add(this.lblCurrentPass);
            this.tabPageSecurity.Controls.Add(this.lblPassTitle);
            this.tabPageSecurity.Location = new System.Drawing.Point(4, 46);
            this.tabPageSecurity.Name = "tabPageSecurity";
            this.tabPageSecurity.Padding = new System.Windows.Forms.Padding(20);
            this.tabPageSecurity.Size = new System.Drawing.Size(1046, 530);
            this.tabPageSecurity.TabIndex = 4;
            this.tabPageSecurity.Text = "Security";
            // 
            // btnSaveSecurity
            // 
            this.btnSaveSecurity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(40)))));
            this.btnSaveSecurity.FlatAppearance.BorderSize = 0;
            this.btnSaveSecurity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.btnSaveSecurity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            this.btnSaveSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSecurity.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnSaveSecurity.ForeColor = System.Drawing.Color.White;
            this.btnSaveSecurity.Location = new System.Drawing.Point(23, 450);
            this.btnSaveSecurity.Name = "btnSaveSecurity";
            this.btnSaveSecurity.Size = new System.Drawing.Size(250, 45);
            this.btnSaveSecurity.TabIndex = 11;
            this.btnSaveSecurity.Text = "Save Security Settings";
            this.btnSaveSecurity.UseVisualStyleBackColor = false;
            this.btnSaveSecurity.Click += new System.EventHandler(this.btnSaveSecurity_Click);
            // 
            // chkAuditLog
            // 
            this.chkAuditLog.AutoSize = true;
            this.chkAuditLog.Checked = true;
            this.chkAuditLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAuditLog.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAuditLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.chkAuditLog.Location = new System.Drawing.Point(23, 400);
            this.chkAuditLog.Name = "chkAuditLog";
            this.chkAuditLog.Size = new System.Drawing.Size(162, 27);
            this.chkAuditLog.TabIndex = 10;
            this.chkAuditLog.Text = "Enable Audit Log";
            this.chkAuditLog.UseVisualStyleBackColor = true;
            // 
            // chkAutoLock
            // 
            this.chkAutoLock.AutoSize = true;
            this.chkAutoLock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAutoLock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.chkAutoLock.Location = new System.Drawing.Point(23, 370);
            this.chkAutoLock.Name = "chkAutoLock";
            this.chkAutoLock.Size = new System.Drawing.Size(239, 27);
            this.chkAutoLock.TabIndex = 9;
            this.chkAutoLock.Text = "Auto Lock After 15 Minutes";
            this.chkAutoLock.UseVisualStyleBackColor = true;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblOptions.Location = new System.Drawing.Point(20, 340);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(162, 28);
            this.lblOptions.TabIndex = 8;
            this.lblOptions.Text = "Security Options";
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(40)))));
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.btnChangePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(23, 280);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(250, 45);
            this.btnChangePass.TabIndex = 7;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirm.Location = new System.Drawing.Point(23, 240);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '•';
            this.txtConfirm.Size = new System.Drawing.Size(300, 30);
            this.txtConfirm.TabIndex = 6;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblConfirm.Location = new System.Drawing.Point(20, 215);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(146, 23);
            this.lblConfirm.TabIndex = 5;
            this.lblConfirm.Text = "Confirm Password";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPass.Location = new System.Drawing.Point(23, 180);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '•';
            this.txtNewPass.Size = new System.Drawing.Size(300, 30);
            this.txtNewPass.TabIndex = 4;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblNewPass.Location = new System.Drawing.Point(20, 155);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(119, 23);
            this.lblNewPass.TabIndex = 3;
            this.lblNewPass.Text = "New Password";
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCurrentPass.Location = new System.Drawing.Point(23, 120);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.PasswordChar = '•';
            this.txtCurrentPass.Size = new System.Drawing.Size(300, 30);
            this.txtCurrentPass.TabIndex = 2;
            // 
            // lblCurrentPass
            // 
            this.lblCurrentPass.AutoSize = true;
            this.lblCurrentPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCurrentPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblCurrentPass.Location = new System.Drawing.Point(20, 95);
            this.lblCurrentPass.Name = "lblCurrentPass";
            this.lblCurrentPass.Size = new System.Drawing.Size(143, 23);
            this.lblCurrentPass.TabIndex = 1;
            this.lblCurrentPass.Text = "Current Password";
            // 
            // lblPassTitle
            // 
            this.lblPassTitle.AutoSize = true;
            this.lblPassTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblPassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblPassTitle.Location = new System.Drawing.Point(20, 40);
            this.lblPassTitle.Name = "lblPassTitle";
            this.lblPassTitle.Size = new System.Drawing.Size(238, 28);
            this.lblPassTitle.TabIndex = 0;
            this.lblPassTitle.Text = "Change Admin Password";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(318, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SYSTEM SETTINGS";
            // 
            // frmSettings
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.tabPageRestaurant.ResumeLayout(false);
            this.tabPageRestaurant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTax)).EndInit();
            this.tabPagePOS.ResumeLayout(false);
            this.tabPagePOS.PerformLayout();
            this.tabPagePrinter.ResumeLayout(false);
            this.tabPagePrinter.PerformLayout();
            this.tabPageSecurity.ResumeLayout(false);
            this.tabPageSecurity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageRestaurant;
        private System.Windows.Forms.TabPage tabPagePOS;
        private System.Windows.Forms.TabPage tabPagePrinter;
        private System.Windows.Forms.TabPage tabPageSecurity;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSaveGeneral;
        private System.Windows.Forms.CheckBox chkAutoBackup;
        private System.Windows.Forms.Button btnSaveRestaurant;
        private System.Windows.Forms.NumericUpDown numTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtRestaurantName;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.Button btnSavePOS;
        private System.Windows.Forms.CheckBox chkAskTable;
        private System.Windows.Forms.CheckBox chkShowPreview;
        private System.Windows.Forms.CheckBox chkPrintAuto;
        private System.Windows.Forms.TextBox txtFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnSavePrinter;
        private System.Windows.Forms.Button btnTestPrint;
        private System.Windows.Forms.ComboBox comboPaper;
        private System.Windows.Forms.Label lblPaper;
        private System.Windows.Forms.ComboBox comboPrinter;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Button btnSaveSecurity;
        private System.Windows.Forms.CheckBox chkAuditLog;
        private System.Windows.Forms.CheckBox chkAutoLock;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.Label lblCurrentPass;
        private System.Windows.Forms.Label lblPassTitle;
    }
}