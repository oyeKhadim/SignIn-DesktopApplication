namespace Sign_In.UI
{
    partial class UserMenu
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
            this.btnAllProducts = new System.Windows.Forms.Button();
            this.btnBuyProduct = new System.Windows.Forms.Button();
            this.btnGenereteInvoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAllProducts
            // 
            this.btnAllProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllProducts.Location = new System.Drawing.Point(69, 145);
            this.btnAllProducts.Name = "btnAllProducts";
            this.btnAllProducts.Size = new System.Drawing.Size(166, 77);
            this.btnAllProducts.TabIndex = 1;
            this.btnAllProducts.Text = "View All Products";
            this.btnAllProducts.UseVisualStyleBackColor = true;
            this.btnAllProducts.Click += new System.EventHandler(this.btnAllProducts_Click);
            // 
            // btnBuyProduct
            // 
            this.btnBuyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyProduct.Location = new System.Drawing.Point(315, 145);
            this.btnBuyProduct.Name = "btnBuyProduct";
            this.btnBuyProduct.Size = new System.Drawing.Size(166, 77);
            this.btnBuyProduct.TabIndex = 2;
            this.btnBuyProduct.Text = "Buy Product";
            this.btnBuyProduct.UseVisualStyleBackColor = true;
            this.btnBuyProduct.Click += new System.EventHandler(this.btnBuyProduct_Click);
            // 
            // btnGenereteInvoice
            // 
            this.btnGenereteInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenereteInvoice.Location = new System.Drawing.Point(554, 145);
            this.btnGenereteInvoice.Name = "btnGenereteInvoice";
            this.btnGenereteInvoice.Size = new System.Drawing.Size(166, 77);
            this.btnGenereteInvoice.TabIndex = 3;
            this.btnGenereteInvoice.Text = "Generate Invoice";
            this.btnGenereteInvoice.UseVisualStyleBackColor = true;
            this.btnGenereteInvoice.Click += new System.EventHandler(this.btnGenereteInvoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(307, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Menu";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(327, 336);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 35);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenereteInvoice);
            this.Controls.Add(this.btnBuyProduct);
            this.Controls.Add(this.btnAllProducts);
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllProducts;
        private System.Windows.Forms.Button btnBuyProduct;
        private System.Windows.Forms.Button btnGenereteInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}