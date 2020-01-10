namespace IrelandsFittest
{
    partial class frmEventMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventMenu));
            this.lbEvents = new System.Windows.Forms.Label();
            this.NameHeader = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.btnAmendEvent = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEvents
            // 
            this.lbEvents.AutoSize = true;
            this.lbEvents.BackColor = System.Drawing.Color.Transparent;
            this.lbEvents.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbEvents.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbEvents.Location = new System.Drawing.Point(575, 94);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(89, 31);
            this.lbEvents.TabIndex = 5;
            this.lbEvents.Text = "Events";
            // 
            // NameHeader
            // 
            this.NameHeader.AutoSize = true;
            this.NameHeader.BackColor = System.Drawing.Color.Transparent;
            this.NameHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NameHeader.Location = new System.Drawing.Point(421, 46);
            this.NameHeader.Name = "NameHeader";
            this.NameHeader.Size = new System.Drawing.Size(422, 48);
            this.NameHeader.TabIndex = 4;
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
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
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
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(483, 275);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(96, 39);
            this.btnCreateEvent.TabIndex = 7;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // btnAmendEvent
            // 
            this.btnAmendEvent.Location = new System.Drawing.Point(661, 275);
            this.btnAmendEvent.Name = "btnAmendEvent";
            this.btnAmendEvent.Size = new System.Drawing.Size(96, 39);
            this.btnAmendEvent.TabIndex = 8;
            this.btnAmendEvent.Text = "Amend Event";
            this.btnAmendEvent.UseVisualStyleBackColor = true;
            this.btnAmendEvent.Click += new System.EventHandler(this.btnAmendEvent_Click);
            // 
            // frmEventMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 500);
            this.Controls.Add(this.btnAmendEvent);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.lbEvents);
            this.Controls.Add(this.NameHeader);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEventMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.Load += new System.EventHandler(this.frmEventMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEvents;
        private System.Windows.Forms.Label NameHeader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button btnAmendEvent;
    }
}