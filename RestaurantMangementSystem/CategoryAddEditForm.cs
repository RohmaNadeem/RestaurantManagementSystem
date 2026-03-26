using System;
using System.Windows.Forms;

namespace RestaurantMangementSystem
{
    public partial class CategoryAddEditForm : Form
    {
        public Category Category { get; private set; }

        public CategoryAddEditForm(Category category = null)
        {
            InitializeComponent();
            if (category == null)
            {
                Category = new Category();
                this.Text = "Add Category";
            }
            else
            {
                Category = category;
                this.Text = "Edit Category";
                txtName.Text = category.Name;
                txtDescription.Text = category.Description;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Category name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Category.Name = txtName.Text.Trim();
            Category.Description = txtDescription.Text.Trim();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}