namespace Sign_In.UI
{
    partial class AdminMenu
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAdminMenu = new System.Windows.Forms.Label();
            this.btnGenereteInvoice = new System.Windows.Forms.Button();
            this.btnBuyProduct = new System.Windows.Forms.Button();
            this.btnAllProducts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(339, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 35);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAdminMenu
            // 
            this.lblAdminMenu.AutoSize = true;
            this.lblAdminMenu.BackColor = System.Drawing.SystemColors.Control;
            this.lblAdminMenu.Font = new System.Drawing.Font("Microsoft JhengHei", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAdminMenu.Location = new System.Drawing.Point(66, 33);
            this.lblAdminMenu.Name = "lblAdminMenu";
            this.lblAdminMenu.Size = new System.Drawing.Size(230, 43);
            this.lblAdminMenu.TabIndex = 12;
            this.lblAdminMenu.Text = "Admin Menu";
            this.lblAdminMenu.Click += new System.EventHandler(this.lblAdminMenu_Click);
            // 
            // btnGenereteInvoice
            // 
            this.btnGenereteInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenereteInvoice.Location = new System.Drawing.Point(427, 250);
            this.btnGenereteInvoice.Name = "btnGenereteInvoice";
            this.btnGenereteInvoice.Size = new System.Drawing.Size(166, 77);
            this.btnGenereteInvoice.TabIndex = 11;
            this.btnGenereteInvoice.Text = "View SalesTax";
            this.btnGenereteInvoice.UseVisualStyleBackColor = true;
            this.btnGenereteInvoice.Click += new System.EventHandler(this.btnGenereteInvoice_Click);
            // 
            // btnBuyProduct
            // 
            this.btnBuyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyProduct.Location = new System.Drawing.Point(74, 117);
            this.btnBuyProduct.Name = "btnBuyProduct";
            this.btnBuyProduct.Size = new System.Drawing.Size(166, 77);
            this.btnBuyProduct.TabIndex = 10;
            this.btnBuyProduct.Text = "Add Product";
            this.btnBuyProduct.UseVisualStyleBackColor = true;
            this.btnBuyProduct.Click += new System.EventHandler(this.btnBuyProduct_Click);
            // 
            // btnAllProducts
            // 
            this.btnAllProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllProducts.Location = new System.Drawing.Point(307, 117);
            this.btnAllProducts.Name = "btnAllProducts";
            this.btnAllProducts.Size = new System.Drawing.Size(166, 77);
            this.btnAllProducts.TabIndex = 9;
            this.btnAllProducts.Text = "View All Products";
            this.btnAllProducts.UseVisualStyleBackColor = true;
            this.btnAllProducts.Click += new System.EventHandler(this.btnAllProducts_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(197, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 77);
            this.button1.TabIndex = 14;
            this.button1.Text = "Products To be Ordered";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(553, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 77);
            this.button2.TabIndex = 15;
            this.button2.Text = "Most Expensive Product";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblAdminMenu);
            this.Controls.Add(this.btnGenereteInvoice);
            this.Controls.Add(this.btnBuyProduct);
            this.Controls.Add(this.btnAllProducts);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAdminMenu;
        private System.Windows.Forms.Button btnGenereteInvoice;
        private System.Windows.Forms.Button btnBuyProduct;
        private System.Windows.Forms.Button btnAllProducts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}