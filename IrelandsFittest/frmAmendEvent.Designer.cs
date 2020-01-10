namespace IrelandsFittest
{
    partial class frmAmendEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmendEvent));
            this.lbAmendEvent = new System.Windows.Forms.Label();
            this.NameHeader = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvEditEvent = new System.Windows.Forms.DataGridView();
            this.gbViewEdit = new System.Windows.Forms.GroupBox();
            this.gbEditEvent = new System.Windows.Forms.GroupBox();
            this.tbEID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clbActivities = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.dtpEndEvent = new System.Windows.Forms.DateTimePicker();
            this.dtpStartEvent = new System.Windows.Forms.DateTimePicker();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.tbEventVenue = new System.Windows.Forms.TextBox();
            this.lbVenu = new System.Windows.Forms.Label();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEventID = new System.Windows.Forms.TextBox();
            this.lbEventID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditEvent)).BeginInit();
            this.gbViewEdit.SuspendLayout();
            this.gbEditEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAmendEvent
            // 
            this.lbAmendEvent.AutoSize = true;
            this.lbAmendEvent.BackColor = System.Drawing.Color.Transparent;
            this.lbAmendEvent.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbAmendEvent.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmendEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbAmendEvent.Location = new System.Drawing.Point(521, 72);
            this.lbAmendEvent.Name = "lbAmendEvent";
            this.lbAmendEvent.Size = new System.Drawing.Size(168, 31);
            this.lbAmendEvent.TabIndex = 29;
            this.lbAmendEvent.Text = "Amend Event";
            // 
            // NameHeader
            // 
            this.NameHeader.AutoSize = true;
            this.NameHeader.BackColor = System.Drawing.Color.Transparent;
            this.NameHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NameHeader.Location = new System.Drawing.Point(404, 24);
            this.NameHeader.Name = "NameHeader";
            this.NameHeader.Size = new System.Drawing.Size(422, 48);
            this.NameHeader.TabIndex = 28;
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
            this.menuStrip1.TabIndex = 30;
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
            // dgvEditEvent
            // 
            this.dgvEditEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditEvent.Location = new System.Drawing.Point(8, 17);
            this.dgvEditEvent.Name = "dgvEditEvent";
            this.dgvEditEvent.Size = new System.Drawing.Size(465, 132);
            this.dgvEditEvent.TabIndex = 31;
            this.dgvEditEvent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditEvent_CellContentClick);
            // 
            // gbViewEdit
            // 
            this.gbViewEdit.BackColor = System.Drawing.Color.Transparent;
            this.gbViewEdit.Controls.Add(this.dgvEditEvent);
            this.gbViewEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbViewEdit.Location = new System.Drawing.Point(378, 106);
            this.gbViewEdit.Name = "gbViewEdit";
            this.gbViewEdit.Size = new System.Drawing.Size(482, 158);
            this.gbViewEdit.TabIndex = 32;
            this.gbViewEdit.TabStop = false;
            this.gbViewEdit.Text = "Events";
            // 
            // gbEditEvent
            // 
            this.gbEditEvent.BackColor = System.Drawing.Color.Transparent;
            this.gbEditEvent.Controls.Add(this.tbEID);
            this.gbEditEvent.Controls.Add(this.label4);
            this.gbEditEvent.Controls.Add(this.tbEName);
            this.gbEditEvent.Controls.Add(this.label3);
            this.gbEditEvent.Controls.Add(this.clbActivities);
            this.gbEditEvent.Controls.Add(this.label2);
            this.gbEditEvent.Controls.Add(this.lbEndDate);
            this.gbEditEvent.Controls.Add(this.dtpEndEvent);
            this.gbEditEvent.Controls.Add(this.dtpStartEvent);
            this.gbEditEvent.Controls.Add(this.lbStartDate);
            this.gbEditEvent.Controls.Add(this.tbEventVenue);
            this.gbEditEvent.Controls.Add(this.lbVenu);
            this.gbEditEvent.Controls.Add(this.tbEventName);
            this.gbEditEvent.Controls.Add(this.label1);
            this.gbEditEvent.Controls.Add(this.tbEventID);
            this.gbEditEvent.Controls.Add(this.lbEventID);
            this.gbEditEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbEditEvent.Location = new System.Drawing.Point(378, 270);
            this.gbEditEvent.Name = "gbEditEvent";
            this.gbEditEvent.Size = new System.Drawing.Size(482, 185);
            this.gbEditEvent.TabIndex = 33;
            this.gbEditEvent.TabStop = false;
            this.gbEditEvent.Text = "Edit Event";
            // 
            // tbEID
            // 
            this.tbEID.Location = new System.Drawing.Point(115, 20);
            this.tbEID.Name = "tbEID";
            this.tbEID.ReadOnly = true;
            this.tbEID.Size = new System.Drawing.Size(101, 20);
            this.tbEID.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Event ID:";
            // 
            // tbEName
            // 
            this.tbEName.Location = new System.Drawing.Point(115, 49);
            this.tbEName.Name = "tbEName";
            this.tbEName.Size = new System.Drawing.Size(101, 20);
            this.tbEName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Event name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // clbActivities
            // 
            this.clbActivities.FormattingEnabled = true;
            this.clbActivities.Items.AddRange(new object[] {
            "400M Run",
            "Swim",
            "Squat",
            "Deadlift",
            "Bench Press",
            "Snatch",
            "Clean and Jerk"});
            this.clbActivities.Location = new System.Drawing.Point(115, 122);
            this.clbActivities.Name = "clbActivities";
            this.clbActivities.Size = new System.Drawing.Size(135, 49);
            this.clbActivities.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Activities:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndDate.Location = new System.Drawing.Point(243, 90);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(65, 16);
            this.lbEndDate.TabIndex = 21;
            this.lbEndDate.Text = "End date:";
            // 
            // dtpEndEvent
            // 
            this.dtpEndEvent.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndEvent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndEvent.Location = new System.Drawing.Point(314, 84);
            this.dtpEndEvent.MaxDate = new System.DateTime(2024, 1, 10, 0, 0, 0, 0);
            this.dtpEndEvent.MinDate = new System.DateTime(2020, 1, 10, 0, 0, 0, 0);
            this.dtpEndEvent.Name = "dtpEndEvent";
            this.dtpEndEvent.Size = new System.Drawing.Size(101, 22);
            this.dtpEndEvent.TabIndex = 20;
            this.dtpEndEvent.Value = new System.DateTime(2020, 1, 10, 0, 0, 0, 0);
            // 
            // dtpStartEvent
            // 
            this.dtpStartEvent.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartEvent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartEvent.Location = new System.Drawing.Point(115, 86);
            this.dtpStartEvent.MaxDate = new System.DateTime(2024, 1, 10, 0, 0, 0, 0);
            this.dtpStartEvent.MinDate = new System.DateTime(2020, 1, 9, 0, 0, 0, 0);
            this.dtpStartEvent.Name = "dtpStartEvent";
            this.dtpStartEvent.Size = new System.Drawing.Size(101, 20);
            this.dtpStartEvent.TabIndex = 19;
            this.dtpStartEvent.Value = new System.DateTime(2020, 1, 9, 0, 0, 0, 0);
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.Location = new System.Drawing.Point(24, 90);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(68, 16);
            this.lbStartDate.TabIndex = 18;
            this.lbStartDate.Text = "Start date:";
            // 
            // tbEventVenue
            // 
            this.tbEventVenue.Location = new System.Drawing.Point(314, 49);
            this.tbEventVenue.Name = "tbEventVenue";
            this.tbEventVenue.Size = new System.Drawing.Size(101, 20);
            this.tbEventVenue.TabIndex = 17;
            // 
            // lbVenu
            // 
            this.lbVenu.AutoSize = true;
            this.lbVenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVenu.Location = new System.Drawing.Point(243, 53);
            this.lbVenu.Name = "lbVenu";
            this.lbVenu.Size = new System.Drawing.Size(50, 16);
            this.lbVenu.TabIndex = 16;
            this.lbVenu.Text = "Venue:";
            // 
            // tbEventName
            // 
            this.tbEventName.Location = new System.Drawing.Point(335, -47);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(101, 20);
            this.tbEventName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, -45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Event name:";
            // 
            // tbEventID
            // 
            this.tbEventID.Location = new System.Drawing.Point(115, -47);
            this.tbEventID.Name = "tbEventID";
            this.tbEventID.ReadOnly = true;
            this.tbEventID.Size = new System.Drawing.Size(101, 20);
            this.tbEventID.TabIndex = 13;
            // 
            // lbEventID
            // 
            this.lbEventID.AutoSize = true;
            this.lbEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventID.Location = new System.Drawing.Point(48, -45);
            this.lbEventID.Name = "lbEventID";
            this.lbEventID.Size = new System.Drawing.Size(61, 16);
            this.lbEventID.TabIndex = 12;
            this.lbEventID.Text = "Event ID:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(785, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAmendEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 500);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbEditEvent);
            this.Controls.Add(this.gbViewEdit);
            this.Controls.Add(this.lbAmendEvent);
            this.Controls.Add(this.NameHeader);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAmendEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Event";
            this.Load += new System.EventHandler(this.frmAmendEvent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditEvent)).EndInit();
            this.gbViewEdit.ResumeLayout(false);
            this.gbEditEvent.ResumeLayout(false);
            this.gbEditEvent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAmendEvent;
        private System.Windows.Forms.Label NameHeader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvEditEvent;
        private System.Windows.Forms.GroupBox gbViewEdit;
        private System.Windows.Forms.GroupBox gbEditEvent;
        private System.Windows.Forms.CheckedListBox clbActivities;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndEvent;
        private System.Windows.Forms.DateTimePicker dtpStartEvent;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.TextBox tbEventVenue;
        private System.Windows.Forms.Label lbVenu;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEventID;
        private System.Windows.Forms.Label lbEventID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbEID;
        private System.Windows.Forms.Label label4;
    }
}