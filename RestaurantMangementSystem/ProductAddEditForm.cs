using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantMangementSystem
{
    public partial class ProductAddEditForm : Form
    {
        public Product Product { get; private set; }

        public ProductAddEditForm(Product product = null)
        {
            InitializeComponent();
            LoadCategories();

            if (product == null)
            {
                Product = new Product();
                this.Text = "Add Product";
                cmbUnit.SelectedIndex = 0;
                chkAvailable.Checked = true;
            }
            else
            {
                Product = product;
                this.Text = "Edit Product";
                txtName.Text = product.Name;
                cmbCategory.Text = product.Category;
                txtDescription.Text = product.Description;
                txtPrice.Text = product.Price.ToString("0.00");
                txtCost.Text = product.Cost.ToString("0.00");
                txtStock.Text = product.StockQuantity.ToString();
                cmbUnit.Text = product.Unit;
                chkAvailable.Checked = product.IsAvailable;
                if (product.ProductImage != null && product.ProductImage.Length > 0)
                {
                    pbProductImage.Image = product.GetImage();
                }
            }
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            var categories = CategoryStorage.GetAllCategories();
            foreach (var cat in categories)
            {
                cmbCategory.Items.Add(cat.Name);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Product name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtCost.Text, out decimal cost) || cost < 0)
            {
                MessageBox.Show("Please enter a valid cost.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Please enter a valid stock quantity.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbUnit.SelectedItem == null)
            {
                MessageBox.Show("Please select a unit.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product.Name = txtName.Text.Trim();
            Product.Category = cmbCategory.Text;
            Product.Description = txtDescription.Text.Trim();
            Product.Price = price;
            Product.Cost = cost;
            Product.StockQuantity = stock;
            Product.Unit = cmbUnit.Text;
            Product.IsAvailable = chkAvailable.Checked;

            // Save image
            if (pbProductImage.Image != null)
            {
                Product.SetImage(pbProductImage.Image);
            }
            else
            {
                Product.ProductImage = null;
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Select Product Image";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pbProductImage.Image = Image.FromFile(ofd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            pbProductImage.Image = null;
        }
    }
}