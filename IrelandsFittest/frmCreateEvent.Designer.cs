namespace IrelandsFittest
{
    partial class frmCreateEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateEvent));
            this.lbCreateEvent = new System.Windows.Forms.Label();
            this.NameHeader = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mbMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mbEventMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mbSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCreateEvent = new System.Windows.Forms.GroupBox();
            this.clbActivities = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartEvent = new System.Windows.Forms.DateTimePicker();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.tbEventVenue = new System.Windows.Forms.TextBox();
            this.lbVenu = new System.Windows.Forms.Label();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEventID = new System.Windows.Forms.TextBox();
            this.lbEventID = new System.Windows.Forms.Label();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbCreateEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCreateEvent
            // 
            this.lbCreateEvent.AutoSize = true;
            this.lbCreateEvent.BackColor = System.Drawing.Color.Transparent;
            this.lbCreateEvent.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbCreateEvent.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbCreateEvent.Location = new System.Drawing.Point(524, 106);
            this.lbCreateEvent.Name = "lbCreateEvent";
            this.lbCreateEvent.Size = new System.Drawing.Size(160, 31);
            this.lbCreateEvent.TabIndex = 5;
            this.lbCreateEvent.Text = "Create Event";
            // 
            // NameHeader
            // 
            this.NameHeader.AutoSize = true;
            this.NameHeader.BackColor = System.Drawing.Color.Transparent;
            this.NameHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NameHeader.Location = new System.Drawing.Point(425, 52);
            this.NameHeader.Name = "NameHeader";
            this.NameHeader.Size = new System.Drawing.Size(422, 48);
            this.NameHeader.TabIndex = 4;
            this.NameHeader.Text = "Ireland\'s Fittest Games";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbMainMenu,
            this.mbEventMenu,
            this.mbSignOut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mbMainMenu
            // 
            this.mbMainMenu.Name = "mbMainMenu";
            this.mbMainMenu.Size = new System.Drawing.Size(80, 20);
            this.mbMainMenu.Text = "Main Menu";
            this.mbMainMenu.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // mbEventMenu
            // 
            this.mbEventMenu.Name = "mbEventMenu";
            this.mbEventMenu.Size = new System.Drawing.Size(82, 20);
            this.mbEventMenu.Text = "Event Menu";
            this.mbEventMenu.Click += new System.EventHandler(this.mbEventMenu_Click);
            // 
            // mbSignOut
            // 
            this.mbSignOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mbSignOut.Name = "mbSignOut";
            this.mbSignOut.Size = new System.Drawing.Size(65, 20);
            this.mbSignOut.Text = "Sign Out";
            this.mbSignOut.Click += new System.EventHandler(this.mbSignOut_Click);
            // 
            // gbCreateEvent
            // 
            this.gbCreateEvent.BackColor = System.Drawing.Color.Transparent;
            this.gbCreateEvent.Controls.Add(this.clbActivities);
            this.gbCreateEvent.Controls.Add(this.label2);
            this.gbCreateEvent.Controls.Add(this.lbEndDate);
            this.gbCreateEvent.Controls.Add(this.dtpEndDate);
            this.gbCreateEvent.Controls.Add(this.dtpStartEvent);
            this.gbCreateEvent.Controls.Add(this.lbStartDate);
            this.gbCreateEvent.Controls.Add(this.tbEventVenue);
            this.gbCreateEvent.Controls.Add(this.lbVenu);
            this.gbCreateEvent.Controls.Add(this.tbEventName);
            this.gbCreateEvent.Controls.Add(this.label1);
            this.gbCreateEvent.Controls.Add(this.tbEventID);
            this.gbCreateEvent.Controls.Add(this.lbEventID);
            this.gbCreateEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbCreateEvent.Location = new System.Drawing.Point(410, 167);
            this.gbCreateEvent.Name = "gbCreateEvent";
            this.gbCreateEvent.Size = new System.Drawing.Size(457, 284);
            this.gbCreateEvent.TabIndex = 7;
            this.gbCreateEvent.TabStop = false;
            this.gbCreateEvent.Text = "Add Event";
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
            this.clbActivities.Location = new System.Drawing.Point(92, 151);
            this.clbActivities.Name = "clbActivities";
            this.clbActivities.Size = new System.Drawing.Size(225, 109);
            this.clbActivities.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Activities:";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndDate.Location = new System.Drawing.Point(220, 112);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(65, 16);
            this.lbEndDate.TabIndex = 9;
            this.lbEndDate.Text = "End date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(309, 112);
            this.dtpEndDate.MaxDate = new System.DateTime(2024, 1, 10, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(2020, 1, 9, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(101, 22);
            this.dtpEndDate.TabIndex = 8;
            this.dtpEndDate.Value = new System.DateTime(2020, 1, 9, 0, 0, 0, 0);
            // 
            // dtpStartEvent
            // 
            this.dtpStartEvent.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartEvent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartEvent.Location = new System.Drawing.Point(89, 112);
            this.dtpStartEvent.MaxDate = new System.DateTime(2024, 1, 10, 0, 0, 0, 0);
            this.dtpStartEvent.MinDate = new System.DateTime(2020, 1, 9, 0, 0, 0, 0);
            this.dtpStartEvent.Name = "dtpStartEvent";
            this.dtpStartEvent.Size = new System.Drawing.Size(101, 20);
            this.dtpStartEvent.TabIndex = 7;
            this.dtpStartEvent.Value = new System.DateTime(2020, 1, 9, 0, 0, 0, 0);
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.Location = new System.Drawing.Point(20, 112);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(68, 16);
            this.lbStartDate.TabIndex = 6;
            this.lbStartDate.Text = "Start date:";
            // 
            // tbEventVenue
            // 
            this.tbEventVenue.Location = new System.Drawing.Point(89, 71);
            this.tbEventVenue.Name = "tbEventVenue";
            this.tbEventVenue.Size = new System.Drawing.Size(101, 20);
            this.tbEventVenue.TabIndex = 5;
            // 
            // lbVenu
            // 
            this.lbVenu.AutoSize = true;
            this.lbVenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVenu.Location = new System.Drawing.Point(22, 72);
            this.lbVenu.Name = "lbVenu";
            this.lbVenu.Size = new System.Drawing.Size(50, 16);
            this.lbVenu.TabIndex = 4;
            this.lbVenu.Text = "Venue:";
            // 
            // tbEventName
            // 
            this.tbEventName.Location = new System.Drawing.Point(309, 26);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(101, 20);
            this.tbEventName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Event name:";
            
            // 
            // tbEventID
            // 
            this.tbEventID.Location = new System.Drawing.Point(89, 26);
            this.tbEventID.Name = "tbEventID";
            this.tbEventID.ReadOnly = true;
            this.tbEventID.Size = new System.Drawing.Size(101, 20);
            this.tbEventID.TabIndex = 1;
            // 
            // lbEventID
            // 
            this.lbEventID.AutoSize = true;
            this.lbEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventID.Location = new System.Drawing.Point(22, 28);
            this.lbEventID.Name = "lbEventID";
            this.lbEventID.Size = new System.Drawing.Size(61, 16);
            this.lbEventID.TabIndex = 0;
            this.lbEventID.Text = "Event ID:";
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(766, 465);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(101, 23);
            this.btnCreateEvent.TabIndex = 8;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // frmCreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 500);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.gbCreateEvent);
            this.Controls.Add(this.lbCreateEvent);
            this.Controls.Add(this.NameHeader);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCreateEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Event";
            this.Load += new System.EventHandler(this.frmCreateEvent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbCreateEvent.ResumeLayout(false);
            this.gbCreateEvent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCreateEvent;
        private System.Windows.Forms.Label NameHeader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mbMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mbEventMenu;
        private System.Windows.Forms.ToolStripMenuItem mbSignOut;
        private System.Windows.Forms.GroupBox gbCreateEvent;
        private System.Windows.Forms.Label lbEventID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEventID;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.DateTimePicker dtpStartEvent;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.TextBox tbEventVenue;
        private System.Windows.Forms.Label lbVenu;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.CheckedListBox clbActivities;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateEvent;
    }
}