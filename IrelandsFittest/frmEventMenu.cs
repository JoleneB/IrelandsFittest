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
    public partial class frmEventMenu : Form
    {
        public frmEventMenu()
        {
            InitializeComponent();
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            frmCreateEvent add = new frmCreateEvent();
            add.Show();
            this.Hide();
        }


        private void btnAmendEvent_Click(object sender, EventArgs e)
        {
            frmAmendEvent add = new frmAmendEvent();
            add.Show();
            this.Hide();
        }

        //***Menu Strip***
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMenu add = new frmMainMenu();
            add.Show();
            this.Hide();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin add = new frmLogin();
            add.Show();
            this.Hide();
        }
        private void frmEventMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
