namespace IrelandsFittest
{
    partial class frmResultsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultsMenu));
            this.lbResults = new System.Windows.Forms.Label();
            this.NameHeader = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInputResults = new System.Windows.Forms.Button();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbResults
            // 
            this.lbResults.AutoSize = true;
            this.lbResults.BackColor = System.Drawing.Color.Transparent;
            this.lbResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbResults.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbResults.Location = new System.Drawing.Point(561, 101);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(96, 31);
            this.lbResults.TabIndex = 7;
            this.lbResults.Text = "Results";
            // 
            // NameHeader
            // 
            this.NameHeader.AutoSize = true;
            this.NameHeader.BackColor = System.Drawing.Color.Transparent;
            this.NameHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NameHeader.Location = new System.Drawing.Point(407, 53);
            this.NameHeader.Name = "NameHeader";
            this.NameHeader.Size = new System.Drawing.Size(422, 48);
            this.NameHeader.TabIndex = 6;
            this.NameHeader.Text = "Ireland\'s Fittest Games";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.mainMenuToolStripMenuItem.Text = "Main menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.signOutToolStripMenuItem.Text = "Sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // btnInputResults
            // 
            this.btnInputResults.Location = new System.Drawing.Point(468, 315);
            this.btnInputResults.Name = "btnInputResults";
            this.btnInputResults.Size = new System.Drawing.Size(99, 37);
            this.btnInputResults.TabIndex = 9;
            this.btnInputResults.Text = "Input Results";
            this.btnInputResults.UseVisualStyleBackColor = true;
            this.btnInputResults.Click += new System.EventHandler(this.btnInputResults_Click);
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.Location = new System.Drawing.Point(659, 315);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(99, 37);
            this.btnLeaderboard.TabIndex = 10;
            this.btnLeaderboard.Text = "Leaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = true;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // frmResultsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 500);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.btnInputResults);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.NameHeader);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmResultsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.Load += new System.EventHandler(this.frmResultsMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbResults;
        private System.Windows.Forms.Label NameHeader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Button btnInputResults;
        private System.Windows.Forms.Button btnLeaderboard;
    }
}