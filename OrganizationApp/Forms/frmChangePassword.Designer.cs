namespace OrganizationApp.Forms
{
    partial class frmChangePassword
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
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblCheckPassword = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtCheckPassword = new System.Windows.Forms.TextBox();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(12, 20);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOldPassword.Size = new System.Drawing.Size(60, 13);
            this.lblOldPassword.TabIndex = 0;
            this.lblOldPassword.Text = "Köhnə şifrə";
            this.lblOldPassword.Click += new System.EventHandler(this.lblOldPassword_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(12, 64);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(53, 13);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "Yeni  şifrə";
            this.lblNewPassword.Click += new System.EventHandler(this.lblNewPassword_Click);
            // 
            // lblCheckPassword
            // 
            this.lblCheckPassword.AutoSize = true;
            this.lblCheckPassword.Location = new System.Drawing.Point(13, 105);
            this.lblCheckPassword.Name = "lblCheckPassword";
            this.lblCheckPassword.Size = new System.Drawing.Size(78, 13);
            this.lblCheckPassword.TabIndex = 2;
            this.lblCheckPassword.Text = "Şifrəni dəsdiqlə";
            this.lblCheckPassword.Click += new System.EventHandler(this.lblCheckPassword_Click);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(106, 17);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(219, 20);
            this.txtOldPassword.TabIndex = 3;
            this.txtOldPassword.TextChanged += new System.EventHandler(this.txtOldPassword_TextChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(106, 57);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(219, 20);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // txtCheckPassword
            // 
            this.txtCheckPassword.Location = new System.Drawing.Point(106, 102);
            this.txtCheckPassword.Name = "txtCheckPassword";
            this.txtCheckPassword.PasswordChar = '*';
            this.txtCheckPassword.Size = new System.Drawing.Size(219, 20);
            this.txtCheckPassword.TabIndex = 5;
            this.txtCheckPassword.TextChanged += new System.EventHandler(this.txtCheckPassword_TextChanged);
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Location = new System.Drawing.Point(250, 170);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePassword.TabIndex = 6;
            this.btnUpdatePassword.Text = "Yadda saxla";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 221);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.txtCheckPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lblCheckPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifrəni dəyişmək";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblCheckPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtCheckPassword;
        private System.Windows.Forms.Button btnUpdatePassword;
    }
}