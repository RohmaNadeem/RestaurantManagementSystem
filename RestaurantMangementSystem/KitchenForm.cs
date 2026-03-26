using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RestaurantMangementSystem
{
    public partial class KitchenForm : Form
    {
        private List<Order> kitchenOrders = new List<Order>();

        public KitchenForm()
        {
            InitializeComponent();
            
            InitializeDataGridView();
            LoadOrders();
           
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
           
        }

        private void InitializeDataGridView()
        {
            dgvKitchenOrders.Columns.Clear();

            DataGridViewTextBoxColumn colOrderNo = new DataGridViewTextBoxColumn
            {
                Name = "OrderNumber",
                HeaderText = "ORDER #",
                Width = 120,
                ReadOnly = true
            };

            DataGridViewTextBoxColumn colTime = new DataGridViewTextBoxColumn
            {
                Name = "Time",
                HeaderText = "TIME",
                Width = 80,
                ReadOnly = true
            };

            DataGridViewTextBoxColumn colStatus = new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "STATUS",
                Width = 100,
                ReadOnly = true
            };

            DataGridViewTextBoxColumn colType = new DataGridViewTextBoxColumn
            {
                Name = "Type",
                HeaderText = "TYPE",
                Width = 80,
                ReadOnly = true
            };

            DataGridViewTextBoxColumn colCustomer = new DataGridViewTextBoxColumn
            {
                Name = "Customer",
                HeaderText = "CUSTOMER",
                Width = 120,
                ReadOnly = true
            };

            DataGridViewTextBoxColumn colItems = new DataGridViewTextBoxColumn
            {
                Name = "Items",
                HeaderText = "ITEMS",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            };

            DataGridViewTextBoxColumn colTotal = new DataGridViewTextBoxColumn
            {
                Name = "Total",
                HeaderText = "TOTAL",
                Width = 100,
                ReadOnly = true
            };

            dgvKitchenOrders.Columns.AddRange(new DataGridViewColumn[] {
                colOrderNo, colTime, colStatus, colType, colCustomer, colItems, colTotal
            });

            dgvKitchenOrders.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvKitchenOrders.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvKitchenOrders.DefaultCellStyle.Padding = new Padding(5);
            dgvKitchenOrders.RowTemplate.Height = 40;
            dgvKitchenOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKitchenOrders.MultiSelect = false;
        }

        public void LoadOrders()
        {
            try
            {
                var orders = OrderStorage.GetAllOrders();
                kitchenOrders = orders
                    .Where(o => o.Status == OrderStatus.Pending ||
                               o.Status == OrderStatus.Preparing ||
                               o.Status == OrderStatus.Ready)
                    .OrderBy(o => o.OrderDate)
                    .ToList();

                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataGridView()
        {
            dgvKitchenOrders.Rows.Clear();

            foreach (var order in kitchenOrders)
            {
                string items = string.Join("\n", order.Items.Select(i => $"• {i.Quantity}x {i.ProductName}"));

                int rowIndex = dgvKitchenOrders.Rows.Add(
                    order.OrderNumber,
                    order.OrderDate.ToString("HH:mm"),
                    order.Status.ToString(),
                    order.Type.ToString(),
                    order.CustomerName ?? "Walk-in",
                    items,
                    order.Total.ToString("C2")
                );

                var row = dgvKitchenOrders.Rows[rowIndex];

                switch (order.Status)
                {
                    case OrderStatus.Pending:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(133, 100, 4);
                        break;
                    case OrderStatus.Preparing:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 218);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(21, 87, 36);
                        break;
                    case OrderStatus.Ready:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(220, 245, 220);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(0, 64, 128);
                        break;
                }
            }

            lblTitle.Text = $"KITCHEN ORDERS ({kitchenOrders.Count})";
        }

        // ========== STATUS UPDATE METHODS ==========
        private void UpdateOrderStatus(string targetStatus, OrderStatus newStatus)
        {
            if (dgvKitchenOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.", "Select Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string orderNumber = dgvKitchenOrders.SelectedRows[0].Cells["OrderNumber"].Value.ToString();
            var order = kitchenOrders.FirstOrDefault(o => o.OrderNumber == orderNumber);
            if (order == null) return;

            bool canTransition = false;
            switch (newStatus)
            {
                case OrderStatus.Preparing:
                    canTransition = (order.Status == OrderStatus.Pending);
                    break;
                case OrderStatus.Ready:
                    canTransition = (order.Status == OrderStatus.Preparing);
                    break;
                case OrderStatus.Served:
                    canTransition = (order.Status == OrderStatus.Ready);
                    break;
            }

            if (!canTransition)
            {
                MessageBox.Show($"Cannot mark order as {newStatus} from current status ({order.Status}).",
                    "Invalid Transition", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            order.Status = newStatus;
            if (OrderStorage.UpdateOrder(order))
            {
                LoadOrders();
                MessageBox.Show($"Order #{orderNumber} is now {newStatus}.", "Status Updated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnStartPreparing_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("start preparing", OrderStatus.Preparing);
        }

        private void BtnMarkReady_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("ready", OrderStatus.Ready);
        }

        private void BtnMarkServed_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("served", OrderStatus.Served);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void KitchenForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void KitchenForm_Resize(object sender, EventArgs e) { }

        private void lblTitle_Click(object sender, EventArgs e) { }

        // ========== Global Settings Handling ==========
       

        private void dgvKitchenOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}