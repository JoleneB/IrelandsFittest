namespace IrelandsFittest
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.LoginHeader = new System.Windows.Forms.Label();
            this.NameHeader = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginHeader
            // 
            this.LoginHeader.AutoSize = true;
            this.LoginHeader.BackColor = System.Drawing.Color.Transparent;
            this.LoginHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoginHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LoginHeader.Location = new System.Drawing.Point(536, 103);
            this.LoginHeader.Name = "LoginHeader";
            this.LoginHeader.Size = new System.Drawing.Size(205, 31);
            this.LoginHeader.TabIndex = 0;
            this.LoginHeader.Text = "Login or Sign-up";
            this.LoginHeader.Click += new System.EventHandler(this.LoginHeader_Click);
            // 
            // NameHeader
            // 
            this.NameHeader.AutoSize = true;
            this.NameHeader.BackColor = System.Drawing.Color.Transparent;
            this.NameHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NameHeader.Location = new System.Drawing.Point(429, 33);
            this.NameHeader.Name = "NameHeader";
            this.NameHeader.Size = new System.Drawing.Size(422, 48);
            this.NameHeader.TabIndex = 1;
            this.NameHeader.Text = "Ireland\'s Fittest Games";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(596, 205);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(255, 32);
            this.tbUsername.TabIndex = 2;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbUsername.Location = new System.Drawing.Point(431, 205);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(136, 31);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(431, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(596, 288);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(255, 32);
            this.tbPassword.TabIndex = 5;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(596, 391);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(110, 40);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(741, 391);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 40);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 500);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.NameHeader);
            this.Controls.Add(this.LoginHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginHeader;
        private System.Windows.Forms.Label NameHeader;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnLogin;
    }
}