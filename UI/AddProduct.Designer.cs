namespace Sign_In.UI
{
    partial class AddProduct
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
            this.lblAdminMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtThresholdQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAvailableQuantity = new System.Windows.Forms.TextBox();
            this.rbtnGrocery = new System.Windows.Forms.RadioButton();
            this.rbtnFruit = new System.Windows.Forms.RadioButton();
            this.rbtnOther = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminMenu
            // 
            this.lblAdminMenu.AutoSize = true;
            this.lblAdminMenu.BackColor = System.Drawing.SystemColors.Control;
            this.lblAdminMenu.Font = new System.Drawing.Font("Microsoft JhengHei", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAdminMenu.Location = new System.Drawing.Point(12, 9);
            this.lblAdminMenu.Name = "lblAdminMenu";
            this.lblAdminMenu.Size = new System.Drawing.Size(239, 43);
            this.lblAdminMenu.TabIndex = 13;
            this.lblAdminMenu.Text = "Add Product :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Available Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Catagory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Threshold Quantity";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(412, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 20);
            this.txtName.TabIndex = 19;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtThresholdQuantity
            // 
            this.txtThresholdQuantity.Location = new System.Drawing.Point(412, 322);
            this.txtThresholdQuantity.Name = "txtThresholdQuantity";
            this.txtThresholdQuantity.Size = new System.Drawing.Size(232, 20);
            this.txtThresholdQuantity.TabIndex = 20;
            this.txtThresholdQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThresholdQuantity_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(412, 212);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(232, 20);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtAvailableQuantity
            // 
            this.txtAvailableQuantity.Location = new System.Drawing.Point(412, 269);
            this.txtAvailableQuantity.Name = "txtAvailableQuantity";
            this.txtAvailableQuantity.Size = new System.Drawing.Size(232, 20);
            this.txtAvailableQuantity.TabIndex = 22;
            this.txtAvailableQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAvailableQuantity_KeyPress);
            // 
            // rbtnGrocery
            // 
            this.rbtnGrocery.AutoSize = true;
            this.rbtnGrocery.Location = new System.Drawing.Point(412, 163);
            this.rbtnGrocery.Name = "rbtnGrocery";
            this.rbtnGrocery.Size = new System.Drawing.Size(62, 17);
            this.rbtnGrocery.TabIndex = 23;
            this.rbtnGrocery.Text = "Grocery";
            this.rbtnGrocery.UseVisualStyleBackColor = true;
            // 
            // rbtnFruit
            // 
            this.rbtnFruit.AutoSize = true;
            this.rbtnFruit.Location = new System.Drawing.Point(508, 164);
            this.rbtnFruit.Name = "rbtnFruit";
            this.rbtnFruit.Size = new System.Drawing.Size(45, 17);
            this.rbtnFruit.TabIndex = 24;
            this.rbtnFruit.Text = "Fruit";
            this.rbtnFruit.UseVisualStyleBackColor = true;
            // 
            // rbtnOther
            // 
            this.rbtnOther.AutoSize = true;
            this.rbtnOther.Checked = true;
            this.rbtnOther.Location = new System.Drawing.Point(593, 164);
            this.rbtnOther.Name = "rbtnOther";
            this.rbtnOther.Size = new System.Drawing.Size(51, 17);
            this.rbtnOther.TabIndex = 25;
            this.rbtnOther.TabStop = true;
            this.rbtnOther.Text = "Other";
            this.rbtnOther.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(509, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 47);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(90, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 47);
            this.button2.TabIndex = 27;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbtnOther);
            this.Controls.Add(this.rbtnFruit);
            this.Controls.Add(this.rbtnGrocery);
            this.Controls.Add(this.txtAvailableQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtThresholdQuantity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdminMenu);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtThresholdQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAvailableQuantity;
        private System.Windows.Forms.RadioButton rbtnGrocery;
        private System.Windows.Forms.RadioButton rbtnFruit;
        private System.Windows.Forms.RadioButton rbtnOther;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}