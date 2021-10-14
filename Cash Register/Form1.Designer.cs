
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
            this.NicolettaGoldstein = new System.Windows.Forms.Label();
            this.nicoDialogue = new System.Windows.Forms.Label();
            this.priceTotal = new System.Windows.Forms.Label();
            this.purpleOrbInput = new System.Windows.Forms.TextBox();
            this.goldOrbInput = new System.Windows.Forms.TextBox();
            this.blueOrbInput = new System.Windows.Forms.TextBox();
            this.purpleOrbLabel = new System.Windows.Forms.Label();
            this.goldOrbLabel = new System.Windows.Forms.Label();
            this.blueOrbLabel = new System.Windows.Forms.Label();
            this.recieptInput = new System.Windows.Forms.Label();
            this.redOrbPrice = new System.Windows.Forms.Label();
            this.printReceipt = new System.Windows.Forms.Label();
            this.tender = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Label();
            this.changeInput = new System.Windows.Forms.Label();
            this.newOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NicolettaGoldstein
            // 
            this.NicolettaGoldstein.BackColor = System.Drawing.Color.Transparent;
            this.NicolettaGoldstein.Image = ((System.Drawing.Image)(resources.GetObject("NicolettaGoldstein.Image")));
            this.NicolettaGoldstein.Location = new System.Drawing.Point(666, -1);
            this.NicolettaGoldstein.Name = "NicolettaGoldstein";
            this.NicolettaGoldstein.Size = new System.Drawing.Size(260, 270);
            this.NicolettaGoldstein.TabIndex = 0;
            this.NicolettaGoldstein.Text = "label1";
            // 
            // nicoDialogue
            // 
            this.nicoDialogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nicoDialogue.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicoDialogue.Location = new System.Drawing.Point(658, 273);
            this.nicoDialogue.Name = "nicoDialogue";
            this.nicoDialogue.Size = new System.Drawing.Size(286, 113);
            this.nicoDialogue.TabIndex = 1;
            this.nicoDialogue.Text = "Nico: Welcome to Devil May Cry! Ignore the freaky statue for now... So, what\'re y" +
    "a buying?";
            this.nicoDialogue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // priceTotal
            // 
            this.priceTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.priceTotal.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTotal.Location = new System.Drawing.Point(22, 264);
            this.priceTotal.Name = "priceTotal";
            this.priceTotal.Size = new System.Drawing.Size(196, 41);
            this.priceTotal.TabIndex = 16;
            this.priceTotal.Text = "Calculate Total";
            this.priceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.priceTotal.Click += new System.EventHandler(this.pricetotal_Click);
            // 
            // purpleOrbInput
            // 
            this.purpleOrbInput.Location = new System.Drawing.Point(236, 131);
            this.purpleOrbInput.Name = "purpleOrbInput";
            this.purpleOrbInput.Size = new System.Drawing.Size(95, 20);
            this.purpleOrbInput.TabIndex = 15;
            // 
            // goldOrbInput
            // 
            this.goldOrbInput.Location = new System.Drawing.Point(236, 214);
            this.goldOrbInput.Name = "goldOrbInput";
            this.goldOrbInput.Size = new System.Drawing.Size(95, 20);
            this.goldOrbInput.TabIndex = 14;
            // 
            // blueOrbInput
            // 
            this.blueOrbInput.Location = new System.Drawing.Point(236, 40);
            this.blueOrbInput.Name = "blueOrbInput";
            this.blueOrbInput.Size = new System.Drawing.Size(95, 20);
            this.blueOrbInput.TabIndex = 13;
            // 
            // purpleOrbLabel
            // 
            this.purpleOrbLabel.BackColor = System.Drawing.Color.Indigo;
            this.purpleOrbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purpleOrbLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.purpleOrbLabel.Location = new System.Drawing.Point(12, 100);
            this.purpleOrbLabel.Name = "purpleOrbLabel";
            this.purpleOrbLabel.Size = new System.Drawing.Size(218, 75);
            this.purpleOrbLabel.TabIndex = 12;
            this.purpleOrbLabel.Text = "Purple Orb Fragment 40000 Red Orbs ";
            this.purpleOrbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goldOrbLabel
            // 
            this.goldOrbLabel.BackColor = System.Drawing.Color.Gold;
            this.goldOrbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldOrbLabel.Location = new System.Drawing.Point(12, 190);
            this.goldOrbLabel.Name = "goldOrbLabel";
            this.goldOrbLabel.Size = new System.Drawing.Size(218, 61);
            this.goldOrbLabel.TabIndex = 11;
            this.goldOrbLabel.Text = "Gold Orb 10000 Red Orbs ";
            this.goldOrbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueOrbLabel
            // 
            this.blueOrbLabel.BackColor = System.Drawing.Color.Aqua;
            this.blueOrbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueOrbLabel.Location = new System.Drawing.Point(12, 16);
            this.blueOrbLabel.Name = "blueOrbLabel";
            this.blueOrbLabel.Size = new System.Drawing.Size(218, 61);
            this.blueOrbLabel.TabIndex = 10;
            this.blueOrbLabel.Text = "Blue Orb Fragment 40000 Red Orbs ";
            this.blueOrbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recieptInput
            // 
            this.recieptInput.BackColor = System.Drawing.Color.Transparent;
            this.recieptInput.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptInput.Location = new System.Drawing.Point(367, 42);
            this.recieptInput.Name = "recieptInput";
            this.recieptInput.Size = new System.Drawing.Size(247, 413);
            this.recieptInput.TabIndex = 17;
            // 
            // redOrbPrice
            // 
            this.redOrbPrice.BackColor = System.Drawing.Color.Transparent;
            this.redOrbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redOrbPrice.ForeColor = System.Drawing.Color.Black;
            this.redOrbPrice.Location = new System.Drawing.Point(23, 308);
            this.redOrbPrice.Name = "redOrbPrice";
            this.redOrbPrice.Size = new System.Drawing.Size(205, 147);
            this.redOrbPrice.TabIndex = 18;
            // 
            // printReceipt
            // 
            this.printReceipt.BackColor = System.Drawing.Color.Transparent;
            this.printReceipt.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceipt.ForeColor = System.Drawing.Color.Black;
            this.printReceipt.Location = new System.Drawing.Point(380, 486);
            this.printReceipt.Name = "printReceipt";
            this.printReceipt.Size = new System.Drawing.Size(234, 41);
            this.printReceipt.TabIndex = 19;
            this.printReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.printReceipt.Click += new System.EventHandler(this.printreceipt_Click);
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
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(162, 479);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(74, 20);
            this.tenderedInput.TabIndex = 21;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Transparent;
            this.changeButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.Black;
            this.changeButton.Location = new System.Drawing.Point(674, 403);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(239, 41);
            this.changeButton.TabIndex = 22;
            this.changeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changeButton.Click += new System.EventHandler(this.changebutton_Click);
            // 
            // changeInput
            // 
            this.changeInput.BackColor = System.Drawing.Color.Transparent;
            this.changeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeInput.Location = new System.Drawing.Point(671, 465);
            this.changeInput.Name = "changeInput";
            this.changeInput.Size = new System.Drawing.Size(242, 41);
            this.changeInput.TabIndex = 23;
            this.changeInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newOrder
            // 
            this.newOrder.BackColor = System.Drawing.Color.Transparent;
            this.newOrder.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrder.ForeColor = System.Drawing.Color.Black;
            this.newOrder.Location = new System.Drawing.Point(370, 9);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(244, 33);
            this.newOrder.TabIndex = 24;
            this.newOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newOrder.Click += new System.EventHandler(this.neworder_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 536);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.changeInput);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tender);
            this.Controls.Add(this.printReceipt);
            this.Controls.Add(this.redOrbPrice);
            this.Controls.Add(this.recieptInput);
            this.Controls.Add(this.priceTotal);
            this.Controls.Add(this.purpleOrbInput);
            this.Controls.Add(this.goldOrbInput);
            this.Controls.Add(this.blueOrbInput);
            this.Controls.Add(this.purpleOrbLabel);
            this.Controls.Add(this.goldOrbLabel);
            this.Controls.Add(this.blueOrbLabel);
            this.Controls.Add(this.nicoDialogue);
            this.Controls.Add(this.NicolettaGoldstein);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.Text = "Devil May Cry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NicolettaGoldstein;
        private System.Windows.Forms.Label nicoDialogue;
        private System.Windows.Forms.Label priceTotal;
        private System.Windows.Forms.TextBox purpleOrbInput;
        private System.Windows.Forms.TextBox goldOrbInput;
        private System.Windows.Forms.TextBox blueOrbInput;
        private System.Windows.Forms.Label purpleOrbLabel;
        private System.Windows.Forms.Label goldOrbLabel;
        private System.Windows.Forms.Label blueOrbLabel;
        private System.Windows.Forms.Label recieptInput;
        private System.Windows.Forms.Label redOrbPrice;
        private System.Windows.Forms.Label printReceipt;
        private System.Windows.Forms.Label tender;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label changeButton;
        private System.Windows.Forms.Label changeInput;
        private System.Windows.Forms.Label newOrder;
    }
}

