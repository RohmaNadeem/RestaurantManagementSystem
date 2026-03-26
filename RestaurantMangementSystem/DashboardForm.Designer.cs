namespace RestaurantMangementSystem
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.chartIncomeExpense = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.pnlAvailable = new System.Windows.Forms.Panel();
            this.lblOtherTotal = new System.Windows.Forms.Label();
            this.lblClothesTotal = new System.Windows.Forms.Label();
            this.lblFoodTotal = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.lblClothes = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.lblTotalExpensesValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartRevenueFlow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCategoryPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTopCards = new System.Windows.Forms.Panel();
            this.pnlExpense = new System.Windows.Forms.Panel();
            this.lblExpenseChange = new System.Windows.Forms.Label();
            this.lblExpenseTitle = new System.Windows.Forms.Label();
            this.pnlIncome = new System.Windows.Forms.Panel();
            this.lblIncomeChange = new System.Windows.Forms.Label();
            this.lblIncomeTitle = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.tabDineIn = new System.Windows.Forms.TabPage();
            this.tabTakeaway = new System.Windows.Forms.TabPage();
            this.tabDelivery = new System.Windows.Forms.TabPage();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncomeExpense)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            this.pnlAvailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenueFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoryPie)).BeginInit();
            this.pnlTopCards.SuspendLayout();
            this.pnlExpense.SuspendLayout();
            this.pnlIncome.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Controls.Add(this.pnlMiddle);
            this.pnlMain.Controls.Add(this.pnlTopCards);
            this.pnlMain.Controls.Add(this.tabControl);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(1000, 650);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.chartIncomeExpense);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(10, 380);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(980, 260);
            this.pnlBottom.TabIndex = 4;
            // 
            // chartIncomeExpense
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chartIncomeExpense.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Segoe UI", 8F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartIncomeExpense.Legends.Add(legend1);
            this.chartIncomeExpense.Location = new System.Drawing.Point(20, 10);
            this.chartIncomeExpense.Name = "chartIncomeExpense";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            series1.Legend = "Legend1";
            series1.Name = "Income";
            this.chartIncomeExpense.Series.Add(series1);
            this.chartIncomeExpense.Size = new System.Drawing.Size(940, 240);
            this.chartIncomeExpense.TabIndex = 1;
            this.chartIncomeExpense.Text = "chart2";
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.pnlAvailable);
            this.pnlMiddle.Controls.Add(this.chartRevenueFlow);
            this.pnlMiddle.Controls.Add(this.chartCategoryPie);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddle.Location = new System.Drawing.Point(10, 160);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(980, 220);
            this.pnlMiddle.TabIndex = 3;
            // 
            // pnlAvailable
            // 
            this.pnlAvailable.BackColor = System.Drawing.Color.White;
            this.pnlAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAvailable.Controls.Add(this.lblOtherTotal);
            this.pnlAvailable.Controls.Add(this.lblClothesTotal);
            this.pnlAvailable.Controls.Add(this.lblFoodTotal);
            this.pnlAvailable.Controls.Add(this.lblOther);
            this.pnlAvailable.Controls.Add(this.lblClothes);
            this.pnlAvailable.Controls.Add(this.lblFood);
            this.pnlAvailable.Controls.Add(this.lblTotalExpenses);
            this.pnlAvailable.Controls.Add(this.lblTotalExpensesValue);
            this.pnlAvailable.Controls.Add(this.label2);
            this.pnlAvailable.Location = new System.Drawing.Point(750, 10);
            this.pnlAvailable.Name = "pnlAvailable";
            this.pnlAvailable.Size = new System.Drawing.Size(220, 200);
            this.pnlAvailable.TabIndex = 2;
            // 
            // lblOtherTotal
            // 
            this.lblOtherTotal.AutoSize = true;
            this.lblOtherTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOtherTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(104)))), ((int)(((byte)(80)))));
            this.lblOtherTotal.Location = new System.Drawing.Point(130, 100);
            this.lblOtherTotal.Name = "lblOtherTotal";
            this.lblOtherTotal.Size = new System.Drawing.Size(35, 15);
            this.lblOtherTotal.TabIndex = 8;
            this.lblOtherTotal.Text = "$480";
            // 
            // lblClothesTotal
            // 
            this.lblClothesTotal.AutoSize = true;
            this.lblClothesTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblClothesTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(104)))), ((int)(((byte)(80)))));
            this.lblClothesTotal.Location = new System.Drawing.Point(130, 68);
            this.lblClothesTotal.Name = "lblClothesTotal";
            this.lblClothesTotal.Size = new System.Drawing.Size(35, 15);
            this.lblClothesTotal.TabIndex = 7;
            this.lblClothesTotal.Text = "$420";
            // 
            // lblFoodTotal
            // 
            this.lblFoodTotal.AutoSize = true;
            this.lblFoodTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFoodTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(104)))), ((int)(((byte)(80)))));
            this.lblFoodTotal.Location = new System.Drawing.Point(130, 36);
            this.lblFoodTotal.Name = "lblFoodTotal";
            this.lblFoodTotal.Size = new System.Drawing.Size(35, 15);
            this.lblFoodTotal.TabIndex = 6;
            this.lblFoodTotal.Text = "$950";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblOther.Location = new System.Drawing.Point(15, 100);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(40, 15);
            this.lblOther.TabIndex = 5;
            this.lblOther.Text = "Other:";
            // 
            // lblClothes
            // 
            this.lblClothes.AutoSize = true;
            this.lblClothes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblClothes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblClothes.Location = new System.Drawing.Point(15, 68);
            this.lblClothes.Name = "lblClothes";
            this.lblClothes.Size = new System.Drawing.Size(63, 15);
            this.lblClothes.TabIndex = 4;
            this.lblClothes.Text = "Beverages:";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblFood.Location = new System.Drawing.Point(15, 36);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(37, 15);
            this.lblFood.TabIndex = 3;
            this.lblFood.Text = "Food:";
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalExpenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblTotalExpenses.Location = new System.Drawing.Point(15, 150);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(111, 19);
            this.lblTotalExpenses.TabIndex = 2;
            this.lblTotalExpenses.Text = "Total Inventory";
            // 
            // lblTotalExpensesValue
            // 
            this.lblTotalExpensesValue.AutoSize = true;
            this.lblTotalExpensesValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalExpensesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.lblTotalExpensesValue.Location = new System.Drawing.Point(130, 145);
            this.lblTotalExpensesValue.Name = "lblTotalExpensesValue";
            this.lblTotalExpensesValue.Size = new System.Drawing.Size(55, 21);
            this.lblTotalExpensesValue.TabIndex = 1;
            this.lblTotalExpensesValue.Text = "$1750";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Available";
            // 
            // chartRevenueFlow
            // 
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chartRevenueFlow.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartRevenueFlow.Legends.Add(legend2);
            this.chartRevenueFlow.Location = new System.Drawing.Point(20, 10);
            this.chartRevenueFlow.Name = "chartRevenueFlow";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            series2.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            series2.MarkerSize = 6;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Revenue";
            this.chartRevenueFlow.Series.Add(series2);
            this.chartRevenueFlow.Size = new System.Drawing.Size(330, 200);
            this.chartRevenueFlow.TabIndex = 0;
            this.chartRevenueFlow.Text = "Revenue Flow";
            // 
            // chartCategoryPie
            // 
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Name = "ChartArea1";
            this.chartCategoryPie.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Font = new System.Drawing.Font("Segoe UI", 8F);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chartCategoryPie.Legends.Add(legend3);
            this.chartCategoryPie.Location = new System.Drawing.Point(370, 10);
            this.chartCategoryPie.Name = "chartCategoryPie";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Categories";
            this.chartCategoryPie.Series.Add(series3);
            this.chartCategoryPie.Size = new System.Drawing.Size(360, 200);
            this.chartCategoryPie.TabIndex = 3;
            this.chartCategoryPie.Text = "Expense Breakdown";
            // 
            // pnlTopCards
            // 
            this.pnlTopCards.Controls.Add(this.pnlExpense);
            this.pnlTopCards.Controls.Add(this.pnlIncome);
            this.pnlTopCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopCards.Location = new System.Drawing.Point(10, 90);
            this.pnlTopCards.Name = "pnlTopCards";
            this.pnlTopCards.Size = new System.Drawing.Size(980, 70);
            this.pnlTopCards.TabIndex = 2;
            // 
            // pnlExpense
            // 
            this.pnlExpense.BackColor = System.Drawing.Color.White;
            this.pnlExpense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExpense.Controls.Add(this.lblExpenseChange);
            this.pnlExpense.Controls.Add(this.lblExpenseTitle);
            this.pnlExpense.Location = new System.Drawing.Point(240, 8);
            this.pnlExpense.Name = "pnlExpense";
            this.pnlExpense.Size = new System.Drawing.Size(200, 55);
            this.pnlExpense.TabIndex = 1;
            // 
            // lblExpenseChange
            // 
            this.lblExpenseChange.AutoSize = true;
            this.lblExpenseChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblExpenseChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblExpenseChange.Location = new System.Drawing.Point(10, 22);
            this.lblExpenseChange.Name = "lblExpenseChange";
            this.lblExpenseChange.Size = new System.Drawing.Size(39, 21);
            this.lblExpenseChange.TabIndex = 1;
            this.lblExpenseChange.Text = "-9%";
            // 
            // lblExpenseTitle
            // 
            this.lblExpenseTitle.AutoSize = true;
            this.lblExpenseTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblExpenseTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblExpenseTitle.Location = new System.Drawing.Point(10, 5);
            this.lblExpenseTitle.Name = "lblExpenseTitle";
            this.lblExpenseTitle.Size = new System.Drawing.Size(112, 15);
            this.lblExpenseTitle.TabIndex = 0;
            this.lblExpenseTitle.Text = "This week\'s expense";
            // 
            // pnlIncome
            // 
            this.pnlIncome.BackColor = System.Drawing.Color.White;
            this.pnlIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIncome.Controls.Add(this.lblIncomeChange);
            this.pnlIncome.Controls.Add(this.lblIncomeTitle);
            this.pnlIncome.Location = new System.Drawing.Point(20, 8);
            this.pnlIncome.Name = "pnlIncome";
            this.pnlIncome.Size = new System.Drawing.Size(200, 55);
            this.pnlIncome.TabIndex = 0;
            // 
            // lblIncomeChange
            // 
            this.lblIncomeChange.AutoSize = true;
            this.lblIncomeChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblIncomeChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.lblIncomeChange.Location = new System.Drawing.Point(10, 22);
            this.lblIncomeChange.Name = "lblIncomeChange";
            this.lblIncomeChange.Size = new System.Drawing.Size(53, 21);
            this.lblIncomeChange.TabIndex = 1;
            this.lblIncomeChange.Text = "+12%";
            // 
            // lblIncomeTitle
            // 
            this.lblIncomeTitle.AutoSize = true;
            this.lblIncomeTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIncomeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblIncomeTitle.Location = new System.Drawing.Point(10, 5);
            this.lblIncomeTitle.Name = "lblIncomeTitle";
            this.lblIncomeTitle.Size = new System.Drawing.Size(110, 15);
            this.lblIncomeTitle.TabIndex = 0;
            this.lblIncomeTitle.Text = "This week\'s income";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAll);
            this.tabControl.Controls.Add(this.tabDineIn);
            this.tabControl.Controls.Add(this.tabTakeaway);
            this.tabControl.Controls.Add(this.tabDelivery);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl.Location = new System.Drawing.Point(10, 55);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(980, 35);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabAll
            // 
            this.tabAll.Location = new System.Drawing.Point(4, 24);
            this.tabAll.Name = "tabAll";
            this.tabAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabAll.Size = new System.Drawing.Size(972, 7);
            this.tabAll.TabIndex = 0;
            this.tabAll.Text = "All";
            this.tabAll.UseVisualStyleBackColor = true;
            // 
            // tabDineIn
            // 
            this.tabDineIn.Location = new System.Drawing.Point(4, 24);
            this.tabDineIn.Name = "tabDineIn";
            this.tabDineIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabDineIn.Size = new System.Drawing.Size(972, 7);
            this.tabDineIn.TabIndex = 1;
            this.tabDineIn.Text = "Dine‑in";
            this.tabDineIn.UseVisualStyleBackColor = true;
            // 
            // tabTakeaway
            // 
            this.tabTakeaway.Location = new System.Drawing.Point(4, 24);
            this.tabTakeaway.Name = "tabTakeaway";
            this.tabTakeaway.Padding = new System.Windows.Forms.Padding(3);
            this.tabTakeaway.Size = new System.Drawing.Size(972, 7);
            this.tabTakeaway.TabIndex = 2;
            this.tabTakeaway.Text = "Takeaway";
            this.tabTakeaway.UseVisualStyleBackColor = true;
            // 
            // tabDelivery
            // 
            this.tabDelivery.Location = new System.Drawing.Point(4, 24);
            this.tabDelivery.Name = "tabDelivery";
            this.tabDelivery.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelivery.Size = new System.Drawing.Size(972, 7);
            this.tabDelivery.TabIndex = 3;
            this.tabDelivery.Text = "Delivery";
            this.tabDelivery.UseVisualStyleBackColor = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(980, 45);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Dashboard";
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 30000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartIncomeExpense)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            this.pnlAvailable.ResumeLayout(false);
            this.pnlAvailable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenueFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoryPie)).EndInit();
            this.pnlTopCards.ResumeLayout(false);
            this.pnlExpense.ResumeLayout(false);
            this.pnlExpense.PerformLayout();
            this.pnlIncome.ResumeLayout(false);
            this.pnlIncome.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAll;
        private System.Windows.Forms.TabPage tabDineIn;
        private System.Windows.Forms.TabPage tabTakeaway;
        private System.Windows.Forms.TabPage tabDelivery;
        private System.Windows.Forms.Panel pnlTopCards;
        private System.Windows.Forms.Panel pnlIncome;
        private System.Windows.Forms.Label lblIncomeTitle;
        private System.Windows.Forms.Label lblIncomeChange;
        private System.Windows.Forms.Panel pnlExpense;
        private System.Windows.Forms.Label lblExpenseChange;
        private System.Windows.Forms.Label lblExpenseTitle;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenueFlow;
        private System.Windows.Forms.Panel pnlAvailable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalExpensesValue;
        private System.Windows.Forms.Label lblTotalExpenses;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblClothes;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label lblOtherTotal;
        private System.Windows.Forms.Label lblClothesTotal;
        private System.Windows.Forms.Label lblFoodTotal;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncomeExpense;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategoryPie;
    }
}