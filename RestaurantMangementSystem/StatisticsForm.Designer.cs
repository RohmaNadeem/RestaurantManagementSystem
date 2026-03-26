using System.Windows.Forms.DataVisualization.Charting;
namespace RestaurantMangementSystem
{
    partial class StatisticsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStock;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.chartCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl.SuspendLayout();
            this.tabCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).BeginInit();
            this.tabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCategory);
            this.tabControl.Controls.Add(this.tabStock);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 500);
            this.tabControl.TabIndex = 0;
            // 
            // tabCategory
            // 
            this.tabCategory.Controls.Add(this.chartCategory);
            this.tabCategory.Location = new System.Drawing.Point(4, 24);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.Size = new System.Drawing.Size(792, 472);
            this.tabCategory.TabIndex = 0;
            this.tabCategory.Text = "Category Distribution";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // chartCategory
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCategory.ChartAreas.Add(chartArea1);
            this.chartCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartCategory.Legends.Add(legend1);
            this.chartCategory.Location = new System.Drawing.Point(3, 3);
            this.chartCategory.Name = "chartCategory";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Products";
            this.chartCategory.Series.Add(series1);
            this.chartCategory.Size = new System.Drawing.Size(786, 466);
            this.chartCategory.TabIndex = 0;
            this.chartCategory.Text = "chart1";
            // 
            // tabStock
            // 
            this.tabStock.Controls.Add(this.chartStock);
            this.tabStock.Location = new System.Drawing.Point(4, 24);
            this.tabStock.Name = "tabStock";
            this.tabStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabStock.Size = new System.Drawing.Size(792, 472);
            this.tabStock.TabIndex = 1;
            this.tabStock.Text = "Stock Levels";
            this.tabStock.UseVisualStyleBackColor = true;
            // 
            // chartStock
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStock.ChartAreas.Add(chartArea2);
            this.chartStock.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartStock.Legends.Add(legend2);
            this.chartStock.Location = new System.Drawing.Point(3, 3);
            this.chartStock.Name = "chartStock";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Stock";
            this.chartStock.Series.Add(series2);
            this.chartStock.Size = new System.Drawing.Size(786, 466);
            this.chartStock.TabIndex = 0;
            this.chartStock.Text = "chart2";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tabControl);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Statistics";
            this.tabControl.ResumeLayout(false);
            this.tabCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).EndInit();
            this.tabStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).EndInit();
            this.ResumeLayout(false);
        }
    }
}