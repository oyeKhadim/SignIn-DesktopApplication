namespace Sign_In
{
    partial class Form1
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
            this.lblheader1 = new System.Windows.Forms.Label();
            this.btnSignIN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblheader1
            // 
            this.lblheader1.AutoSize = true;
            this.lblheader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader1.Location = new System.Drawing.Point(255, 59);
            this.lblheader1.Name = "lblheader1";
            this.lblheader1.Size = new System.Drawing.Size(324, 31);
            this.lblheader1.TabIndex = 0;
            this.lblheader1.Text = "Sign IN / Up Application";
            // 
            // btnSignIN
            // 
            this.btnSignIN.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIN.Location = new System.Drawing.Point(460, 179);
            this.btnSignIN.Name = "btnSignIN";
            this.btnSignIN.Size = new System.Drawing.Size(165, 67);
            this.btnSignIN.TabIndex = 5;
            this.btnSignIN.Text = "SignUP";
            this.btnSignIN.UseVisualStyleBackColor = true;
            this.btnSignIN.Click += new System.EventHandler(this.btnSignIN_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(169, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "SignIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(340, 342);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSignIN);
            this.Controls.Add(this.lblheader1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheader1;
        private System.Windows.Forms.Button btnSignIN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
    }
}

