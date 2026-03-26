using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RestaurantMangementSystem
{
    public partial class DashboardForm : Form
    {
        private List<Order> allOrders;
        private List<Order> filteredOrders;

        public DashboardForm()
        {
            InitializeComponent();
            tabControl.SelectedIndex = 0;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void LoadData()
        {
            // Get all paid orders (completed transactions)
            allOrders = OrderStorage.GetAllOrders().Where(o => o.IsPaid).ToList();
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string selectedTab = tabControl.SelectedTab.Text;

            switch (selectedTab)
            {
                case "All":
                    filteredOrders = allOrders;
                    break;
                case "Dine‑in":
                    filteredOrders = allOrders.Where(o => o.Type == OrderType.DineIn).ToList();
                    break;
                case "Takeaway":
                    filteredOrders = allOrders.Where(o => o.Type == OrderType.TakeAway).ToList();
                    break;
                case "Delivery":
                    filteredOrders = allOrders.Where(o => o.Type == OrderType.Delivery).ToList();
                    break;
                default:
                    filteredOrders = allOrders;
                    break;
            }

            UpdateDashboard();
        }

        private void UpdateDashboard()
        {
            try
            {
                DateTime today = DateTime.Today;
                DateTime weekAgo = today.AddDays(-7);
                DateTime lastWeekStart = weekAgo.AddDays(-7);
                DateTime lastWeekEnd = weekAgo.AddDays(-1);

                // ----- INCOME (this week vs last week) -----
                var thisWeekOrders = filteredOrders.Where(o => o.OrderDate >= weekAgo).ToList();
                var lastWeekOrders = filteredOrders.Where(o => o.OrderDate >= lastWeekStart && o.OrderDate <= lastWeekEnd).ToList();

                decimal thisWeekIncome = thisWeekOrders.Sum(o => o.Total);
                decimal lastWeekIncome = lastWeekOrders.Sum(o => o.Total);
                decimal incomeChange = lastWeekIncome == 0 ? 0 : ((thisWeekIncome - lastWeekIncome) / lastWeekIncome) * 100;
                lblIncomeChange.Text = $"{(incomeChange >= 0 ? "+" : "")}{incomeChange:F0}%";
                lblIncomeChange.ForeColor = incomeChange >= 0 ? Color.FromArgb(56, 142, 60) : Color.FromArgb(231, 76, 60);

                // ----- EXPENSE (approximated as 40% of revenue – replace with actual cost if available) -----
                decimal thisWeekExpense = thisWeekIncome * 0.4m;
                decimal lastWeekExpense = lastWeekIncome * 0.4m;
                decimal expenseChange = lastWeekExpense == 0 ? 0 : ((thisWeekExpense - lastWeekExpense) / lastWeekExpense) * 100;
                lblExpenseChange.Text = $"{(expenseChange >= 0 ? "+" : "")}{expenseChange:F0}%";
                lblExpenseChange.ForeColor = expenseChange >= 0 ? Color.FromArgb(231, 76, 60) : Color.FromArgb(56, 142, 60);

                // ----- REVENUE FLOW (last 6 months) -----
                var months = new[] { "Mar", "Apr", "May", "Jun", "Jul", "Aug" };
                var monthlyRevenue = new List<decimal>();
                for (int i = 5; i >= 0; i--)
                {
                    var monthStart = today.AddMonths(-i).AddDays(-today.Day + 1);
                    var monthEnd = monthStart.AddMonths(1).AddDays(-1);
                    var monthOrders = filteredOrders.Where(o => o.OrderDate >= monthStart && o.OrderDate <= monthEnd);
                    monthlyRevenue.Add(monthOrders.Sum(o => o.Total));
                }

                chartRevenueFlow.Series[0].Points.Clear();
                for (int i = 0; i < months.Length; i++)
                {
                    int pointIndex = chartRevenueFlow.Series[0].Points.AddXY(months[i], monthlyRevenue[i]);
                    chartRevenueFlow.Series[0].Points[pointIndex].Label = monthlyRevenue[i].ToString("C0");
                    chartRevenueFlow.Series[0].Points[pointIndex].LabelForeColor = Color.FromArgb(52, 104, 80);
                }
                chartRevenueFlow.ChartAreas[0].AxisY.LabelStyle.Format = "C0";

                // ----- INVENTORY BREAKDOWN (from ProductStorage) -----
                var products = ProductStorage.GetAllProducts();

                decimal foodValue = products
                    .Where(p => p.Category == "Appetizers" || p.Category == "Main Course" || p.Category == "Desserts")
                    .Sum(p => p.Price * p.StockQuantity);

                decimal beverageValue = products
                    .Where(p => p.Category == "Beverages")
                    .Sum(p => p.Price * p.StockQuantity);

                decimal otherValue = products
                    .Where(p => p.Category != "Appetizers" && p.Category != "Main Course" &&
                                p.Category != "Desserts" && p.Category != "Beverages")
                    .Sum(p => p.Price * p.StockQuantity);

                // Update the labels – note: we're reusing the existing designer controls
                lblFoodTotal.Text = foodValue.ToString("C0");
                lblClothesTotal.Text = beverageValue.ToString("C0");   // originally "Clothes" now shows beverages
                lblOtherTotal.Text = otherValue.ToString("C0");

                // Update the descriptive labels to match restaurant terms
                lblFood.Text = "Food:";                // already correct
                lblClothes.Text = "Beverages:";        // change text from "Clothes:" to "Beverages:"
                lblOther.Text = "Other:";               // already generic

                decimal totalInventory = foodValue + beverageValue + otherValue;
                lblTotalExpensesValue.Text = totalInventory.ToString("C0");  // originally "Total Expenses" now shows inventory value
                lblTotalExpenses.Text = "Total Inventory";                   // update header text

                // ----- PIE CHART (inventory breakdown) -----
                chartCategoryPie.Series[0].Points.Clear();

                int idx1 = chartCategoryPie.Series[0].Points.AddXY("Food", (double)foodValue);
                int idx2 = chartCategoryPie.Series[0].Points.AddXY("Beverages", (double)beverageValue);
                int idx3 = chartCategoryPie.Series[0].Points.AddXY("Other", (double)otherValue);

                chartCategoryPie.Series[0].Points[idx1].Color = Color.FromArgb(56, 142, 60);
                chartCategoryPie.Series[0].Points[idx2].Color = Color.FromArgb(52, 104, 80);
                chartCategoryPie.Series[0].Points[idx3].Color = Color.FromArgb(76, 220, 100);

                chartCategoryPie.Series[0].IsValueShownAsLabel = true;
                chartCategoryPie.Series[0].LabelFormat = "C0";
                chartCategoryPie.Series[0].LabelForeColor = Color.FromArgb(50, 50, 50);
                chartCategoryPie.Series[0].Font = new Font("Segoe UI", 7);

                // ----- INCOME vs EXPENSE BAR CHART (last 6 months) -----
                var monthlyExpense = monthlyRevenue.Select(r => r * 0.4m).ToList();

                chartIncomeExpense.Series.Clear();
                var seriesIncome = new Series("Income") { ChartType = SeriesChartType.Column, Color = Color.FromArgb(56, 142, 60) };
                var seriesExpense = new Series("Expense") { ChartType = SeriesChartType.Column, Color = Color.FromArgb(231, 76, 60) };

                for (int i = 0; i < months.Length; i++)
                {
                    seriesIncome.Points.AddXY(months[i], (double)monthlyRevenue[i]);
                    seriesExpense.Points.AddXY(months[i], (double)monthlyExpense[i]);
                }

                chartIncomeExpense.Series.Add(seriesIncome);
                chartIncomeExpense.Series.Add(seriesExpense);
                chartIncomeExpense.ChartAreas[0].AxisY.LabelStyle.Format = "C0";
            }
            catch (Exception ex)
            {
                // Silently ignore design‑time errors
                System.Diagnostics.Debug.WriteLine("Dashboard update error: " + ex.Message);
            }
        }
    }
}