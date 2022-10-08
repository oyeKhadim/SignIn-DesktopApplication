namespace Sign_In
{
    partial class SignIN
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSignIN = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.mtxtPassword = new System.Windows.Forms.MaskedTextBox();
            this.lblheader3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(128, 121);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(113, 25);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "UserName";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(128, 189);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // btnSignIN
            // 
            this.btnSignIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIN.Location = new System.Drawing.Point(552, 320);
            this.btnSignIN.Name = "btnSignIN";
            this.btnSignIN.Size = new System.Drawing.Size(75, 35);
            this.btnSignIN.TabIndex = 4;
            this.btnSignIN.Text = "SignIN";
            this.btnSignIN.UseVisualStyleBackColor = true;
            this.btnSignIN.Click += new System.EventHandler(this.btnSignIN_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(133, 320);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 35);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(312, 126);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(223, 20);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // mtxtPassword
            // 
            this.mtxtPassword.Location = new System.Drawing.Point(312, 193);
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.PasswordChar = '*';
            this.mtxtPassword.Size = new System.Drawing.Size(223, 20);
            this.mtxtPassword.TabIndex = 7;
            this.mtxtPassword.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtPassword_MaskInputRejected);
            this.mtxtPassword.Click += new System.EventHandler(this.mtxtPassword_Click);
            // 
            // lblheader3
            // 
            this.lblheader3.AutoSize = true;
            this.lblheader3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblheader3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader3.Location = new System.Drawing.Point(300, 9);
            this.lblheader3.Name = "lblheader3";
            this.lblheader3.Size = new System.Drawing.Size(178, 68);
            this.lblheader3.TabIndex = 17;
            this.lblheader3.Text = "Sign IN";
            // 
            // SignIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblheader3);
            this.Controls.Add(this.mtxtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSignIN);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Name = "SignIN";
            this.Text = "SignIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSignIN;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.MaskedTextBox mtxtPassword;
        private System.Windows.Forms.Label lblheader3;
    }
}