using System;
using System.Windows.Forms;

namespace RestaurantMangementSystem
{
    public partial class TableAddEditForm : Form
    {
        public Table Table { get; private set; }

        public TableAddEditForm(Table table = null)
        {
            InitializeComponent();

            if (table == null)
            {
                Table = new Table();
                this.Text = "Add Table";
                cmbLocation.SelectedIndex = 0;
                cmbStatus.SelectedIndex = 0;
                chkActive.Checked = true;
            }
            else
            {
                Table = table;
                this.Text = "Edit Table";
                txtName.Text = table.Name;
                numCapacity.Value = table.Capacity;
                cmbLocation.Text = table.Location;
                cmbStatus.Text = table.Status;
                txtMinOrder.Text = table.MinimumOrder.ToString("0.00");
                chkActive.Checked = table.IsActive;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Table name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbLocation.SelectedItem == null)
            {
                MessageBox.Show("Please select a location.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtMinOrder.Text, out decimal minOrder) || minOrder < 0)
            {
                MessageBox.Show("Please enter a valid minimum order amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Table.Name = txtName.Text.Trim();
            Table.Capacity = (int)numCapacity.Value;
            Table.Location = cmbLocation.Text;
            Table.Status = cmbStatus.Text;
            Table.MinimumOrder = minOrder;
            Table.IsActive = chkActive.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtMinOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }
    }
}