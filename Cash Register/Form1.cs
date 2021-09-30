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
                nicodialogue.Text = $"Nico: Sounds good. How're ya paying? Just kidding, we only take Red Orbs here.";
                   
            }
            catch
            { }
        }

        private void printreceipt_Click(object sender, EventArgs e)
        {
            recieptinput.BackColor = Color.White;
            recieptinput.Text = $"\nDevil May Cry";
            Refresh();
            thread.sleep
            recieptinput.Text += $"\nOrder Number:111\n---------------------------------------------";
            recieptinput.Text += $"\nBlue Orb Fragment X {blueorb}     {totalblueorbprice} ";
            recieptinput.Text += $"\nPurple Orb Fragment X {purpleorb}  {totalpurpleorbprice}";
            recieptinput.Text += $"\nGold Orb                             X {goldorb}   {totalgoldorbprice} ";
            recieptinput.Text += $"\n\nSubtotal: {subtotal} Red Orbs";

        }

        private void changebutton_Click(object sender, EventArgs e)
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
            changeinput.Text = $"Change Due:{change} Red Orbs";
            printreceipt.BackColor = Color.WhiteSmoke;
            printreceipt.Text = "Print Receipt";
        }

        private void tender_Click(object sender, EventArgs e)
        {
            changebutton.BackColor = BackColor = Color.WhiteSmoke;
            changebutton.Text = "Calculate Change";
        }
    }
}
