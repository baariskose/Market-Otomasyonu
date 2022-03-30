namespace MarketDataForm
{
    partial class Balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balance));
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.tbxOrderId = new System.Windows.Forms.TextBox();
            this.tbxTotalPrice = new System.Windows.Forms.TextBox();
            this.tbxTotalCostPrice = new System.Windows.Forms.TextBox();
            this.tbxProfit = new System.Windows.Forms.TextBox();
            this.tbxAllPrice = new System.Windows.Forms.TextBox();
            this.tbxAllCost = new System.Windows.Forms.TextBox();
            this.tbxAllProfit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(63)))), ((int)(((byte)(90)))));
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.GridColor = System.Drawing.Color.DarkCyan;
            this.dgwProducts.Location = new System.Drawing.Point(1, 63);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.ReadOnly = true;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(799, 190);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // tbxOrderId
            // 
            this.tbxOrderId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxOrderId.Location = new System.Drawing.Point(44, 303);
            this.tbxOrderId.Name = "tbxOrderId";
            this.tbxOrderId.ReadOnly = true;
            this.tbxOrderId.Size = new System.Drawing.Size(112, 32);
            this.tbxOrderId.TabIndex = 1;
            this.tbxOrderId.TextChanged += new System.EventHandler(this.tbxOrderId_TextChanged);
            // 
            // tbxTotalPrice
            // 
            this.tbxTotalPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTotalPrice.Location = new System.Drawing.Point(244, 303);
            this.tbxTotalPrice.Name = "tbxTotalPrice";
            this.tbxTotalPrice.ReadOnly = true;
            this.tbxTotalPrice.Size = new System.Drawing.Size(112, 32);
            this.tbxTotalPrice.TabIndex = 2;
            this.tbxTotalPrice.TextChanged += new System.EventHandler(this.tbxTotalPrice_TextChanged);
            // 
            // tbxTotalCostPrice
            // 
            this.tbxTotalCostPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTotalCostPrice.Location = new System.Drawing.Point(443, 303);
            this.tbxTotalCostPrice.Name = "tbxTotalCostPrice";
            this.tbxTotalCostPrice.ReadOnly = true;
            this.tbxTotalCostPrice.Size = new System.Drawing.Size(112, 32);
            this.tbxTotalCostPrice.TabIndex = 3;
            this.tbxTotalCostPrice.TextChanged += new System.EventHandler(this.tbxTotalCostPrice_TextChanged);
            // 
            // tbxProfit
            // 
            this.tbxProfit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxProfit.Location = new System.Drawing.Point(642, 303);
            this.tbxProfit.Name = "tbxProfit";
            this.tbxProfit.ReadOnly = true;
            this.tbxProfit.Size = new System.Drawing.Size(112, 32);
            this.tbxProfit.TabIndex = 4;
            this.tbxProfit.TextChanged += new System.EventHandler(this.tbxProfit_TextChanged);
            // 
            // tbxAllPrice
            // 
            this.tbxAllPrice.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAllPrice.Location = new System.Drawing.Point(152, 391);
            this.tbxAllPrice.Name = "tbxAllPrice";
            this.tbxAllPrice.ReadOnly = true;
            this.tbxAllPrice.Size = new System.Drawing.Size(136, 44);
            this.tbxAllPrice.TabIndex = 5;
            // 
            // tbxAllCost
            // 
            this.tbxAllCost.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAllCost.Location = new System.Drawing.Point(430, 391);
            this.tbxAllCost.Name = "tbxAllCost";
            this.tbxAllCost.ReadOnly = true;
            this.tbxAllCost.Size = new System.Drawing.Size(133, 44);
            this.tbxAllCost.TabIndex = 6;
            // 
            // tbxAllProfit
            // 
            this.tbxAllProfit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAllProfit.Location = new System.Drawing.Point(642, 391);
            this.tbxAllProfit.Name = "tbxAllProfit";
            this.tbxAllProfit.ReadOnly = true;
            this.tbxAllProfit.Size = new System.Drawing.Size(146, 44);
            this.tbxAllProfit.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sipariş No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(240, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kazanç:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(439, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Maliyet:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(638, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bilanço:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Toplam Kazanç:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(290, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Toplam Maliyet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(565, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bilanço:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(104)))), ((int)(((byte)(101)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(18, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(51, 51);
            this.btnBack.TabIndex = 45;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Stencil Std", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label8.Location = new System.Drawing.Point(90, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(703, 50);
            this.label8.TabIndex = 46;
            this.label8.Text = "5. NESıL BAKKAL HESAP DEFTERı";
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAllProfit);
            this.Controls.Add(this.tbxAllCost);
            this.Controls.Add(this.tbxAllPrice);
            this.Controls.Add(this.tbxProfit);
            this.Controls.Add(this.tbxTotalCostPrice);
            this.Controls.Add(this.tbxTotalPrice);
            this.Controls.Add(this.tbxOrderId);
            this.Controls.Add(this.dgwProducts);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Balance";
            this.Text = "Bilanço";
            this.Load += new System.EventHandler(this.Balance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.TextBox tbxOrderId;
        private System.Windows.Forms.TextBox tbxTotalPrice;
        private System.Windows.Forms.TextBox tbxTotalCostPrice;
        private System.Windows.Forms.TextBox tbxProfit;
        private System.Windows.Forms.TextBox tbxAllPrice;
        private System.Windows.Forms.TextBox tbxAllCost;
        private System.Windows.Forms.TextBox tbxAllProfit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label8;
    }
}