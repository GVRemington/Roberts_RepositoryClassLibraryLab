namespace Roberts_RepositoryWinformsIntroLab
{
    partial class frmAddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddProduct = new Button();
            lblProductName = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lblProductPrice = new Label();
            lblProductStock = new Label();
            SuspendLayout();
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(167, 203);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(150, 34);
            btnAddProduct.TabIndex = 0;
            btnAddProduct.Text = "AddProduct";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(45, 40);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(126, 25);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Product Name";
            lblProductName.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(167, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 4;
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(45, 91);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(111, 25);
            lblProductPrice.TabIndex = 5;
            lblProductPrice.Text = "ProductPrice";
            // 
            // lblProductStock
            // 
            lblProductStock.AutoSize = true;
            lblProductStock.Location = new Point(45, 146);
            lblProductStock.Name = "lblProductStock";
            lblProductStock.Size = new Size(122, 25);
            lblProductStock.TabIndex = 6;
            lblProductStock.Text = "Product Stock";
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblProductStock);
            Controls.Add(lblProductPrice);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblProductName);
            Controls.Add(btnAddProduct);
            Name = "frmAddProduct";
            Text = "New Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddProduct;
        private Label lblProductName;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lblProductPrice;
        private Label lblProductStock;
    }
}
