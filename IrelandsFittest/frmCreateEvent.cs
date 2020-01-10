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
    public partial class frmCreateEvent : Form
    {
        events gameEvent = new events();

        public frmCreateEvent()
        {
            InitializeComponent();
        }

        private void frmCreateEvent_Load(object sender, EventArgs e)
        {
            tbEventID.Text = gameEvent.getNextEventID().ToString("00");
        }

        private void ClearEntry()
        {
            tbEventID.Text = gameEvent.getNextEventID().ToString("00");
            tbEventName.Clear();
            tbEventVenue.Clear();
            dtpStartEvent.Refresh();
            dtpEndDate.Refresh();
            clbActivities.Refresh();

        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            // validates whether or not the correct data has been entered

            if (tbEventName.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid event name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEventName.Focus();
                return;
            }
            if (tbEventVenue.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid event venue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEventVenue.Focus();
                return;
            }

            if (clbActivities.SelectedItem == null)
            {
                MessageBox.Show("Please enter activities in this event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clbActivities.Focus();
                return;
            }

            else
            {
                //INSERT data into Stock Table
                gameEvent.setEventID(Convert.ToInt32(tbEventID.Text));
                gameEvent.setEventSDate(dtpStartEvent.Value.ToString("dd-MMM-yy"));
                gameEvent.setEventEDate(dtpEndDate.Value.ToString("dd-MMM-yy"));
                gameEvent.setEventName(tbEventName.Text);
                gameEvent.setActivity(clbActivities.Text);

                //INSERT data into the database
                gameEvent.addEvent();

                DialogResult dialog = MessageBox.Show("New event added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    frmEventMenu add = new frmEventMenu();
                    this.Hide();
                    add.Show();
                }


                // ClearEntry();

            }
        }

        //***Menu Strip***
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMenu add = new frmMainMenu();
            add.Show();
            this.Hide();
        }

        private void mbEventMenu_Click(object sender, EventArgs e)
        {
            frmEventMenu add = new frmEventMenu();
            add.Show();
            this.Hide();
        }

        private void mbSignOut_Click(object sender, EventArgs e)
        {
            frmLogin add = new frmLogin();
            add.Show();
            this.Hide();
        }
    }
}
