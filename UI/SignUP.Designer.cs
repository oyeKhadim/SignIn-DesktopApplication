namespace Sign_In
{
    partial class SignUP
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
            this.mtxtPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSignUP = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblheader2 = new System.Windows.Forms.Label();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.rbtnUser = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // mtxtPassword
            // 
            this.mtxtPassword.Location = new System.Drawing.Point(335, 180);
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.PasswordChar = '*';
            this.mtxtPassword.Size = new System.Drawing.Size(223, 20);
            this.mtxtPassword.TabIndex = 13;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(335, 113);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(223, 20);
            this.txtUserName.TabIndex = 12;
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(156, 307);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 35);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSignUP
            // 
            this.btnSignUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUP.Location = new System.Drawing.Point(575, 307);
            this.btnSignUP.Name = "btnSignUP";
            this.btnSignUP.Size = new System.Drawing.Size(75, 35);
            this.btnSignUP.TabIndex = 10;
            this.btnSignUP.Text = "SignUP";
            this.btnSignUP.UseVisualStyleBackColor = true;
            this.btnSignUP.Click += new System.EventHandler(this.btnSignUP_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(151, 176);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 25);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(151, 108);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(113, 25);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Role";
            // 
            // lblheader2
            // 
            this.lblheader2.AutoSize = true;
            this.lblheader2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblheader2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader2.Location = new System.Drawing.Point(323, 9);
            this.lblheader2.Name = "lblheader2";
            this.lblheader2.Size = new System.Drawing.Size(202, 68);
            this.lblheader2.TabIndex = 16;
            this.lblheader2.Text = "Sign UP ";
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Location = new System.Drawing.Point(335, 244);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(54, 17);
            this.rbtnAdmin.TabIndex = 17;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Tag = "";
            this.rbtnAdmin.Text = "Admin";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // rbtnUser
            // 
            this.rbtnUser.AutoSize = true;
            this.rbtnUser.Location = new System.Drawing.Point(511, 245);
            this.rbtnUser.Name = "rbtnUser";
            this.rbtnUser.Size = new System.Drawing.Size(47, 17);
            this.rbtnUser.TabIndex = 18;
            this.rbtnUser.TabStop = true;
            this.rbtnUser.Tag = "";
            this.rbtnUser.Text = "User";
            this.rbtnUser.UseVisualStyleBackColor = true;
            // 
            // SignUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnUser);
            this.Controls.Add(this.rbtnAdmin);
            this.Controls.Add(this.lblheader2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSignUP);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Name = "SignUP";
            this.Text = "SignUP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSignUP;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblheader2;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.RadioButton rbtnUser;
    }
}