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
        //global variables
        string flavour;
        string cone;
        string topping;
        const double iceCreamPrice = 1;
        const double regularConePrice = 1;
        const double waffleConePrice = 2;
        const double cupPrice = 0.5;
        const double sprinklesPrice = 0.1;
        const double cookieCrumbsPrice = 0.25;
        const double taxRate = 0.13;
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
            //switch to ice cream type buttons
            makeYourIceCreamButton.Visible = false;
            selectIceCreamTypeLabel.Visible = true;
            vanillaButton.Visible = true;
            chocolateButton.Visible = true;
            swirlButton.Visible = true;
        }

        private void vanillaButton_Click(object sender, EventArgs e)
        {
            //store choice
            flavour = "vanilla";

            //change the colour of the button selected so that the user can see which they chose, but disable the ice cream buttons
            vanillaButton.BackColor = Color.DarkSeaGreen;
            chocolateButton.BackColor = Color.Transparent;
            swirlButton.BackColor = Color.Transparent;
            vanillaButton.Enabled = false;
            chocolateButton.Enabled = false;
            swirlButton.Enabled = false;

            //show the cone type buttons
            selectConeTypeLabel.Visible = true;
            regularButton.Visible = true;
            waffleButton.Visible = true;
            cupButton.Visible = true;

            //show back button
            backButton.Visible = true;
        }

        private void chocolateButton_Click(object sender, EventArgs e)
        {
            //store choice
            flavour = "chocolate";

            //change the colour of the button selected so that the user can see which they chose, but disable the ice cream buttons
            chocolateButton.BackColor = Color.DarkSeaGreen;
            vanillaButton.BackColor = Color.Transparent;
            swirlButton.BackColor = Color.Transparent;
            vanillaButton.Enabled = false;
            chocolateButton.Enabled = false;
            swirlButton.Enabled = false;

            //show the cone type buttons
            selectConeTypeLabel.Visible = true;
            regularButton.Visible = true;
            waffleButton.Visible = true;
            cupButton.Visible = true;

            //show back button
            backButton.Visible = true;
        }

        private void swirlButton_Click(object sender, EventArgs e)
        {
            //store choice
            flavour = "swirl";

            //change the colour of the button selected so that the user can see which they chose, but disable the ice cream buttons
            swirlButton.BackColor = Color.DarkSeaGreen;
            vanillaButton.BackColor = Color.Transparent;
            chocolateButton.BackColor = Color.Transparent;
            vanillaButton.Enabled = false;
            chocolateButton.Enabled = false;
            swirlButton.Enabled = false;

            //show the cone type buttons
            selectConeTypeLabel.Visible = true;
            regularButton.Visible = true;
            waffleButton.Visible = true;
            cupButton.Visible = true;

            //show back button
            backButton.Visible = true;
        }

        private void regularButton_Click(object sender, EventArgs e)
        {
            //store choice
            cone = "regular cone";

            //change the colour of the button selected so that the user can see which they chose, but disable the cone buttons
            regularButton.BackColor = Color.DarkSeaGreen;
            waffleButton.BackColor = Color.Transparent;
            cupButton.BackColor = Color.Transparent;
            regularButton.Enabled = false;
            waffleButton.Enabled = false;
            cupButton.Enabled = false;

            //show the topping buttons
            selectToppingLabel.Visible = true;
            noneButton.Visible = true;
            sprinklesButton.Visible = true;
            cookieCrumbsButton.Visible = true;

            //move back button
            backButton.Location = new Point(30, 584);
        }

        private void waffleButton_Click(object sender, EventArgs e)
        {
            //store choice
            cone = "waffle cone";

            //change the colour of the button selected so that the user can see which they chose, but disable the cone buttons
            waffleButton.BackColor = Color.DarkSeaGreen;
            regularButton.BackColor = Color.Transparent;
            cupButton.BackColor = Color.Transparent;
            regularButton.Enabled = false;
            waffleButton.Enabled = false;
            cupButton.Enabled = false;

            //show the topping buttons
            selectToppingLabel.Visible = true;
            noneButton.Visible = true;
            sprinklesButton.Visible = true;
            cookieCrumbsButton.Visible = true;

            //move back button
            backButton.Location = new Point(30, 584);
        }

        private void cupButton_Click(object sender, EventArgs e)
        {
            //store choice
            cone = "cup";

            //change the colour of the button selected so that the user can see which they chose, but disable the cone buttons
            cupButton.BackColor = Color.DarkSeaGreen;
            regularButton.BackColor = Color.Transparent;
            waffleButton.BackColor = Color.Transparent;
            regularButton.Enabled = false;
            waffleButton.Enabled = false;
            cupButton.Enabled = false;

            //show the topping buttons
            selectToppingLabel.Visible = true;
            noneButton.Visible = true;
            sprinklesButton.Visible = true;
            cookieCrumbsButton.Visible = true;

            //move back button
            backButton.Location = new Point(30, 584);
        }

        private void noneButton_Click(object sender, EventArgs e)
        {
            //store choice
            topping = "no topping";

            //change the colour of the button selected so that the user can see which they chose, but disable the topping buttons
            noneButton.BackColor = Color.DarkSeaGreen;
            sprinklesButton.BackColor = Color.Transparent;
            cookieCrumbsButton.BackColor = Color.Transparent;
            noneButton.Enabled = false;
            sprinklesButton.Enabled = false;
            cookieCrumbsButton.Enabled = false;

            //show the confirm order button
            confirmOrderButton.Visible = true;
        }

        private void sprinklesButton_Click(object sender, EventArgs e)
        {
            //store choice
            topping = "sprinkles";

            //change the colour of the button selected so that the user can see which they chose, but disable the topping buttons
            sprinklesButton.BackColor = Color.DarkSeaGreen;
            noneButton.BackColor = Color.Transparent;
            cookieCrumbsButton.BackColor = Color.Transparent;
            noneButton.Enabled = false;
            sprinklesButton.Enabled = false;
            cookieCrumbsButton.Enabled = false;

            //show the confirm order button
            confirmOrderButton.Visible = true;
        }

        private void cookieCrumbsButton_Click(object sender, EventArgs e)
        {
            //store choice
            topping = "cookie crumbs";

            //change the colour of the button selected so that the user can see which they chose, but disable the topping buttons
            cookieCrumbsButton.BackColor = Color.DarkSeaGreen;
            noneButton.BackColor = Color.Transparent;
            sprinklesButton.BackColor = Color.Transparent;
            noneButton.Enabled = false;
            sprinklesButton.Enabled = false;
            cookieCrumbsButton.Enabled = false;

            //show the confirm order button
            confirmOrderButton.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (noneButton.Enabled == false)
            {
                //clear choice
                topping = "";

                //reset the colour of the topping buttons and enable them again
                noneButton.BackColor = Color.Transparent;
                sprinklesButton.BackColor = Color.Transparent;
                cookieCrumbsButton.BackColor = Color.Transparent;
                noneButton.Enabled = true;
                sprinklesButton.Enabled = true;
                cookieCrumbsButton.Enabled = true;

                //hide the confirm order button
                confirmOrderButton.Visible = false;
            }
            else if (regularButton.Enabled == false)
            {
                //clear choice
                cone = "";

                //reset the colour of the cone buttons and enable them again
                regularButton.BackColor = Color.Transparent;
                waffleButton.BackColor = Color.Transparent;
                cupButton.BackColor = Color.Transparent;
                regularButton.Enabled = true;
                waffleButton.Enabled = true;
                cupButton.Enabled = true;

                //hide the topping buttons
                selectToppingLabel.Visible = false;
                noneButton.Visible = false;
                sprinklesButton.Visible = false;
                cookieCrumbsButton.Visible = false;

                //move back button
                backButton.Location = new Point(30, 410);
            }
            else
            {
                //clear choice
                flavour = "";

                //reset the colour of the ice cream buttons and enable them again
                vanillaButton.BackColor = Color.Transparent;
                chocolateButton.BackColor = Color.Transparent;
                swirlButton.BackColor = Color.Transparent;
                vanillaButton.Enabled = true;
                chocolateButton.Enabled = true;
                swirlButton.Enabled = true;

                //hide the cone type buttons
                selectConeTypeLabel.Visible = false;
                regularButton.Visible = false;
                waffleButton.Visible = false;
                cupButton.Visible = false;

                //hide back button
                backButton.Visible = false;
            }
        }

        private void confirmOrderButton_Click(object sender, EventArgs e)
        {
            //clear the screen
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
            backButton.Visible = false;
            confirmOrderButton.Visible = false;

            //calculate subtotal (cone price)
            subtotal = iceCreamPrice;
            if (cone == "regular cone")
            {
                subtotal += regularConePrice;
            }
            else if (cone == "waffle cone")
            {
                subtotal += waffleConePrice;
            }
            else if (cone == "cup")
            {
                subtotal += cupPrice;
            }
            
            //calculate subtotal (topping price)
            if (topping == "sprinkles")
            {
                subtotal += sprinklesPrice;
            }
            else if (topping == "cookie crumbs")
            {
                subtotal += cookieCrumbsPrice;
            }

            //calculate tax and total
            taxAmount = subtotal * taxRate;
            totalPrice = subtotal + taxAmount;

            //pre-reciept text (I don't know what to call it haha)
            prerecieptOutputLabel.Text = $"Subtotal     {subtotal.ToString("C")}";
            prerecieptOutputLabel.Text += $"\nTax            {taxAmount.ToString("C")}";
            prerecieptOutputLabel.Text += $"\nTotal          {totalPrice.ToString("C")}";

            //show pre-reciept. allow user to input their money and to calculate their change
            prerecieptOutputLabel.Visible = true;
            tenderedLabel.Visible = true;
            tenderedInput.Visible = true;
            calculateChangeButton.Visible = true;
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            //calculate change (if the input fits the correct requirements
            if (tenderedInput.Text == "") //if there is nothing in the textbox, tell the user to put in money
            {
                tenderedInput.Text = "Give Money";
            }
            else
            {
                try //try to calculate change (if the input is only numbers)
                {
                    //get amount tendered from user input
                    amountTendered = Convert.ToInt16(tenderedInput.Text);

                    //calculate change
                    change = amountTendered - totalPrice;

                    if (change >= 0 && amountTendered != 666) //calculate if the user gave enough money, but don't include the easter egg that the user can get if they enter "666"
                    {
                        //change backcolour of button to show that it has been clicked, and disable the button and textbox
                        calculateChangeButton.BackColor = Color.DarkSeaGreen;
                        calculateChangeButton.Enabled = false;
                        tenderedInput.Enabled = false;

                        //show the change amount, and show the button to print the reciept
                        changeOutputLabel.Text = $"Change        {change.ToString("C")}";
                        changeOutputLabel.Visible = true;
                        printRecieptButton.Visible = true;
                    }
                    else if (change >= 0 && amountTendered == 666) //easter egg if the user inputs "666" as their amount tendered (it changes the text to "huh." but you can still continue as normal). Technically I could have just left it as "if (amountTendered == 666)" because the total cost can't be greater than 666 so it would always be enough money.
                    {
                        //easter egg
                        tenderedInput.Text = "huh.";

                        //change backcolour of button to show that it has been clicked, and disable the button and textbox
                        calculateChangeButton.BackColor = Color.DarkSeaGreen;
                        calculateChangeButton.Enabled = false;
                        tenderedInput.Enabled = false;

                        //show the change amount, and show the button to print the reciept
                        changeOutputLabel.Text = $"Change        {change.ToString("C")}";
                        changeOutputLabel.Visible = true;
                        printRecieptButton.Visible = true;
                    }
                    else //inform the user that they did not put enough money
                    {
                        tenderedInput.Text = "Not Enough Money";
                    }
                }
                catch //tell the user there is something wrong with their input (most likely it contains something that isn't a number)
                {
                    tenderedInput.Text = "Input Error";
                }
            }
        }

        private void printRecieptButton_Click(object sender, EventArgs e)
        {
            //put values into reciept label
            recieptOutputLabel.Text = "      Ice Cream Shop";
            recieptOutputLabel.Text += "\n\nOrder Number 1438290";
            recieptOutputLabel.Text += "\nFebruary 24, 2022 at 2:40pm";
            recieptOutputLabel.Text += $"\n1 {flavour} ice cream in a {cone} with {topping}";
            recieptOutputLabel.Text += $"\n\nSubtotal       {subtotal.ToString("C")}";
            recieptOutputLabel.Text += $"\nTax            {taxAmount.ToString("C")}";
            recieptOutputLabel.Text += $"\nTotal          {totalPrice.ToString("C")}";
            recieptOutputLabel.Text += "\n\nThank you for shopping at Ice Cream Shop!";

            //clear screen
            prerecieptOutputLabel.Visible = false;
            tenderedLabel.Visible = false;
            tenderedInput.Visible = false;
            calculateChangeButton.Visible = false;
            changeOutputLabel.Visible = false;
            printRecieptButton.Visible = false;

            //set up for printing reciept
            this.AutoSize = false;
            this.Size = new Size(790, 500);
            recieptOutputLabel.Size = new Size(400, 0);
            recieptOutputLabel.Visible = true;
            printingRecieptLabel.Visible = true;

            //printing sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.recieptPrinter);

            player.Play();

            //printing out the label
            for (int i = 0; i <= 325; i++)
            {
                recieptOutputLabel.Size = new Size(400, i);
                Thread.Sleep(1);
                Refresh();
            }

            Thread.Sleep(150); //delay so that the button appearance (roughly) lines up with the audio

            newOrderButton.Visible = true; //show the button to make a new order
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //clear screen
            recieptOutputLabel.Visible = false;
            printingRecieptLabel.Visible = false;
            newOrderButton.Visible = false;

            //go back to autosize so the form grows as more buttons are shown
            this.AutoSize = true;

            //show button to begin the new order (I probably could have made the "new order" button go directly to the selecting ice cream part, but this works as well)
            makeYourIceCreamButton.Visible = true;

            //enable ice cream buttons again
            vanillaButton.Enabled = true;
            chocolateButton.Enabled = true;
            swirlButton.Enabled = true;

            //replace back button
            backButton.Location = new Point(30, 410);

            //enable cone buttons again
            regularButton.Enabled = true;
            waffleButton.Enabled = true;
            cupButton.Enabled = true;

            //enable topping buttons again
            noneButton.Enabled = true;
            sprinklesButton.Enabled = true;
            cookieCrumbsButton.Enabled = true;

            //reset ice cream buttons backcolour
            vanillaButton.BackColor = Color.Transparent;
            chocolateButton.BackColor = Color.Transparent;
            swirlButton.BackColor = Color.Transparent;

            //reset cone buttons backcolour
            regularButton.BackColor = Color.Transparent;
            waffleButton.BackColor = Color.Transparent;
            cupButton.BackColor = Color.Transparent;

            //reset topping buttons backcolour
            noneButton.BackColor = Color.Transparent;
            sprinklesButton.BackColor = Color.Transparent;
            cookieCrumbsButton.BackColor = Color.Transparent;

            //clear input textbox
            tenderedInput.Text = "";

            //enable tendered button again
            tenderedInput.Enabled = true;

            //enable calculate button again
            calculateChangeButton.Enabled = true;

            //reset calculate change button backcolour
            calculateChangeButton.BackColor = Color.Transparent;

            //reset variables
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