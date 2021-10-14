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

namespace Cash_Register
{
    public partial class form1 : Form
    {

        double blueOrb;
        double purpleOrb;
        double goldOrb;
        double blueOrbPrice;
        double purpleOrbPrice;
        double goldOrbPrice;
        double totalblueOrbPrice;
        double totalpurpleOrbPrice;
        double totalgoldOrbPrice;
        double subTotal;
        double taxRate;
        double taxAmount;
        double totalredOrb;
        double redOrbs;
        double tendered;
        double change;
        double taxTotal;
        Random randGen = new Random();
        int orderNumber;
        public form1()
        {
            InitializeComponent();
        }

        private void pricetotal_Click(object sender, EventArgs e)
        {
            try
            {
                //Calculate the cost of items purchased.

                blueOrb = Convert.ToInt32(blueOrbInput.Text);
                purpleOrb = Convert.ToInt32(purpleOrbInput.Text);
                goldOrb = Convert.ToInt32(goldOrbInput.Text);
                blueOrbPrice = 40000;
                purpleOrbPrice = 40000;
                goldOrbPrice = 10000;
                totalblueOrbPrice = blueOrb * blueOrbPrice;
                totalpurpleOrbPrice = purpleOrb * purpleOrbPrice;
                totalgoldOrbPrice = goldOrb * goldOrbPrice;
                subTotal = totalblueOrbPrice + totalpurpleOrbPrice + totalgoldOrbPrice;
                taxRate = 0.13;
                taxAmount = subTotal * +taxRate;
                taxTotal = subTotal * (1 + taxRate) - subTotal;
                redOrbs = subTotal;
                totalredOrb = subTotal * (1 + taxRate);
                redOrbPrice.BackColor = Color.WhiteSmoke;
                redOrbPrice.Text = $"Cost:{redOrbs} Red Orbs \n\nTax:{taxRate}% \n\nTax Amount:{taxTotal.ToString("0.00")} \n\nTotal:{totalredOrb} Red Orbs";
                
                nicoDialogue.Text = $"Nico: Sounds good. So, how're ya paying? I'm just kidding with ya, we only take Red Orbs here.";

            }
            catch
            {
                nicoDialogue.Text = $"Nico: You're gonna need to buy something. I know I'm nice on the eyes, but I've got a business to run.";
            }
        }

        private void printreceipt_Click(object sender, EventArgs e)
        {
            //Printing Receipt

            SoundPlayer player = new SoundPlayer(Properties.Resources.receiptprint);
            player.Play();
            newOrder.BackColor = Color.WhiteSmoke;
            newOrder.Text = $"New Order";
            recieptInput.BackColor = Color.White;
            orderNumber = randGen.Next(1, 116);
            nicoDialogue.Text = $"Nico: Here's your reciept! Come again!";
            recieptInput.Text = $"\nDevil May Cry";
            Refresh();
            Thread.Sleep(220);

            recieptInput.Text += $"\nOrder Number:{orderNumber}\n---------------------------------------------";
            Refresh();
            Thread.Sleep(220);

            recieptInput.Text += $"\nBlue Orb Fragment      X {blueOrb}   {totalblueOrbPrice} ";
            Refresh();
            Thread.Sleep(220);

            recieptInput.Text += $"\nPurple Orb Fragment X {purpleOrb}   {totalpurpleOrbPrice}";
            Refresh();
            Thread.Sleep(220);

            recieptInput.Text += $"\nGold Orb                             X {goldOrb}   {totalgoldOrbPrice} ";
            Refresh();
            Thread.Sleep(220);

            recieptInput.Text += $"\n\nSubtotal: {subTotal} Red Orbs";
            Refresh();
            Thread.Sleep(220);

            recieptInput.Text += $"\n\nTax: 13%";
            Refresh();
            Thread.Sleep(220);

            recieptInput.Text += $"\n\nTax Amount: {taxTotal.ToString("0.00")} Red Orbs";
            Refresh();
            Thread.Sleep(220);

            recieptInput.Text += $"\n\nTotal:{totalredOrb} Red Orbs";
            Refresh();
            Thread.Sleep(220);

            recieptInput.Text += $"\n\nTendered:{tendered} Red Orbs";
            Refresh();
            Thread.Sleep(220);

            recieptInput.Text += $"\n\nChange:{change.ToString("0.00")} Red Orbs";
            Refresh();
            Thread.Sleep(220);

            recieptInput.Text += $"\n\nThanks for shopping at Devil May Cry! Our arsenal make the Angels scream and the Devil cry!";
        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            try
            {
                //Calculating Change.

                blueOrb = Convert.ToInt32(blueOrbInput.Text);
                purpleOrb = Convert.ToInt32(purpleOrbInput.Text);
                goldOrb = Convert.ToInt32(goldOrbInput.Text);
                totalblueOrbPrice = blueOrb * blueOrbPrice;
                totalpurpleOrbPrice = purpleOrb * purpleOrbPrice;
                totalgoldOrbPrice = goldOrb * goldOrbPrice;
                subTotal = totalblueOrbPrice + totalpurpleOrbPrice + totalgoldOrbPrice;
                taxRate = 0.13;
                taxAmount = subTotal * +taxRate;
                redOrbs = subTotal;
                totalredOrb = subTotal * (1 + taxRate);
                tendered = Convert.ToInt32(tenderedInput.Text);
                nicoDialogue.Text = $"Nico: Well aren't you a big spender? Alright, grab your receipt buddy.";
                change = tendered - totalredOrb;
                changeInput.BackColor = Color.WhiteSmoke;
                changeInput.Text = $"Change Due:{change.ToString("0.00")}";
                printReceipt.BackColor = Color.WhiteSmoke;
                printReceipt.Text = "Print Receipt";
            }
            catch
            { nicoDialogue.Text = $"Nico: You ain't got red orbs? Then you ain't getting your stuff!"; }
        }

        private void tender_Click(object sender, EventArgs e)
        {
            //Display Change Button

            changeButton.BackColor = BackColor = Color.WhiteSmoke;
            changeButton.Text = "Calculate Change";
        }

        private void neworder_Click(object sender, EventArgs e)
        {
            //Begin New Order

            nicoDialogue.Text = $"Nico: Take care! Don't die out there!";
            Refresh();
            Thread.Sleep(300);
            Application.Restart();
            Environment.Exit(0);

        }
    }
}
