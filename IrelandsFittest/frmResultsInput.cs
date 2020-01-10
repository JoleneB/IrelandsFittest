using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace IrelandsFittest
{
    public partial class frmResultsInput : Form
    {
        Results result = new Results();

        public frmResultsInput()
        {
            InitializeComponent();
        }

        private void indivResults_Frm_Load(object sender, EventArgs e)
        {
            string competSQL = "SELECT Email FROM accounts";
            result.Results_ComboBox(cbCompUsername, competSQL);
        }
        private void cbEventName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbEventName_Click(object sender, EventArgs e)
        {
            cbEventName.Items.Clear();
            string eventSQL = "SELECT EVENT_NAME FROM Event";
            result.Results_ComboBox(cbEventName, eventSQL);

        }

        private void cbActivity_Click(object sender, EventArgs e)
        {
            cbActivity.Items.Clear();
            string eventSQL = "SELECT activity_NAME FROM Event WHERE Event_ID = " + result.Event_ID_Return(cbEventName.Text);
            result.Results_ComboBox(cbActivity, eventSQL);
        }
        private void btnAddResult_Click(object sender, EventArgs e)
        {

        }
        private void frmResultsInput_Load(object sender, EventArgs e)
        {

        }
        //***Menu Strip***
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMenu add = new frmMainMenu();
            this.Hide();
            add.Show();
        }

        private void resultsMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResultsMenu add= new frmResultsMenu();
            this.Hide();
            add.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin add = new frmLogin();
            this.Hide();
            add.Show();
        }

        //Add Results
        private void btnAddResult_Click_1(object sender, EventArgs e)
        {
            if (tbScore.Text.Equals(""))
            {
                MessageBox.Show("Please enter an score of the activity in this event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbScore.Focus();
                return;
            }

            //INSERT data into Stock Table
           
            result.EventID = result.Event_ID_Return(cbEventName.Text); 
            result.Activity = result.Activity_Return(cbActivity.Text);
            result.Email = cbCompUsername.Text;
            result.ActivityScore = Convert.ToInt32(tbScore.Text);

            result.addResult();

            DialogResult dialog = MessageBox.Show("Results added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                frmLeaderboard add = new frmLeaderboard();
                this.Hide();
                add.Show();
            }

        }
    }
    }
 
 