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
            txtProdName = new TextBox();
            txtProdPrice = new TextBox();
            txtProdStock = new TextBox();
            lblProductPrice = new Label();
            lblProductStock = new Label();
            lblProductName = new Label();
            SuspendLayout();
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(352, 250);
            btnAddProduct.Margin = new Padding(2);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(85, 20);
            btnAddProduct.TabIndex = 0;
            btnAddProduct.Text = "AddProduct";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // txtProdName
            // 
            txtProdName.Location = new Point(352, 124);
            txtProdName.Margin = new Padding(2);
            txtProdName.Name = "txtProdName";
            txtProdName.Size = new Size(85, 23);
            txtProdName.TabIndex = 9;
            // 
            // txtProdPrice
            // 
            txtProdPrice.Location = new Point(352, 166);
            txtProdPrice.Margin = new Padding(2);
            txtProdPrice.Name = "txtProdPrice";
            txtProdPrice.Size = new Size(85, 23);
            txtProdPrice.TabIndex = 8;
            // 
            // txtProdStock
            // 
            txtProdStock.Location = new Point(352, 210);
            txtProdStock.Margin = new Padding(2);
            txtProdStock.Name = "txtProdStock";
            txtProdStock.Size = new Size(85, 23);
            txtProdStock.TabIndex = 7;
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(263, 169);
            lblProductPrice.Margin = new Padding(2, 0, 2, 0);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(78, 15);
            lblProductPrice.TabIndex = 5;
            lblProductPrice.Text = "Product Price";
            // 
            // lblProductStock
            // 
            lblProductStock.AutoSize = true;
            lblProductStock.Location = new Point(263, 218);
            lblProductStock.Margin = new Padding(2, 0, 2, 0);
            lblProductStock.Name = "lblProductStock";
            lblProductStock.Size = new Size(81, 15);
            lblProductStock.TabIndex = 6;
            lblProductStock.Text = "Product Stock";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(263, 127);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(84, 15);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "Product Name";
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 568);
            Controls.Add(lblProductName);
            Controls.Add(lblProductStock);
            Controls.Add(lblProductPrice);
            Controls.Add(txtProdStock);
            Controls.Add(txtProdPrice);
            Controls.Add(txtProdName);
            Controls.Add(btnAddProduct);
            Margin = new Padding(2);
            Name = "frmAddProduct";
            Text = "New Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddProduct;
        private TextBox txtProdName;
        private TextBox txtProdPrice;
        private TextBox txtProdStock;
        private Label lblProductPrice;
        private Label lblProductStock;
        private Label lblProductName;
    }
}
