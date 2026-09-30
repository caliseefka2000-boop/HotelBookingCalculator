using System;
using System.Windows.Forms;

namespace HotelBookingCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int nights = int.Parse(txtNights.Text);
                double pricePerNight = double.Parse(txtPriceNight.Text);

                double subtotal = nights * pricePerNight;
                double serviceTax = subtotal * 0.10;
                double discount = subtotal * 0.05;
                double totalAmount = subtotal + serviceTax - discount;

                lblServiceTax.Text = "$" + serviceTax.ToString("N2");
                lblDiscount.Text = "$" + discount.ToString("N2");
                lblTotalAmount.Text = "$" + totalAmount.ToString("N2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Fadlan geli tirooyin sax ah!", "Khalad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
