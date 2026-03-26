using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantMangementSystem
{
    public partial class PaymentDialog : Form
    {
        public string PaymentMethod { get; private set; }
        public decimal AmountPaid { get; private set; }
        public decimal ChangeDue { get; private set; }
        private decimal totalAmount;

        public PaymentDialog(decimal total)
        {
            InitializeComponent();
            totalAmount = total;
            lblTotalAmount.Text = total.ToString("C2");
            txtAmountPaid.Text = total.ToString("F2");
            CalculateChange();

            // Setup event handlers
            rdoCash.CheckedChanged += (s, e) => UpdatePaymentUI();
            rdoCard.CheckedChanged += (s, e) => UpdatePaymentUI();
            rdoMobile.CheckedChanged += (s, e) => UpdatePaymentUI();
            txtAmountPaid.TextChanged += (s, e) => CalculateChange();
            btnConfirm.Click += BtnConfirm_Click;
            btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
        }

        private void UpdatePaymentUI()
        {
            bool isCash = rdoCash.Checked;
            txtAmountPaid.Visible = isCash;
            txtAmountPaid.Enabled = isCash;
            lblChange.Visible = isCash;
            label4.Visible = isCash;
            label3.Visible = isCash;

            if (!isCash)
            {
                txtAmountPaid.Text = totalAmount.ToString("F2");
                CalculateChange();
            }
        }

        private void CalculateChange()
        {
            if (decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid))
            {
                AmountPaid = amountPaid;
                ChangeDue = amountPaid - totalAmount;

                if (ChangeDue < 0)
                {
                    lblChange.Text = $"(${Math.Abs(ChangeDue):F2})";
                    lblChange.ForeColor = Color.Red;
                    btnConfirm.Enabled = false;
                }
                else
                {
                    lblChange.Text = $"${ChangeDue:F2}";
                    lblChange.ForeColor = Color.FromArgb(56, 142, 60);
                    btnConfirm.Enabled = true;
                }
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            // Validate cash payment
            if (rdoCash.Checked && ChangeDue < 0)
            {
                MessageBox.Show("Amount paid is less than total amount!",
                    "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Set payment method
            if (rdoCash.Checked)
                PaymentMethod = "Cash";
            else if (rdoCard.Checked)
                PaymentMethod = "Credit/Debit Card";
            else if (rdoMobile.Checked)
                PaymentMethod = "Mobile Payment";

            this.DialogResult = DialogResult.OK;
        }
    }
}