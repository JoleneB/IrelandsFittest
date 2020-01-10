namespace IrelandsFittest
{
    partial class frmResultsInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultsInput));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbResults = new System.Windows.Forms.Label();
            this.NameHeader = new System.Windows.Forms.Label();
            this.cbActivity = new System.Windows.Forms.ComboBox();
            this.cbEventName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.cbCompUsername = new System.Windows.Forms.ComboBox();
            this.btnAddResult = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.resultsMenuToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.mainMenuToolStripMenuItem.Text = "Main menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // resultsMenuToolStripMenuItem
            // 
            this.resultsMenuToolStripMenuItem.Name = "resultsMenuToolStripMenuItem";
            this.resultsMenuToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.resultsMenuToolStripMenuItem.Text = "Results menu";
            this.resultsMenuToolStripMenuItem.Click += new System.EventHandler(this.resultsMenuToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.signOutToolStripMenuItem.Text = "Sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // lbResults
            // 
            this.lbResults.AutoSize = true;
            this.lbResults.BackColor = System.Drawing.Color.Transparent;
            this.lbResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbResults.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbResults.Location = new System.Drawing.Point(555, 87);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(150, 31);
            this.lbResults.TabIndex = 57;
            this.lbResults.Text = "Add Results";
            // 
            // NameHeader
            // 
            this.NameHeader.AutoSize = true;
            this.NameHeader.BackColor = System.Drawing.Color.Transparent;
            this.NameHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NameHeader.Location = new System.Drawing.Point(411, 39);
            this.NameHeader.Name = "NameHeader";
            this.NameHeader.Size = new System.Drawing.Size(422, 48);
            this.NameHeader.TabIndex = 56;
            this.NameHeader.Text = "Ireland\'s Fittest Games";
            // 
            // cbActivity
            // 
            this.cbActivity.AllowDrop = true;
            this.cbActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActivity.FormattingEnabled = true;
            this.cbActivity.Location = new System.Drawing.Point(596, 199);
            this.cbActivity.Name = "cbActivity";
            this.cbActivity.Size = new System.Drawing.Size(212, 24);
            this.cbActivity.TabIndex = 71;
            this.cbActivity.Click += new System.EventHandler(this.cbActivity_Click);
            // 
            // cbEventName
            // 
            this.cbEventName.AllowDrop = true;
            this.cbEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEventName.FormattingEnabled = true;
            this.cbEventName.Location = new System.Drawing.Point(596, 160);
            this.cbEventName.Name = "cbEventName";
            this.cbEventName.Size = new System.Drawing.Size(212, 24);
            this.cbEventName.TabIndex = 70;
            this.cbEventName.SelectedIndexChanged += new System.EventHandler(this.cbEventName_SelectedIndexChanged);
            this.cbEventName.Click += new System.EventHandler(this.cbEventName_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(416, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "Activity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(416, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "Event Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(416, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "Score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(416, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "Competitor Username:";
            // 
            // tbScore
            // 
            this.tbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScore.Location = new System.Drawing.Point(596, 293);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(212, 22);
            this.tbScore.TabIndex = 67;
            // 
            // cbCompUsername
            // 
            this.cbCompUsername.AllowDrop = true;
            this.cbCompUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompUsername.FormattingEnabled = true;
            this.cbCompUsername.Location = new System.Drawing.Point(596, 248);
            this.cbCompUsername.Name = "cbCompUsername";
            this.cbCompUsername.Size = new System.Drawing.Size(212, 24);
            this.cbCompUsername.TabIndex = 74;
            // 
            // btnAddResult
            // 
            this.btnAddResult.Location = new System.Drawing.Point(708, 395);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(100, 31);
            this.btnAddResult.TabIndex = 75;
            this.btnAddResult.Text = "Add Result";
            this.btnAddResult.UseVisualStyleBackColor = true;
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click_1);
            // 
            // frmResultsInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 500);
            this.Controls.Add(this.btnAddResult);
            this.Controls.Add(this.cbCompUsername);
            this.Controls.Add(this.cbActivity);
            this.Controls.Add(this.cbEventName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.NameHeader);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmResultsInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Results";
            this.Load += new System.EventHandler(this.frmResultsInput_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Label lbResults;
        private System.Windows.Forms.Label NameHeader;
        protected System.Windows.Forms.ComboBox cbActivity;
        protected System.Windows.Forms.ComboBox cbEventName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbScore;
        protected System.Windows.Forms.ComboBox cbCompUsername;
        private System.Windows.Forms.Button btnAddResult;
    }
}