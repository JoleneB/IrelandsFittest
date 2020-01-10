namespace IrelandsFittest
{
    partial class frmLeaderboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaderboard));
            this.NameHeader = new System.Windows.Forms.Label();
            this.lbLeaderboard = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cbEvents = new System.Windows.Forms.ComboBox();
            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            this.SuspendLayout();
            // 
            // NameHeader
            // 
            this.NameHeader.AutoSize = true;
            this.NameHeader.BackColor = System.Drawing.Color.Transparent;
            this.NameHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NameHeader.Location = new System.Drawing.Point(425, 24);
            this.NameHeader.Name = "NameHeader";
            this.NameHeader.Size = new System.Drawing.Size(422, 48);
            this.NameHeader.TabIndex = 3;
            this.NameHeader.Text = "Ireland\'s Fittest Games";
            // 
            // lbLeaderboard
            // 
            this.lbLeaderboard.AutoSize = true;
            this.lbLeaderboard.BackColor = System.Drawing.Color.Transparent;
            this.lbLeaderboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbLeaderboard.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeaderboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbLeaderboard.Location = new System.Drawing.Point(550, 72);
            this.lbLeaderboard.Name = "lbLeaderboard";
            this.lbLeaderboard.Size = new System.Drawing.Size(158, 31);
            this.lbLeaderboard.TabIndex = 2;
            this.lbLeaderboard.Text = "Leaderboard";
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
            this.menuStrip1.TabIndex = 56;
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
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(791, 118);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(87, 22);
            this.btn_Refresh.TabIndex = 69;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cbEvents
            // 
            this.cbEvents.AllowDrop = true;
            this.cbEvents.FormattingEnabled = true;
            this.cbEvents.Location = new System.Drawing.Point(489, 118);
            this.cbEvents.Name = "cbEvents";
            this.cbEvents.Size = new System.Drawing.Size(275, 21);
            this.cbEvents.TabIndex = 68;
            // 
            // dgvLeaderboard
            // 
            this.dgvLeaderboard.AllowUserToAddRows = false;
            this.dgvLeaderboard.AllowUserToDeleteRows = false;
            this.dgvLeaderboard.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeaderboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaderboard.Enabled = false;
            this.dgvLeaderboard.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvLeaderboard.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvLeaderboard.Location = new System.Drawing.Point(377, 168);
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLeaderboard.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLeaderboard.Size = new System.Drawing.Size(501, 295);
            this.dgvLeaderboard.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(374, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "Event Name:";
            // 
            // frmLeaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 500);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cbEvents);
            this.Controls.Add(this.dgvLeaderboard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.NameHeader);
            this.Controls.Add(this.lbLeaderboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLeaderboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.frmLeaderboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameHeader;
        private System.Windows.Forms.Label lbLeaderboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Button btn_Refresh;
        protected System.Windows.Forms.ComboBox cbEvents;
        private System.Windows.Forms.DataGridView dgvLeaderboard;
        private System.Windows.Forms.Label label4;
    }
}