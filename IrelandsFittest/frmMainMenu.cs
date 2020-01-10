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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void msSignOut_Click(object sender, EventArgs e)
        {
            frmLogin add = new frmLogin();
            add.Show();
            this.Hide();
        }

        private void NameHeader_Click(object sender, EventArgs e)
        {

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCompetitor_Click(object sender, EventArgs e)
        {
            frmAddCompetitors add = new frmAddCompetitors();
            this.Hide();
            add.Show();
        }

        private void btnAddEvents_Click(object sender, EventArgs e)
        {
            frmEventMenu add = new frmEventMenu();
            this.Hide();
            add.Show();
        }


        private void btnResults_Click(object sender, EventArgs e)
        {
            frmResultsMenu add = new frmResultsMenu();
            this.Hide();
            add.Show();
        }
    }
}
