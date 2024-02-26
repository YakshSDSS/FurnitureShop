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
        double chairprice = 49.99;
        double couchprice = 299.99;
        double tableprice = 99.99;

        double chairamount;
        double couchamount;
        double tableamount;

        double tendered;
        double change;

        double chairtotal;
        double couchtotal;
        double tabletotal;

        double subtotal;
        double taxrate = .13;
        double tax;
        double total;

        SoundPlayer error = new SoundPlayer(Properties.Resources.Error_Sound);
        SoundPlayer print = new SoundPlayer(Properties.Resources.Print_Sound);
        public furnitureShop()
        {
            InitializeComponent();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void couchesInput_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            

            try
            {
                chairamount = Convert.ToDouble(chairsInput.Text);
                couchamount = Convert.ToDouble(couchesInput.Text);
                tableamount = Convert.ToDouble(tablesInput.Text);

                chairtotal = chairamount * chairprice;
                couchtotal = couchprice * couchamount;
                tabletotal = tableprice * tableamount;

                errorLabel1.Text = "";
                error.Stop();
                changeButton.Enabled = true;
            }

            catch
            {
                error.Play();
                errorLabel1.Text = "Error. Please Buy More.";
                
             
            }
            subtotal = chairtotal + couchtotal + tabletotal;
            tax = subtotal * taxrate;
            total = tax + subtotal;


            subtotalOutput.Text = subtotal.ToString("C");
            taxAmountOutput.Text = tax.ToString("C");
            totalOutput.Text = total.ToString("C");


          

           
        }

        private void furnitureShop_Load(object sender, EventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
       

            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);
                errorLabel2.Text = "";
                error.Stop();
            }
            catch
            {
                errorLabel2.Text = "Please enter a valid amount";
                error.Play();
                receiptButton.Enabled = false;
            }

            change = tendered - total;
            changeOutput.Text = change.ToString("C");

            if (tendered < total)
            { 
                errorLabel2.Text = $"{tendered} is not enough";
                error.Play();
                receipt.Enabled=false;
            }
            else if (tendered > total)
            {
                errorLabel2.Text = "";
                error.Stop();
                receiptButton.Enabled = true;
            }

           
            }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            print.PlayLooping();

            receipt.Text = $"Furniture Shop";

            Thread.Sleep(500);
            Refresh();
            receipt.Text += $"\n\nOrder Number: 1023";

            Thread.Sleep(500);
            Refresh();
            receipt.Text += $"\nFebruary 22, 2024";

            Thread.Sleep(500);
            Refresh();
            receipt.Text += $"\n\nCouches x{couchamount}  @ {couchprice.ToString("C")}";
            
            Thread.Sleep(500);
            Refresh();
            receipt.Text += $"\nChairs x{chairamount}   @ {chairprice.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receipt.Text += $"\nTables x{tableamount}   @ {tableprice.ToString("C")}";

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

            print.Stop();

            newOrder.Enabled = true;
        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            couchesInput.Clear();
            chairsInput.Clear();
            tablesInput.Clear();
            subtotalOutput.Text = "";
            taxAmountOutput.Text = "";
            totalOutput.Text = "";
            tenderedInput.Clear();
            changeOutput.Text = "";
            receipt.Text = "";
            changeButton.Enabled = false;
            receiptButton.Enabled = false;
            newOrder.Enabled = false;
            errorLabel1.Text = "";
            errorLabel2.Text = "";
            subtotal = 0;
            tax = 0;
            total = 0;
            chairtotal = 0;
            couchtotal = 0;
            tabletotal = 0;
        }
    }
    }

