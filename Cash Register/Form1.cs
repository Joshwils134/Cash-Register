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
        double blueorb;
        double purpleorb;
        double goldorb;
        double blueorbprice;
        double purpleorbprice;
        double goldorbprice;
        double totalblueorbprice;
        double totalpurpleorbprice;
        double totalgoldorbprice;
        double subtotal;
        double taxrate;
        double taxamount;
        double totalredorb;
        double redorbs;
        double tendered;
        double change;
        double taxtotal;
        public form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {


        }

        private void pricetotal_Click(object sender, EventArgs e)
        {
            try
            {
                blueorb = Convert.ToInt32(blueorbinput.Text);
                purpleorb = Convert.ToInt32(purpleorbinput.Text);
                goldorb = Convert.ToInt32(goldorbinput.Text);
                blueorbprice = 40000;
                purpleorbprice = 40000;
                goldorbprice = 10000;
                totalblueorbprice = blueorb * blueorbprice;
                totalpurpleorbprice = purpleorb * purpleorbprice;
                totalgoldorbprice = goldorb * goldorbprice;
                subtotal = totalblueorbprice + totalpurpleorbprice + totalgoldorbprice;
                taxrate = 0.13;
                taxamount = subtotal * + taxrate;
                taxtotal = subtotal * (1+ taxrate) - subtotal;
                redorbs = subtotal;
                totalredorb = subtotal * (1 + taxrate);
                redorbprice.BackColor = Color.WhiteSmoke;
                redorbprice.Text = $"Cost:{redorbs} Red Orbs \n\nTax:{taxrate}% \n\nTax Amount:{taxtotal} \n\nTotal:{totalredorb} Red Orbs";
                nicodialogue.Text = $"Nico: Sounds good. So, how're ya paying? I'm just kidding with ya, we only take Red Orbs here.";
                   
            }
            catch
            {
                nicodialogue.Text = $"Nico: You're gonna need to buy something. I know I'm nice on the eyes, but I've got a business to run.";
            }
        }

        private void printreceipt_Click(object sender, EventArgs e)
        {
                SoundPlayer player = new SoundPlayer(Properties.Resources.receiptprint);
                player.Play();
                neworder.BackColor = Color.WhiteSmoke;
                neworder.Text = $"New Order";
                recieptinput.BackColor = Color.White;
                nicodialogue.Text = $"Nico: Here's your reciept! Come again!";
                recieptinput.Text = $"\nDevil May Cry";
                Refresh();
                Thread.Sleep(150);
                recieptinput.Text += $"\nOrder Number:111\n---------------------------------------------";
                Refresh();
                Thread.Sleep(150);
                recieptinput.Text += $"\nBlue Orb Fragment      X {blueorb}   {totalblueorbprice} ";
                Refresh();
                Thread.Sleep(150);
                recieptinput.Text += $"\nPurple Orb Fragment X {purpleorb}   {totalpurpleorbprice}";
                Refresh();
                Thread.Sleep(150);
                recieptinput.Text += $"\nGold Orb                             X {goldorb}   {totalgoldorbprice} ";
                Refresh();
                Thread.Sleep(150);
                recieptinput.Text += $"\n\nSubtotal: {subtotal} Red Orbs";
                Refresh();
                Thread.Sleep(150);
                recieptinput.Text += $"\n\nTax: 13%";
                Refresh();
                Thread.Sleep(150);
                recieptinput.Text += $"\n\nTax Amount: {taxtotal} Red Orbs";
                Refresh();
                Thread.Sleep(150);
                recieptinput.Text += $"\n\nTotal:{totalredorb} Red Orbs";
                Refresh();
                Thread.Sleep(150);
                recieptinput.Text += $"\n\nTendered:{tendered} Red Orbs";
                Refresh();
                Thread.Sleep(150);
                recieptinput.Text += $"\n\nChange:{change.ToString("0.00")} Red Orbs";
                Refresh();
                Thread.Sleep(150);
                recieptinput.Text += $"\n\nThanks for shopping at Devil May Cry! Our arsenal make the Angels scream and the Devil cry!";
        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            try
            {
                blueorb = Convert.ToInt32(blueorbinput.Text);
                purpleorb = Convert.ToInt32(purpleorbinput.Text);
                goldorb = Convert.ToInt32(goldorbinput.Text);
                totalblueorbprice = blueorb * blueorbprice;
                totalpurpleorbprice = purpleorb * purpleorbprice;
                totalgoldorbprice = goldorb * goldorbprice;
                subtotal = totalblueorbprice + totalpurpleorbprice + totalgoldorbprice;
                taxrate = 0.13;
                taxamount = subtotal * +taxrate;
                redorbs = subtotal;
                totalredorb = subtotal * (1 + taxrate);
                tendered = Convert.ToInt32(tenderedinput.Text);
                nicodialogue.Text = $"Nico: Well aren't you a big spender? Alright, grab your receipt buddy.";
                change = tendered - totalredorb;
                changeinput.BackColor = Color.WhiteSmoke;
                changeinput.Text = $"Change Due:{change.ToString("0.00")}";
                printreceipt.BackColor = Color.WhiteSmoke;
                printreceipt.Text = "Print Receipt";
            }
        catch
            { nicodialogue.Text = $"Nico: You ain't got red orbs? Then you ain't getting your stuff!"; }
        }

        private void tender_Click(object sender, EventArgs e)
        {
            changebutton.BackColor = BackColor = Color.WhiteSmoke;
            changebutton.Text = "Calculate Change";
        }

        private void neworder_Click(object sender, EventArgs e)
        {
            nicodialogue.Text = $"Nico: Take care! Don't die out there!";
            Refresh();
            Thread.Sleep(30);
            Application.Restart();
            Environment.Exit(0);
            
        }
    }
}
