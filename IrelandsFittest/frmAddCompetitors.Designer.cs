namespace IrelandsFittest
{
    partial class frmAddCompetitors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCompetitors));
            this.NameHeader = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainmenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCompetitorID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lbDateofBirth = new System.Windows.Forms.Label();
            this.tbCounty = new System.Windows.Forms.TextBox();
            this.lbCounty = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.CreateAccHeader = new System.Windows.Forms.Label();
            this.BtnAddCompetitor = new System.Windows.Forms.Button();
            this.cbFemale = new System.Windows.Forms.CheckBox();
            this.cbMale = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameHeader
            // 
            this.NameHeader.AutoSize = true;
            this.NameHeader.BackColor = System.Drawing.Color.Transparent;
            this.NameHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NameHeader.Location = new System.Drawing.Point(414, 43);
            this.NameHeader.Name = "NameHeader";
            this.NameHeader.Size = new System.Drawing.Size(422, 48);
            this.NameHeader.TabIndex = 3;
            this.NameHeader.Text = "Ireland\'s Fittest Games";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainmenuToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainmenuToolStripMenuItem
            // 
            this.mainmenuToolStripMenuItem.Name = "mainmenuToolStripMenuItem";
            this.mainmenuToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.mainmenuToolStripMenuItem.Text = "Main menu";
            this.mainmenuToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.signOutToolStripMenuItem.Text = "Sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // tbCompetitorID
            // 
            this.tbCompetitorID.Enabled = false;
            this.tbCompetitorID.Location = new System.Drawing.Point(515, 175);
            this.tbCompetitorID.Multiline = true;
            this.tbCompetitorID.Name = "tbCompetitorID";
            this.tbCompetitorID.ReadOnly = true;
            this.tbCompetitorID.Size = new System.Drawing.Size(82, 18);
            this.tbCompetitorID.TabIndex = 40;
            this.tbCompetitorID.TextChanged += new System.EventHandler(this.tbCompetitorID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(424, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Competitor ID:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(427, 350);
            this.dtpDOB.MaxDate = new System.DateTime(2020, 1, 9, 13, 33, 33, 0);
            this.dtpDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(170, 27);
            this.dtpDOB.TabIndex = 38;
            this.dtpDOB.Value = new System.DateTime(2020, 1, 9, 0, 0, 0, 0);
            // 
            // lbDateofBirth
            // 
            this.lbDateofBirth.AutoSize = true;
            this.lbDateofBirth.BackColor = System.Drawing.Color.Transparent;
            this.lbDateofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateofBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbDateofBirth.Location = new System.Drawing.Point(424, 331);
            this.lbDateofBirth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDateofBirth.Name = "lbDateofBirth";
            this.lbDateofBirth.Size = new System.Drawing.Size(83, 16);
            this.lbDateofBirth.TabIndex = 37;
            this.lbDateofBirth.Text = "Date of Birth:";
            // 
            // tbCounty
            // 
            this.tbCounty.Location = new System.Drawing.Point(647, 284);
            this.tbCounty.Multiline = true;
            this.tbCounty.Name = "tbCounty";
            this.tbCounty.Size = new System.Drawing.Size(170, 27);
            this.tbCounty.TabIndex = 36;
            // 
            // lbCounty
            // 
            this.lbCounty.AutoSize = true;
            this.lbCounty.BackColor = System.Drawing.Color.Transparent;
            this.lbCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCounty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbCounty.Location = new System.Drawing.Point(644, 265);
            this.lbCounty.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCounty.Name = "lbCounty";
            this.lbCounty.Size = new System.Drawing.Size(52, 16);
            this.lbCounty.TabIndex = 35;
            this.lbCounty.Text = "County:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(427, 284);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(170, 27);
            this.tbEmail.TabIndex = 32;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(647, 226);
            this.tbSurname.Multiline = true;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(170, 27);
            this.tbSurname.TabIndex = 31;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(427, 226);
            this.tbFirstName.Multiline = true;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(170, 27);
            this.tbFirstName.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(424, 265);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Email:";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.BackColor = System.Drawing.Color.Transparent;
            this.lbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbSurname.Location = new System.Drawing.Point(644, 207);
            this.lbSurname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(65, 16);
            this.lbSurname.TabIndex = 28;
            this.lbSurname.Text = "Surname:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblFirstName.Location = new System.Drawing.Point(424, 207);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 16);
            this.lblFirstName.TabIndex = 26;
            this.lblFirstName.Text = "First name:";
            // 
            // CreateAccHeader
            // 
            this.CreateAccHeader.AutoSize = true;
            this.CreateAccHeader.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreateAccHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CreateAccHeader.Location = new System.Drawing.Point(518, 106);
            this.CreateAccHeader.Name = "CreateAccHeader";
            this.CreateAccHeader.Size = new System.Drawing.Size(152, 31);
            this.CreateAccHeader.TabIndex = 27;
            this.CreateAccHeader.Text = "Add Athlete";
            // 
            // BtnAddCompetitor
            // 
            this.BtnAddCompetitor.Location = new System.Drawing.Point(719, 440);
            this.BtnAddCompetitor.Name = "BtnAddCompetitor";
            this.BtnAddCompetitor.Size = new System.Drawing.Size(98, 30);
            this.BtnAddCompetitor.TabIndex = 43;
            this.BtnAddCompetitor.Text = "Add Competitor";
            this.BtnAddCompetitor.UseVisualStyleBackColor = true;
            this.BtnAddCompetitor.Click += new System.EventHandler(this.BtnAddCompetitor_Click);
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.BackColor = System.Drawing.Color.Transparent;
            this.cbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbFemale.Location = new System.Drawing.Point(744, 357);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(73, 20);
            this.cbFemale.TabIndex = 46;
            this.cbFemale.Text = "Female";
            this.cbFemale.UseVisualStyleBackColor = false;
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.BackColor = System.Drawing.Color.Transparent;
            this.cbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbMale.Location = new System.Drawing.Point(647, 357);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(57, 20);
            this.cbMale.TabIndex = 45;
            this.cbMale.Text = "Male";
            this.cbMale.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(644, 331);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Gender:";
            // 
            // frmAddCompetitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 500);
            this.Controls.Add(this.cbFemale);
            this.Controls.Add(this.cbMale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAddCompetitor);
            this.Controls.Add(this.tbCompetitorID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lbDateofBirth);
            this.Controls.Add(this.tbCounty);
            this.Controls.Add(this.lbCounty);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.CreateAccHeader);
            this.Controls.Add(this.NameHeader);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAddCompetitors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Competitor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameHeader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainmenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.TextBox tbCompetitorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lbDateofBirth;
        private System.Windows.Forms.TextBox tbCounty;
        private System.Windows.Forms.Label lbCounty;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label CreateAccHeader;
        private System.Windows.Forms.Button BtnAddCompetitor;
        private System.Windows.Forms.CheckBox cbFemale;
        private System.Windows.Forms.CheckBox cbMale;
        private System.Windows.Forms.Label label2;
    }
}