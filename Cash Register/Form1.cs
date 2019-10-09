using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        const double BURGER_PRICE = 3.99;
        const double FRIES_PRICE = 2.99;
        const double DRINKS_PRICE = 1.99;
        const double TAX = 0.13;

        double numOfBurgers = 0;
        double numOfFries = 0;
        double numOfDrinks = 0;
        double subTotal;
        double taxAmount;
        double totalWithTax;
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateTotals_Click(object sender, EventArgs e)
        {
            numOfBurgers = Convert.ToDouble(NumOfBurgersInput.Text);
            numOfFries = Convert.ToDouble(NumOfFriesInput.Text);
            numOfDrinks = Convert.ToDouble(NumOfDrinksInput.Text);

            subTotal = BURGER_PRICE * numOfBurgers + FRIES_PRICE * numOfFries + DRINKS_PRICE * numOfDrinks;
            taxAmount = subTotal * TAX;
            totalWithTax = subTotal + taxAmount;

            subTotalOutput.Text = subTotal.ToString("C");
            taxOutput.Text = taxAmount.ToString("C");
            totalWithTaxOutput.Text = totalWithTax.ToString("C");
        }

        private void PrintReceipt_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawpen = new Pen(Color.Black);
            SolidBrush drawbrush = new SolidBrush(Color.Black);
            Font drawfont = new Font("Arial", 14, FontStyle.Bold);
            g.DrawRectangle(drawpen, 350, 40, 370, 300);
            g.DrawString("Burger Town", drawfont, drawbrush, 360, 50);
            g.DrawString("Sub Total:     " + subTotal.ToString("C"), drawfont, drawbrush, 360, 100);
            g.DrawString("Tax Amount:     " + taxAmount.ToString("C"), drawfont, drawbrush, 360, 150);
            g.DrawString("total with tax:     " + totalWithTax.ToString("C"), drawfont, drawbrush, 360, 200);

        }
    }
}
