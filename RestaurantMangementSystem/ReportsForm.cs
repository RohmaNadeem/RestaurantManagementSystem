using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantMangementSystem
{
    public partial class ReportsForm : Form
    {
        // Color Scheme
        private readonly Color primaryColor = Color.FromArgb(18, 36, 25);
        private readonly Color secondaryColor = Color.FromArgb(52, 104, 80);
        private readonly Color accentColor = Color.FromArgb(56, 142, 60);
        private readonly Color lightGray = Color.FromArgb(240, 240, 240);

        private DateTime startDate = DateTime.Today.AddDays(-7);
        private DateTime endDate = DateTime.Today;

        // Print fields
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

        public ReportsForm()
        {
            InitializeComponent();
            SetupDatePickers();
            SetupPrinting();
            EnsureDataGridColumns(); // Add missing columns if designer didn't create them
            LoadReports();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void EnsureDataGridColumns()
        {
            // Ensure Sales DataGridView has columns
            if (dgvSales.Columns.Count == 0)
            {
                dgvSales.Columns.Add("colDate", "Date");
                dgvSales.Columns.Add("colOrders", "Orders");
                dgvSales.Columns.Add("colTotalSales", "Total Sales");
                dgvSales.Columns.Add("colAverageOrder", "Average Order");
                dgvSales.Columns[2].DefaultCellStyle.Format = "C2";
            }

            // Ensure Popular Items DataGridView has columns
            if (dgvPopularItems.Columns.Count == 0)
            {
                dgvPopularItems.Columns.Add("colRank", "Rank");
                dgvPopularItems.Columns.Add("colProductName", "Product Name");
                dgvPopularItems.Columns.Add("colQuantitySold", "Quantity Sold");
                dgvPopularItems.Columns.Add("colRevenue", "Revenue");
                dgvPopularItems.Columns[3].DefaultCellStyle.Format = "C2";
            }

            // Ensure Order Types DataGridView has columns
            if (dgvOrderTypes.Columns.Count == 0)
            {
                dgvOrderTypes.Columns.Add("colOrderType", "Order Type");
                dgvOrderTypes.Columns.Add("colTypeCount", "Count");
                dgvOrderTypes.Columns.Add("colPercentage", "Percentage");
                dgvOrderTypes.Columns.Add("colTypeRevenue", "Revenue");
                dgvOrderTypes.Columns[3].DefaultCellStyle.Format = "C2";
            }
        }

        private void SetupPrinting()
        {
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            printPreviewDialog.Document = printDocument;
        }

        private void SetupDatePickers()
        {
            dtpStartDate.Value = startDate;
            dtpEndDate.Value = endDate;
            dtpStartDate.MaxDate = DateTime.Today;
            dtpEndDate.MaxDate = DateTime.Today;
        }

        private void LoadReports()
        {
            try
            {
                var orders = OrderStorage.GetAllOrders();
                FilterOrdersByDate(orders);
                UpdateSummaryCards();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reports: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterOrdersByDate(List<Order> orders)
        {
            // Filter orders within date range and only paid orders
            var filteredOrders = orders
                .Where(o => o.OrderDate.Date >= startDate.Date &&
                           o.OrderDate.Date <= endDate.Date &&
                           o.IsPaid)
                .ToList();

            if (filteredOrders.Count == 0)
            {
                MessageBox.Show($"No orders found between {startDate:yyyy-MM-dd} and {endDate:yyyy-MM-dd}.",
                    "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DisplaySalesData(filteredOrders);
            DisplayPopularItems(filteredOrders);
            DisplayOrderTypes(filteredOrders);
        }

        private void DisplaySalesData(List<Order> orders)
        {
            // Unbind any data source
            dgvSales.DataSource = null;
            dgvSales.Rows.Clear();

            // Group by date
            var dailySales = orders
                .GroupBy(o => o.OrderDate.Date)
                .Select(g => new DailySales
                {
                    Date = g.Key,
                    OrdersCount = g.Count(),
                    TotalSales = g.Sum(o => o.Total),
                    AverageOrder = g.Average(o => o.Total)
                })
                .OrderBy(x => x.Date)
                .ToList();

            foreach (var day in dailySales)
            {
                dgvSales.Rows.Add(
                    day.Date.ToString("yyyy-MM-dd"),
                    day.OrdersCount,
                    day.TotalSales,
                    day.AverageOrder
                );
            }
        }

        private void DisplayPopularItems(List<Order> orders)
        {
            dgvPopularItems.DataSource = null;
            dgvPopularItems.Rows.Clear();

            // Get all items from all orders
            var allItems = orders.SelectMany(o => o.Items).ToList();

            // Group by product and sum quantities
            var popularItems = allItems
                .GroupBy(i => i.ProductName)
                .Select(g => new PopularItem
                {
                    ProductName = g.Key,
                    QuantitySold = g.Sum(i => i.Quantity),
                    Revenue = g.Sum(i => i.TotalPrice)
                })
                .OrderByDescending(x => x.QuantitySold)
                .Take(10) // Top 10 items
                .ToList();

            int rank = 1;
            foreach (var item in popularItems)
            {
                dgvPopularItems.Rows.Add(
                    rank++,
                    item.ProductName,
                    item.QuantitySold,
                    item.Revenue
                );
            }
        }

        private void DisplayOrderTypes(List<Order> orders)
        {
            dgvOrderTypes.DataSource = null;
            dgvOrderTypes.Rows.Clear();

            if (orders.Count == 0) return;

            // Group by order type
            var orderTypeSummary = orders
                .GroupBy(o => o.Type)
                .Select(g => new OrderTypeSummary
                {
                    Type = g.Key.ToString(),
                    Count = g.Count(),
                    Percentage = (g.Count() * 100.0) / orders.Count,
                    Revenue = g.Sum(o => o.Total)
                })
                .OrderByDescending(x => x.Count)
                .ToList();

            foreach (var type in orderTypeSummary)
            {
                dgvOrderTypes.Rows.Add(
                    type.Type,
                    type.Count,
                    $"{type.Percentage:F1}%",
                    type.Revenue
                );
            }
        }

        private void UpdateSummaryCards()
        {
            var orders = OrderStorage.GetAllOrders()
                .Where(o => o.OrderDate.Date >= startDate.Date &&
                           o.OrderDate.Date <= endDate.Date &&
                           o.IsPaid)
                .ToList();

            // Total Revenue
            decimal totalRevenue = orders.Sum(o => o.Total);
            lblTotalRevenue.Text = totalRevenue.ToString("C2");

            // Total Orders
            int totalOrders = orders.Count;
            lblTotalOrders.Text = totalOrders.ToString();

            // Average Order Value
            decimal avgOrderValue = totalOrders > 0 ? totalRevenue / totalOrders : 0;
            lblAvgOrderValue.Text = avgOrderValue.ToString("C2");

            // Most Popular Item
            var popularItem = orders
                .SelectMany(o => o.Items)
                .GroupBy(i => i.ProductName)
                .Select(g => new { Product = g.Key, Quantity = g.Sum(i => i.Quantity) })
                .OrderByDescending(x => x.Quantity)
                .FirstOrDefault();

            if (popularItem != null)
                lblPopularItem.Text = $"{popularItem.Product} ({popularItem.Quantity} sold)";
            else
                lblPopularItem.Text = "No data";
        }

        // Helper classes
        private class DailySales
        {
            public DateTime Date { get; set; }
            public int OrdersCount { get; set; }
            public decimal TotalSales { get; set; }
            public decimal AverageOrder { get; set; }
        }

        private class PopularItem
        {
            public string ProductName { get; set; }
            public int QuantitySold { get; set; }
            public decimal Revenue { get; set; }
        }

        private class OrderTypeSummary
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public double Percentage { get; set; }
            public decimal Revenue { get; set; }
        }

        // ========== EVENT HANDLERS ==========
        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                startDate = dtpStartDate.Value;
                endDate = dtpEndDate.Value;

                if (startDate > endDate)
                {
                    MessageBox.Show("Start date cannot be after end date!", "Invalid Date",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Refresh all report data
                LoadReports();

                // Ask user where to save the PDF
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveDialog.Title = "Save Report as PDF";
                    saveDialog.FileName = $"Sales_Report_{startDate:yyyyMMdd}_to_{endDate:yyyyMMdd}.pdf";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Set up printing to PDF
                        printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                        printDocument.PrinterSettings.PrintToFile = true;
                        printDocument.PrinterSettings.PrintFileName = saveDialog.FileName;

                        // Print the document (which will generate the PDF)
                        printDocument.Print();

                        MessageBox.Show($"Report saved successfully as PDF:\n{saveDialog.FileName}",
                            "PDF Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "CSV Files (*.csv)|*.csv";
                saveDialog.Title = "Export Report";
                saveDialog.FileName = $"Sales_Report_{DateTime.Now:yyyyMMdd}";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToCSV(saveDialog.FileName);
                    MessageBox.Show("Report exported successfully!", "Export Complete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ExportToCSV(string filePath)
        {
            try
            {
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath))
                {
                    // Header
                    writer.WriteLine("Sales Report");
                    writer.WriteLine($"Date Range: {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}");
                    writer.WriteLine($"Generated: {DateTime.Now:yyyy-MM-dd HH:mm}");
                    writer.WriteLine();

                    // Summary
                    writer.WriteLine("SUMMARY");
                    writer.WriteLine($"Total Revenue,{lblTotalRevenue.Text}");
                    writer.WriteLine($"Total Orders,{lblTotalOrders.Text}");
                    writer.WriteLine($"Average Order Value,{lblAvgOrderValue.Text}");
                    writer.WriteLine($"Most Popular,{lblPopularItem.Text}");
                    writer.WriteLine();

                    // Daily Sales
                    writer.WriteLine("DAILY SALES");
                    writer.WriteLine("Date,Orders,Total Sales,Average Order");
                    foreach (DataGridViewRow row in dgvSales.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            writer.WriteLine($"{row.Cells[0].Value},{row.Cells[1].Value},{row.Cells[2].Value},{row.Cells[3].Value}");
                        }
                    }
                    writer.WriteLine();

                    // Popular Items
                    writer.WriteLine("TOP SELLING ITEMS");
                    writer.WriteLine("Rank,Product,Quantity Sold,Revenue");
                    foreach (DataGridViewRow row in dgvPopularItems.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            writer.WriteLine($"{row.Cells[0].Value},{row.Cells[1].Value},{row.Cells[2].Value},{row.Cells[3].Value}");
                        }
                    }
                    writer.WriteLine();

                    // Order Types
                    writer.WriteLine("ORDER TYPE DISTRIBUTION");
                    writer.WriteLine("Type,Count,Percentage,Revenue");
                    foreach (DataGridViewRow row in dgvOrderTypes.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            writer.WriteLine($"{row.Cells[0].Value},{row.Cells[1].Value},{row.Cells[2].Value},{row.Cells[3].Value}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting CSV: {ex.Message}", "Export Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float yPos = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float lineHeight = new Font("Segoe UI", 10).GetHeight(g);

            // Title
            string title = "RESTAURANT SALES REPORT";
            Font titleFont = new Font("Segoe UI", 14, FontStyle.Bold);
            g.DrawString(title, titleFont, Brushes.Black, leftMargin, topMargin);
            yPos = topMargin + lineHeight * 2;

            // Date Range
            string dateRange = $"Date Range: {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}";
            g.DrawString(dateRange, new Font("Segoe UI", 10), Brushes.Black, leftMargin, yPos);
            yPos += lineHeight * 2;

            // Summary
            g.DrawString("SUMMARY", new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, leftMargin, yPos);
            yPos += lineHeight * 1.5f;

            g.DrawString($"Total Revenue: {lblTotalRevenue.Text}", new Font("Segoe UI", 10), Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            g.DrawString($"Total Orders: {lblTotalOrders.Text}", new Font("Segoe UI", 10), Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            g.DrawString($"Average Order: {lblAvgOrderValue.Text}", new Font("Segoe UI", 10), Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            g.DrawString($"Most Popular: {lblPopularItem.Text}", new Font("Segoe UI", 10), Brushes.Black, leftMargin, yPos);
            yPos += lineHeight * 2;

            // Daily Sales
            g.DrawString("DAILY SALES", new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, leftMargin, yPos);
            yPos += lineHeight * 1.5f;

            string header = $"{"Date",-12} {"Orders",-8} {"Total Sales",-15} {"Average",-15}";
            g.DrawString(header, new Font("Segoe UI", 10, FontStyle.Bold), Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;

            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string line = $"{row.Cells[0].Value,-12} {row.Cells[1].Value,-8} {row.Cells[2].Value,-15} {row.Cells[3].Value,-15}";
                    g.DrawString(line, new Font("Segoe UI", 10), Brushes.Black, leftMargin, yPos);
                    yPos += lineHeight;
                }
            }
            e.HasMorePages = false;
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            BtnGenerateReport_Click(sender, e);
        }

        private void BtnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Today;
            BtnGenerateReport_Click(sender, e);
        }

        private void BtnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Today;
            BtnGenerateReport_Click(sender, e);
        }

        private void BtnLastMonth_Click(object sender, EventArgs e)
        {
            var firstDayOfLastMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1);
            var lastDayOfLastMonth = firstDayOfLastMonth.AddMonths(1).AddDays(-1);
            dtpStartDate.Value = firstDayOfLastMonth;
            dtpEndDate.Value = lastDayOfLastMonth;
            BtnGenerateReport_Click(sender, e);
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadReports();
        }

        // Unused event handlers (can be kept empty)
        private void label4_Click(object sender, EventArgs e) { }
        private void pnlSummary_Paint(object sender, PaintEventArgs e) { }
    }
}