namespace IrelandsFittest
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.NameHeader = new System.Windows.Forms.Label();
            this.btnAddCompetitor = new System.Windows.Forms.Button();
            this.btnAddEvents = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.msSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.lbMainMenu = new System.Windows.Forms.Label();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameHeader
            // 
            this.NameHeader.AutoSize = true;
            this.NameHeader.BackColor = System.Drawing.Color.Transparent;
            this.NameHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NameHeader.Location = new System.Drawing.Point(408, 52);
            this.NameHeader.Name = "NameHeader";
            this.NameHeader.Size = new System.Drawing.Size(422, 48);
            this.NameHeader.TabIndex = 3;
            this.NameHeader.Text = "Ireland\'s Fittest Games";
            this.NameHeader.Click += new System.EventHandler(this.NameHeader_Click);
            // 
            // btnAddCompetitor
            // 
            this.btnAddCompetitor.Location = new System.Drawing.Point(382, 297);
            this.btnAddCompetitor.Name = "btnAddCompetitor";
            this.btnAddCompetitor.Size = new System.Drawing.Size(104, 34);
            this.btnAddCompetitor.TabIndex = 4;
            this.btnAddCompetitor.Text = "Add Competitor";
            this.btnAddCompetitor.UseVisualStyleBackColor = true;
            this.btnAddCompetitor.Click += new System.EventHandler(this.btnAddCompetitor_Click);
            // 
            // btnAddEvents
            // 
            this.btnAddEvents.Location = new System.Drawing.Point(543, 297);
            this.btnAddEvents.Name = "btnAddEvents";
            this.btnAddEvents.Size = new System.Drawing.Size(104, 34);
            this.btnAddEvents.TabIndex = 5;
            this.btnAddEvents.Text = "Events";
            this.btnAddEvents.UseVisualStyleBackColor = true;
            this.btnAddEvents.Click += new System.EventHandler(this.btnAddEvents_Click);
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(714, 297);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(104, 34);
            this.btnResults.TabIndex = 6;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSignOut});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(911, 24);
            this.msMainMenu.TabIndex = 7;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // msSignOut
            // 
            this.msSignOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msSignOut.Name = "msSignOut";
            this.msSignOut.Size = new System.Drawing.Size(63, 20);
            this.msSignOut.Text = "Sign out";
            this.msSignOut.Click += new System.EventHandler(this.msSignOut_Click);
            // 
            // lbMainMenu
            // 
            this.lbMainMenu.AutoSize = true;
            this.lbMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.lbMainMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbMainMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbMainMenu.Location = new System.Drawing.Point(537, 113);
            this.lbMainMenu.Name = "lbMainMenu";
            this.lbMainMenu.Size = new System.Drawing.Size(145, 31);
            this.lbMainMenu.TabIndex = 8;
            this.lbMainMenu.Text = "Main Menu";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 500);
            this.Controls.Add(this.lbMainMenu);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnAddEvents);
            this.Controls.Add(this.btnAddCompetitor);
            this.Controls.Add(this.NameHeader);
            this.Controls.Add(this.msMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameHeader;
        private System.Windows.Forms.Button btnAddCompetitor;
        private System.Windows.Forms.Button btnAddEvents;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem msSignOut;
        private System.Windows.Forms.Label lbMainMenu;
    }
}