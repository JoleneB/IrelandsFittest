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
    public partial class frmAddCompetitors : Form
    {
        accounts competitorAccount = new accounts();
        public frmAddCompetitors()
        {
            InitializeComponent();
        }
        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Now.AddYears(-18);
            tbCompetitorID.Text = competitorAccount.getNextStaffID().ToString("00");
        }
        private void ClearEntry()
        {
            tbCompetitorID.Text = competitorAccount.getNextStaffID().ToString("00");
            tbFirstName.Clear();
            tbSurname.Clear();
            tbEmail.Clear();
            tbCounty.Clear();
            

            tbSurname.Focus();
        }


        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin add = new frmLogin();
            add.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMenu add = new frmMainMenu();
            add.Show();
            this.Hide();

        }


        private void BtnAddCompetitor_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text.Equals("") || tbSurname.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid Competitor Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFirstName.Focus();
                return;
            }
            if (dtpDOB.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid Date of Birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDOB.Focus();
                return;
            }
            if (tbCounty.Text.Equals("") )
            {
                MessageBox.Show("Please enter a valid county", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFirstName.Focus();
                return;
            }

            //Setting the gender!
            if (cbFemale.Checked)
            {
                competitorAccount.setGender('F');
            }
            else if (cbMale.Checked)
            {
                competitorAccount.setGender('M');
            }

            else
            {
                //INSERT data into Stock Table
                competitorAccount.setStaffID(Convert.ToInt32(tbCompetitorID.Text));
                competitorAccount.setDob(dtpDOB.Value.ToString("dd-MMM-yy"));
                competitorAccount.setFirstname(tbFirstName.Text);
                competitorAccount.setSurname(tbSurname.Text);
                competitorAccount.setCounty(tbCounty.Text);
                competitorAccount.setEmail(tbEmail.Text);

                //INSERT data into the database
                competitorAccount.addStaff();


                DialogResult dialog = MessageBox.Show("Competitor successfully created", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    frmMainMenu menu = new frmMainMenu();
                    this.Hide();
                    menu.Show();
                }
            }
        }

        private void tbCompetitorID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
