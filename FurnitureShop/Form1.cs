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

namespace FurnitureShop
{
    public partial class furnitureShop : Form
    {
        double chairPrice = 49.99;
        double couchPrice = 299.99;
        double tablePrice = 99.99;

        double chairAmount;
        double couchAmount;
        double tableAmount;

        double tendered;
        double change;

        double chairTotal;
        double couchTotal;
        double tableTotal;

        double subtotal;
        double taxrate = .13;
        double tax;
        double total;

        SoundPlayer errorSound = new SoundPlayer(Properties.Resources.Error_Sound);
        SoundPlayer printSound = new SoundPlayer(Properties.Resources.Print_Sound);
        public furnitureShop()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                chairAmount = Convert.ToDouble(chairsInput.Text);
                couchAmount = Convert.ToDouble(couchesInput.Text);
                tableAmount = Convert.ToDouble(tablesInput.Text);

                chairTotal = chairPrice * chairAmount;
                couchTotal = couchPrice * couchAmount;
                tableTotal = tablePrice * tableAmount;

                errorLabel1.Text = "";
                errorSound.Stop();
                changeButton.Enabled = true;
            }
            catch
            {
                errorSound.Play();
                errorLabel1.Text = "Error. Please Buy More.";
            }

            subtotal = chairTotal + couchTotal + tableTotal;
            tax = subtotal * taxrate;
            total = tax + subtotal;

            subtotalOutput.Text = subtotal.ToString("C");
            taxAmountOutput.Text = tax.ToString("C");
            totalOutput.Text = total.ToString("C");
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);
                errorLabel2.Text = "";
                errorSound.Stop();
            }
            catch
            {
                errorLabel2.Text = "Please enter a valid amount";
                errorSound.Play();
                receiptButton.Enabled = false;
            }

            change = tendered - total;
            changeOutput.Text = change.ToString("C");

            if (tendered < total)
            { 
                errorLabel2.Text = $"{tendered} is not enough";
                errorSound.Play();
                receiptButton.Enabled=false;
            }
            else if (tendered > total)
            {
                errorLabel2.Text = "";
                errorSound.Stop();
                receiptButton.Enabled = true;
            }
            }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            printSound.PlayLooping();
            receipt.Text = $"Furniture Shop";

            Thread.Sleep(500);
            Refresh();
            receipt.Text += $"\n\nOrder Number: 1023";

            Thread.Sleep(500);
            Refresh();
            receipt.Text += $"\nFebruary 22, 2024";

            Thread.Sleep(500);
            Refresh();
            receipt.Text += $"\n\nCouches x{couchAmount}  @ {couchPrice.ToString("C")}";
            
            Thread.Sleep(500);
            Refresh();
            receipt.Text += $"\nChairs x{chairAmount}   @ {chairPrice.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receipt.Text += $"\nTables x{tableAmount}   @ {tablePrice.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receipt.Text += $"\n\nSubtotal:     {subtotal.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receipt.Text += $"\nTax Amount:   {tax.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receipt.Text += $"\nTotal:        {total.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receipt.Text += $"\n\nTendered:     {tendered.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receipt.Text += $"\nChange:       {change.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receipt.Text += $"\n\nHave A Great Day :)";

            printSound.Stop();
            newOrder.Enabled = true;
        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            couchesInput.Clear();
            chairsInput.Clear();
            tablesInput.Clear();
            tenderedInput.Clear();

            subtotalOutput.Text = "";
            taxAmountOutput.Text = "";
            totalOutput.Text = "";
            errorLabel1.Text = "";
            errorLabel2.Text = "";
            changeOutput.Text = "";
            receipt.Text = "";

            changeButton.Enabled = false;
            receiptButton.Enabled = false;
            newOrder.Enabled = false;

            subtotal = 0;
            tax = 0;
            total = 0;
            chairTotal = 0;
            couchTotal = 0;
            tableTotal = 0;
        }
    }
    }

