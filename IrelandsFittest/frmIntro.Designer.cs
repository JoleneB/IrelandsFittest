namespace IrelandsFittest
{
    partial class frmIntro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntro));
            this.PBIntro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBIntro)).BeginInit();
            this.SuspendLayout();
            // 
            // PBIntro
            // 
            this.PBIntro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.PBIntro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBIntro.Image = ((System.Drawing.Image)(resources.GetObject("PBIntro.Image")));
            this.PBIntro.Location = new System.Drawing.Point(-3, -5);
            this.PBIntro.Margin = new System.Windows.Forms.Padding(4);
            this.PBIntro.Name = "PBIntro";
            this.PBIntro.Size = new System.Drawing.Size(934, 539);
            this.PBIntro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBIntro.TabIndex = 0;
            this.PBIntro.TabStop = false;
            this.PBIntro.Click += new System.EventHandler(this.PBIntro_Click);
            // 
            // frmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 537);
            this.Controls.Add(this.PBIntro);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.frmIntro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBIntro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBIntro;
        private System.Windows.Forms.Timer timer;
    }
}

