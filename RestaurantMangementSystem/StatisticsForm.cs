using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantMangementSystem
{
    public partial class StatisticsForm : Form
    {
        private List<Product> products;

        public StatisticsForm(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
            LoadCharts();
        }

        private void LoadCharts()
        {
            // Category distribution (count of products per category)
            var categoryGroups = products.GroupBy(p => p.Category)
                                         .Select(g => new { Category = g.Key, Count = g.Count() })
                                         .OrderByDescending(x => x.Count);

            chartCategory.Series[0].Points.Clear();
            foreach (var item in categoryGroups)
            {
                chartCategory.Series[0].Points.AddXY(item.Category, item.Count);
            }

            // Stock levels: low stock, normal, unavailable
            int lowStock = products.Count(p => p.StockQuantity <= 5);
            int normalStock = products.Count(p => p.StockQuantity > 5 && p.IsAvailable);
            int unavailable = products.Count(p => !p.IsAvailable);

            chartStock.Series[0].Points.Clear();
            chartStock.Series[0].Points.AddXY("Low Stock (≤5)", lowStock);
            chartStock.Series[0].Points.AddXY("Normal Stock", normalStock);
            chartStock.Series[0].Points.AddXY("Unavailable", unavailable);
        }
    }
}