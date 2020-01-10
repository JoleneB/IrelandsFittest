using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrelandsFittest
{
    public partial class frmIntro : Form
    {
        public frmIntro()
        {
            InitializeComponent();
        }

        private void frmIntro_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(MyTimer_Tick);
            //3.85 seconds
            timer.Interval = 3850;
            timer.Start();
        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {

            timer.Stop();

            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();

        }

        private void PBIntro_Click(object sender, EventArgs e)
        {

        }
    }
}
