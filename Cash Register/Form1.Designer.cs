
namespace Cash_Register
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.nico = new System.Windows.Forms.Label();
            this.nicodialogue = new System.Windows.Forms.Label();
            this.pricetotal = new System.Windows.Forms.Label();
            this.purpleorbinput = new System.Windows.Forms.TextBox();
            this.goldorbinput = new System.Windows.Forms.TextBox();
            this.blueorbinput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.recieptinput = new System.Windows.Forms.Label();
            this.redorbprice = new System.Windows.Forms.Label();
            this.printreceipt = new System.Windows.Forms.Label();
            this.tender = new System.Windows.Forms.Label();
            this.tenderedinput = new System.Windows.Forms.TextBox();
            this.changebutton = new System.Windows.Forms.Label();
            this.changeinput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nico
            // 
            this.nico.BackColor = System.Drawing.Color.Transparent;
            this.nico.Image = ((System.Drawing.Image)(resources.GetObject("nico.Image")));
            this.nico.Location = new System.Drawing.Point(666, -1);
            this.nico.Name = "nico";
            this.nico.Size = new System.Drawing.Size(260, 270);
            this.nico.TabIndex = 0;
            this.nico.Text = "label1";
            // 
            // nicodialogue
            // 
            this.nicodialogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nicodialogue.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicodialogue.Location = new System.Drawing.Point(669, 273);
            this.nicodialogue.Name = "nicodialogue";
            this.nicodialogue.Size = new System.Drawing.Size(244, 112);
            this.nicodialogue.TabIndex = 1;
            this.nicodialogue.Text = "Nico: Welcome to Devil May Cry! Ignore the freaky statue for now... So, what\'re y" +
    "a buying?";
            this.nicodialogue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pricetotal
            // 
            this.pricetotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pricetotal.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetotal.Location = new System.Drawing.Point(22, 264);
            this.pricetotal.Name = "pricetotal";
            this.pricetotal.Size = new System.Drawing.Size(196, 41);
            this.pricetotal.TabIndex = 16;
            this.pricetotal.Text = "Calculate Total";
            this.pricetotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pricetotal.Click += new System.EventHandler(this.pricetotal_Click);
            // 
            // purpleorbinput
            // 
            this.purpleorbinput.Location = new System.Drawing.Point(236, 131);
            this.purpleorbinput.Name = "purpleorbinput";
            this.purpleorbinput.Size = new System.Drawing.Size(95, 20);
            this.purpleorbinput.TabIndex = 15;
            // 
            // goldorbinput
            // 
            this.goldorbinput.Location = new System.Drawing.Point(236, 214);
            this.goldorbinput.Name = "goldorbinput";
            this.goldorbinput.Size = new System.Drawing.Size(95, 20);
            this.goldorbinput.TabIndex = 14;
            // 
            // blueorbinput
            // 
            this.blueorbinput.Location = new System.Drawing.Point(236, 40);
            this.blueorbinput.Name = "blueorbinput";
            this.blueorbinput.Size = new System.Drawing.Size(95, 20);
            this.blueorbinput.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Indigo;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 75);
            this.label6.TabIndex = 12;
            this.label6.Text = "Purple Orb Fragment 40000 Red Orbs ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 61);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gold Orb 10000 Red Orbs ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Aqua;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 61);
            this.label3.TabIndex = 10;
            this.label3.Text = "Blue Orb Fragment 40000 Red Orbs ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recieptinput
            // 
            this.recieptinput.BackColor = System.Drawing.Color.Transparent;
            this.recieptinput.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptinput.Location = new System.Drawing.Point(366, 9);
            this.recieptinput.Name = "recieptinput";
            this.recieptinput.Size = new System.Drawing.Size(248, 446);
            this.recieptinput.TabIndex = 17;
            // 
            // redorbprice
            // 
            this.redorbprice.BackColor = System.Drawing.Color.Transparent;
            this.redorbprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redorbprice.ForeColor = System.Drawing.Color.Black;
            this.redorbprice.Location = new System.Drawing.Point(23, 308);
            this.redorbprice.Name = "redorbprice";
            this.redorbprice.Size = new System.Drawing.Size(205, 147);
            this.redorbprice.TabIndex = 18;
            // 
            // printreceipt
            // 
            this.printreceipt.BackColor = System.Drawing.Color.Transparent;
            this.printreceipt.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printreceipt.ForeColor = System.Drawing.Color.Black;
            this.printreceipt.Location = new System.Drawing.Point(380, 464);
            this.printreceipt.Name = "printreceipt";
            this.printreceipt.Size = new System.Drawing.Size(234, 41);
            this.printreceipt.TabIndex = 19;
            this.printreceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.printreceipt.Click += new System.EventHandler(this.printreceipt_Click);
            // 
            // tender
            // 
            this.tender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tender.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tender.Location = new System.Drawing.Point(24, 465);
            this.tender.Name = "tender";
            this.tender.Size = new System.Drawing.Size(126, 41);
            this.tender.TabIndex = 20;
            this.tender.Text = "Tendered";
            this.tender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tender.Click += new System.EventHandler(this.tender_Click);
            // 
            // tenderedinput
            // 
            this.tenderedinput.Location = new System.Drawing.Point(162, 479);
            this.tenderedinput.Name = "tenderedinput";
            this.tenderedinput.Size = new System.Drawing.Size(74, 20);
            this.tenderedinput.TabIndex = 21;
            // 
            // changebutton
            // 
            this.changebutton.BackColor = System.Drawing.Color.Transparent;
            this.changebutton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changebutton.ForeColor = System.Drawing.Color.Black;
            this.changebutton.Location = new System.Drawing.Point(674, 403);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(239, 41);
            this.changebutton.TabIndex = 22;
            this.changebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changebutton.Click += new System.EventHandler(this.changebutton_Click);
            // 
            // changeinput
            // 
            this.changeinput.BackColor = System.Drawing.Color.Transparent;
            this.changeinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeinput.Location = new System.Drawing.Point(671, 465);
            this.changeinput.Name = "changeinput";
            this.changeinput.Size = new System.Drawing.Size(242, 41);
            this.changeinput.TabIndex = 23;
            this.changeinput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 536);
            this.Controls.Add(this.changeinput);
            this.Controls.Add(this.changebutton);
            this.Controls.Add(this.tenderedinput);
            this.Controls.Add(this.tender);
            this.Controls.Add(this.printreceipt);
            this.Controls.Add(this.redorbprice);
            this.Controls.Add(this.recieptinput);
            this.Controls.Add(this.pricetotal);
            this.Controls.Add(this.purpleorbinput);
            this.Controls.Add(this.goldorbinput);
            this.Controls.Add(this.blueorbinput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nicodialogue);
            this.Controls.Add(this.nico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nico;
        private System.Windows.Forms.Label nicodialogue;
        private System.Windows.Forms.Label pricetotal;
        private System.Windows.Forms.TextBox purpleorbinput;
        private System.Windows.Forms.TextBox goldorbinput;
        private System.Windows.Forms.TextBox blueorbinput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label recieptinput;
        private System.Windows.Forms.Label redorbprice;
        private System.Windows.Forms.Label printreceipt;
        private System.Windows.Forms.Label tender;
        private System.Windows.Forms.TextBox tenderedinput;
        private System.Windows.Forms.Label changebutton;
        private System.Windows.Forms.Label changeinput;
    }
}

