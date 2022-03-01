using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        string flavour;
        string cone;
        string topping;
        double iceCreamPrice = 1;
        double regularConePrice = 1;
        double waffleConePrice = 2;
        double cupPrice = 0.5;
        double sprinklesPrice = 0.1;
        double cookieCrumbsPrice = 0.25;
        double taxRate = 0.13;
        double subtotal;
        double taxAmount;
        double totalPrice;
        double amountTendered;
        double change;

        public Form1()
        {
            InitializeComponent();
        }

        private void makeYourIceCreamButton_Click(object sender, EventArgs e)
        {
            makeYourIceCreamButton.Visible = false;
            selectIceCreamTypeLabel.Visible = true;
            vanillaButton.Visible = true;
            chocolateButton.Visible = true;
            swirlButton.Visible = true;
        }

        private void vanillaButton_Click(object sender, EventArgs e)
        {
            flavour = "vanilla";

            vanillaButton.BackColor = Color.DarkSeaGreen;
            chocolateButton.BackColor = Color.Transparent;
            swirlButton.BackColor = Color.Transparent;
            vanillaButton.Enabled = false;
            chocolateButton.Enabled = false;
            swirlButton.Enabled = false;

            selectConeTypeLabel.Visible = true;
            regularButton.Visible = true;
            waffleButton.Visible = true;
            cupButton.Visible = true;
        }

        private void chocolateButton_Click(object sender, EventArgs e)
        {
            flavour = "chocolate";

            chocolateButton.BackColor = Color.DarkSeaGreen;
            vanillaButton.BackColor = Color.Transparent;
            swirlButton.BackColor = Color.Transparent;
            vanillaButton.Enabled = false;
            chocolateButton.Enabled = false;
            swirlButton.Enabled = false;

            selectConeTypeLabel.Visible = true;
            regularButton.Visible = true;
            waffleButton.Visible = true;
            cupButton.Visible = true;
        }

        private void swirlButton_Click(object sender, EventArgs e)
        {
            flavour = "swirl";

            swirlButton.BackColor = Color.DarkSeaGreen;
            vanillaButton.BackColor = Color.Transparent;
            chocolateButton.BackColor = Color.Transparent;
            vanillaButton.Enabled = false;
            chocolateButton.Enabled = false;
            swirlButton.Enabled = false;

            selectConeTypeLabel.Visible = true;
            regularButton.Visible = true;
            waffleButton.Visible = true;
            cupButton.Visible = true;
        }

        private void regularButton_Click(object sender, EventArgs e)
        {
            cone = "regular cone";

            regularButton.BackColor = Color.DarkSeaGreen;
            waffleButton.BackColor = Color.Transparent;
            cupButton.BackColor = Color.Transparent;
            regularButton.Enabled = false;
            waffleButton.Enabled = false;
            cupButton.Enabled = false;

            selectToppingLabel.Visible = true;
            noneButton.Visible = true;
            sprinklesButton.Visible = true;
            cookieCrumbsButton.Visible = true;
        }

        private void waffleButton_Click(object sender, EventArgs e)
        {
            cone = "waffle cone";

            waffleButton.BackColor = Color.DarkSeaGreen;
            regularButton.BackColor = Color.Transparent;
            cupButton.BackColor = Color.Transparent;
            regularButton.Enabled = false;
            waffleButton.Enabled = false;
            cupButton.Enabled = false;

            selectToppingLabel.Visible = true;
            noneButton.Visible = true;
            sprinklesButton.Visible = true;
            cookieCrumbsButton.Visible = true;
        }

        private void cupButton_Click(object sender, EventArgs e)
        {
            cone = "cup";

            cupButton.BackColor = Color.DarkSeaGreen;
            regularButton.BackColor = Color.Transparent;
            waffleButton.BackColor = Color.Transparent;
            regularButton.Enabled = false;
            waffleButton.Enabled = false;
            cupButton.Enabled = false;

            selectToppingLabel.Visible = true;
            noneButton.Visible = true;
            sprinklesButton.Visible = true;
            cookieCrumbsButton.Visible = true;
        }

        private void noneButton_Click(object sender, EventArgs e)
        {
            topping = "no topping";

            noneButton.BackColor = Color.DarkSeaGreen;
            sprinklesButton.BackColor = Color.Transparent;
            cookieCrumbsButton.BackColor = Color.Transparent;
            noneButton.Enabled = false;
            sprinklesButton.Enabled = false;
            cookieCrumbsButton.Enabled = false;

            confirmOrderButton.Visible = true;
        }

        private void sprinklesButton_Click(object sender, EventArgs e)
        {
            topping = "sprinkles";

            sprinklesButton.BackColor = Color.DarkSeaGreen;
            noneButton.BackColor = Color.Transparent;
            cookieCrumbsButton.BackColor = Color.Transparent;
            noneButton.Enabled = false;
            sprinklesButton.Enabled = false;
            cookieCrumbsButton.Enabled = false;

            confirmOrderButton.Visible = true;
        }

        private void cookieCrumbsButton_Click(object sender, EventArgs e)
        {
            topping = "cookie crumbs";

            cookieCrumbsButton.BackColor = Color.DarkSeaGreen;
            noneButton.BackColor = Color.Transparent;
            sprinklesButton.BackColor = Color.Transparent;
            noneButton.Enabled = false;
            sprinklesButton.Enabled = false;
            cookieCrumbsButton.Enabled = false;

            confirmOrderButton.Visible = true;
        }

        private void confirmOrderButton_Click(object sender, EventArgs e)
        {
            selectIceCreamTypeLabel.Visible = false;
            vanillaButton.Visible = false;
            chocolateButton.Visible = false;
            swirlButton.Visible = false;
            selectConeTypeLabel.Visible = false;
            regularButton.Visible = false;
            waffleButton.Visible = false;
            cupButton.Visible = false;
            selectToppingLabel.Visible = false;
            noneButton.Visible = false;
            sprinklesButton.Visible = false;
            cookieCrumbsButton.Visible = false;
            confirmOrderButton.Visible = false;

            subtotal = iceCreamPrice;
            if (cone == "regular cone")
            {
                subtotal = subtotal + regularConePrice;
            }
            else if (cone == "waffle cone")
            {
                subtotal = subtotal + waffleConePrice;
            }
            else if (cone == "cup")
            {
                subtotal = subtotal + cupPrice;
            }

            if (topping == "sprinkles")
            {
                subtotal = subtotal + sprinklesPrice;
            }
            else if (topping == "cookie crumbs")
            {
                subtotal = subtotal + cookieCrumbsPrice;
            }

            taxAmount = subtotal * taxRate;
            totalPrice = subtotal + taxAmount;

            prerecieptOutputLabel.Text = $"Subtotal     {subtotal.ToString("C")}";
            prerecieptOutputLabel.Text += $"\nTax            {taxAmount.ToString("C")}";
            prerecieptOutputLabel.Text += $"\nTotal          {totalPrice.ToString("C")}";

            prerecieptOutputLabel.Visible = true;
            tenderedLabel.Visible = true;
            tenderedInput.Visible = true;
            calculateChangeButton.Visible = true;
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            if (tenderedInput.Text == "")
            {
                tenderedInput.Text = "Give Money";
            }
            else
            {
                try
                {
                    amountTendered = Convert.ToInt16(tenderedInput.Text);
                    change = amountTendered - totalPrice;
                    if (change >= 0 && amountTendered != 666)
                    {
                        calculateChangeButton.BackColor = Color.DarkSeaGreen;
                        calculateChangeButton.Enabled = false;
                        tenderedInput.Enabled = false;
                        changeOutputLabel.Text = $"Change        {change.ToString("C")}";
                        changeOutputLabel.Visible = true;
                        printRecieptButton.Visible = true;
                    }
                    else if (change >= 0 && amountTendered == 666)
                    {
                        tenderedInput.Text = "huh.";
                        calculateChangeButton.BackColor = Color.DarkSeaGreen;
                        calculateChangeButton.Enabled = false;
                        tenderedInput.Enabled = false;
                        changeOutputLabel.Text = $"Change        {change.ToString("C")}";

                        changeOutputLabel.Visible = true;
                        printRecieptButton.Visible = true;
                    }
                    else
                    {
                        tenderedInput.Text = "Not Enough Money";
                    }
                }
                catch
                {
                    tenderedInput.Text = "Input Error";
                }
            }
        }

        private void printRecieptButton_Click(object sender, EventArgs e)
        {
            recieptOutputLabel.Text = "      Ice Cream Shop";
            recieptOutputLabel.Text += "\n\nOrder Number 1438290";
            recieptOutputLabel.Text += "\nFebruary 24, 2022 at 2:40pm";
            recieptOutputLabel.Text += $"\n1 {flavour} ice cream in a {cone} with {topping}";
            recieptOutputLabel.Text += $"\n\nSubtotal       {subtotal.ToString("C")}";
            recieptOutputLabel.Text += $"\nTax            {taxAmount.ToString("C")}";
            recieptOutputLabel.Text += $"\nTotal          {totalPrice.ToString("C")}";
            recieptOutputLabel.Text += "\n\nThank you for shopping at Ice Cream Shop!";

            prerecieptOutputLabel.Visible = false;
            tenderedLabel.Visible = false;
            tenderedInput.Visible = false;
            calculateChangeButton.Visible = false;
            changeOutputLabel.Visible = false;
            printRecieptButton.Visible = false;
            this.AutoSize = false;
            this.Size = new Size(790, 500);
            recieptOutputLabel.Size = new Size(400, 0);
            recieptOutputLabel.Visible = true;
            printingRecieptLabel.Visible = true;

            SoundPlayer player = new SoundPlayer(Properties.Resources.recieptPrinter);

            player.Play();

            for (int i = 0; i <= 325; i++)
            {
                recieptOutputLabel.Size = new Size(400, i);
                Thread.Sleep(1);
                Refresh();
            }

            Thread.Sleep(500);

            newOrderButton.Visible = true;
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            recieptOutputLabel.Visible = false;
            printingRecieptLabel.Visible = false;
            newOrderButton.Visible = false;
            this.AutoSize = true;
            makeYourIceCreamButton.Visible = true;

            vanillaButton.Enabled = true;
            chocolateButton.Enabled = true;
            swirlButton.Enabled = true;

            regularButton.Enabled = true;
            waffleButton.Enabled = true;
            cupButton.Enabled = true;

            noneButton.Enabled = true;
            sprinklesButton.Enabled = true;
            cookieCrumbsButton.Enabled = true;

            vanillaButton.BackColor = Color.Transparent;
            chocolateButton.BackColor = Color.Transparent;
            swirlButton.BackColor = Color.Transparent;

            regularButton.BackColor = Color.Transparent;
            waffleButton.BackColor = Color.Transparent;
            cupButton.BackColor = Color.Transparent;

            noneButton.BackColor = Color.Transparent;
            sprinklesButton.BackColor = Color.Transparent;
            cookieCrumbsButton.BackColor = Color.Transparent;

            tenderedInput.Text = "";

            tenderedInput.Enabled = true;

            calculateChangeButton.Enabled = true;

            calculateChangeButton.BackColor = Color.Transparent;

            flavour = "";
            cone = "";
            topping = "";
            subtotal = 0;
            taxAmount = 0;
            totalPrice = 0;
            amountTendered = 0;
            change = 0;
        }
    }
}