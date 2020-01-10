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
    public partial class frmResultsMenu : Form
    {
        public frmResultsMenu()
        {
            InitializeComponent();
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

        private void btnInputResults_Click(object sender, EventArgs e)
        {
            frmResultsInput add = new frmResultsInput();
            this.Hide();
            add.Show();
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            frmLeaderboard add = new frmLeaderboard();
            this.Hide();
            add.Show();
        }

        private void frmResultsMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
