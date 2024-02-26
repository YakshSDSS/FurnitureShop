namespace FurnitureShop
{
    partial class furnitureShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(furnitureShop));
            this.titleLabel = new System.Windows.Forms.Label();
            this.couchesLabel = new System.Windows.Forms.Label();
            this.chairsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.couchesInput = new System.Windows.Forms.TextBox();
            this.chairsInput = new System.Windows.Forms.TextBox();
            this.tablesInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxAmountLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxAmountOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.emptyLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.backgroundLabel2 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.receipt = new System.Windows.Forms.Label();
            this.errorLabel1 = new System.Windows.Forms.Label();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.newOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Yellow;
            this.titleLabel.Location = new System.Drawing.Point(0, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(273, 39);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Funiture Shop 🪓";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // couchesLabel
            // 
            this.couchesLabel.AutoSize = true;
            this.couchesLabel.ForeColor = System.Drawing.Color.Gold;
            this.couchesLabel.Location = new System.Drawing.Point(15, 83);
            this.couchesLabel.Name = "couchesLabel";
            this.couchesLabel.Size = new System.Drawing.Size(164, 21);
            this.couchesLabel.TabIndex = 1;
            this.couchesLabel.Text = "Number of Couches";
            // 
            // chairsLabel
            // 
            this.chairsLabel.AutoSize = true;
            this.chairsLabel.Location = new System.Drawing.Point(15, 138);
            this.chairsLabel.Name = "chairsLabel";
            this.chairsLabel.Size = new System.Drawing.Size(146, 21);
            this.chairsLabel.TabIndex = 2;
            this.chairsLabel.Text = "Number of Chairs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Tables";
            // 
            // couchesInput
            // 
            this.couchesInput.BackColor = System.Drawing.Color.Red;
            this.couchesInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.couchesInput.ForeColor = System.Drawing.Color.White;
            this.couchesInput.Location = new System.Drawing.Point(197, 81);
            this.couchesInput.Name = "couchesInput";
            this.couchesInput.Size = new System.Drawing.Size(55, 29);
            this.couchesInput.TabIndex = 4;
            this.couchesInput.TextChanged += new System.EventHandler(this.couchesInput_TextChanged);
            // 
            // chairsInput
            // 
            this.chairsInput.BackColor = System.Drawing.Color.Red;
            this.chairsInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chairsInput.ForeColor = System.Drawing.Color.White;
            this.chairsInput.Location = new System.Drawing.Point(197, 136);
            this.chairsInput.Name = "chairsInput";
            this.chairsInput.Size = new System.Drawing.Size(55, 29);
            this.chairsInput.TabIndex = 5;
            // 
            // tablesInput
            // 
            this.tablesInput.BackColor = System.Drawing.Color.Red;
            this.tablesInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablesInput.ForeColor = System.Drawing.Color.White;
            this.tablesInput.Location = new System.Drawing.Point(197, 196);
            this.tablesInput.Name = "tablesInput";
            this.tablesInput.Size = new System.Drawing.Size(55, 29);
            this.tablesInput.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Red;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.ForeColor = System.Drawing.Color.Yellow;
            this.calculateButton.Location = new System.Drawing.Point(19, 287);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(233, 45);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(284, 9);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(74, 21);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // taxAmountLabel
            // 
            this.taxAmountLabel.AutoSize = true;
            this.taxAmountLabel.Location = new System.Drawing.Point(284, 46);
            this.taxAmountLabel.Name = "taxAmountLabel";
            this.taxAmountLabel.Size = new System.Drawing.Size(103, 21);
            this.taxAmountLabel.TabIndex = 12;
            this.taxAmountLabel.Text = "Tax Amount";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(284, 83);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 21);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "Total";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.Color.Red;
            this.subtotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotalOutput.Location = new System.Drawing.Point(402, 8);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(83, 27);
            this.subtotalOutput.TabIndex = 14;
            // 
            // taxAmountOutput
            // 
            this.taxAmountOutput.BackColor = System.Drawing.Color.Red;
            this.taxAmountOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxAmountOutput.Location = new System.Drawing.Point(402, 45);
            this.taxAmountOutput.Name = "taxAmountOutput";
            this.taxAmountOutput.Size = new System.Drawing.Size(83, 27);
            this.taxAmountOutput.TabIndex = 15;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.Red;
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutput.Location = new System.Drawing.Point(402, 82);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(83, 27);
            this.totalOutput.TabIndex = 16;
            // 
            // emptyLabel
            // 
            this.emptyLabel.BackColor = System.Drawing.Color.Gold;
            this.emptyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emptyLabel.Location = new System.Drawing.Point(261, -11);
            this.emptyLabel.Name = "emptyLabel";
            this.emptyLabel.Size = new System.Drawing.Size(17, 370);
            this.emptyLabel.TabIndex = 17;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(284, 150);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(82, 21);
            this.tenderedLabel.TabIndex = 18;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.BackColor = System.Drawing.Color.Red;
            this.tenderedInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tenderedInput.ForeColor = System.Drawing.Color.White;
            this.tenderedInput.Location = new System.Drawing.Point(402, 148);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(83, 29);
            this.tenderedInput.TabIndex = 19;
            // 
            // backgroundLabel2
            // 
            this.backgroundLabel2.BackColor = System.Drawing.Color.Gold;
            this.backgroundLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundLabel2.Location = new System.Drawing.Point(288, 118);
            this.backgroundLabel2.Name = "backgroundLabel2";
            this.backgroundLabel2.Size = new System.Drawing.Size(197, 17);
            this.backgroundLabel2.TabIndex = 20;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Red;
            this.changeButton.Enabled = false;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.ForeColor = System.Drawing.Color.Yellow;
            this.changeButton.Location = new System.Drawing.Point(288, 186);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(197, 33);
            this.changeButton.TabIndex = 21;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(284, 231);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(69, 21);
            this.changeLabel.TabIndex = 22;
            this.changeLabel.Text = "Change";
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.Red;
            this.receiptButton.Enabled = false;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.ForeColor = System.Drawing.Color.Yellow;
            this.receiptButton.Location = new System.Drawing.Point(288, 299);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(197, 33);
            this.receiptButton.TabIndex = 24;
            this.receiptButton.Text = "Print receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // receipt
            // 
            this.receipt.BackColor = System.Drawing.Color.White;
            this.receipt.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt.ForeColor = System.Drawing.Color.Black;
            this.receipt.Location = new System.Drawing.Point(510, 9);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(273, 288);
            this.receipt.TabIndex = 25;
            // 
            // errorLabel1
            // 
            this.errorLabel1.AutoSize = true;
            this.errorLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel1.ForeColor = System.Drawing.Color.White;
            this.errorLabel1.Location = new System.Drawing.Point(14, 243);
            this.errorLabel1.Name = "errorLabel1";
            this.errorLabel1.Size = new System.Drawing.Size(0, 21);
            this.errorLabel1.TabIndex = 26;
            // 
            // errorLabel2
            // 
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel2.ForeColor = System.Drawing.Color.White;
            this.errorLabel2.Location = new System.Drawing.Point(293, 268);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(0, 21);
            this.errorLabel2.TabIndex = 27;
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.Red;
            this.changeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changeOutput.Location = new System.Drawing.Point(402, 230);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(83, 27);
            this.changeOutput.TabIndex = 28;
            // 
            // newOrder
            // 
            this.newOrder.BackColor = System.Drawing.Color.Red;
            this.newOrder.Enabled = false;
            this.newOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrder.ForeColor = System.Drawing.Color.Yellow;
            this.newOrder.Location = new System.Drawing.Point(549, 299);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(197, 33);
            this.newOrder.TabIndex = 29;
            this.newOrder.Text = "New Order";
            this.newOrder.UseVisualStyleBackColor = false;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // furnitureShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(812, 337);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.errorLabel2);
            this.Controls.Add(this.errorLabel1);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.backgroundLabel2);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.emptyLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxAmountOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxAmountLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.tablesInput);
            this.Controls.Add(this.chairsInput);
            this.Controls.Add(this.couchesInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chairsLabel);
            this.Controls.Add(this.couchesLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "furnitureShop";
            this.Text = "Funiture Shop";
            this.Load += new System.EventHandler(this.furnitureShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label couchesLabel;
        private System.Windows.Forms.Label chairsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox couchesInput;
        private System.Windows.Forms.TextBox chairsInput;
        private System.Windows.Forms.TextBox tablesInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxAmountLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxAmountOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label emptyLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label backgroundLabel2;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label receipt;
        private System.Windows.Forms.Label errorLabel1;
        private System.Windows.Forms.Label errorLabel2;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button newOrder;
    }
}

