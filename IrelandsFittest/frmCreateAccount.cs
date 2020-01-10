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
    public partial class frmCreateAccount : Form
    {
        accounts staffaccount = new accounts();

        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Now.AddYears(-18);
            tbStaffID.Text = staffaccount.getNextStaffID().ToString("00");
        }
        private void ClearEntry()
        {
            tbStaffID.Text = staffaccount.getNextStaffID().ToString("00");
            tbFirstName.Clear();
            tbSurname.Clear();
            tbEmail.Clear();
            tbCounty.Clear();
            tbPassword.Clear();
            tbRetypePassword.Clear();
            
            tbSurname.Focus();
        }


        private void BtnCreateAcc_Click(object sender, EventArgs e)
        {

            // validates whether or not the correct data has been entered

            /**if (txtCompID.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid Competitor ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCompID.Focus();

                return;
            }**/
            if (tbFirstName.Text.Equals("") || tbSurname.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFirstName.Focus();
                return;
            }
            if (dtpDOB.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid Date of Birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDOB.Focus();
                return;
            }

            //Setting the gender!
            if (cbFemale.Checked)
            {
                staffaccount.setGender('F');
            }
            else if (cbMale.Checked)
            {
                staffaccount.setGender('M');
            }


            //Validating username and password
            if (tbEmail.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmail.Focus();
                tbEmail.Clear();
                return;
            }
            else if (tbPassword.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Focus();
                tbPassword.Clear();
                return;
            }
            else if (tbRetypePassword.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbRetypePassword.Focus();
                tbRetypePassword.Clear();
                return;
            }
            else if (staffaccount.userNameExist(tbUsername.Text.ToString()))
            {
                MessageBox.Show("This username is already taken. Please try again.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmail.Focus();
                tbEmail.Clear();
            }
            else if (!tbPassword.Text.Equals(tbRetypePassword.Text))
            {
                tbRetypePassword.Focus();
                tbRetypePassword.Clear();
                MessageBox.Show("You passwords does not match. Please try again.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //INSERT data into Stock Table
                staffaccount.setStaffID(Convert.ToInt32(tbStaffID.Text));
                staffaccount.setDob(dtpDOB.Value.ToString("dd-MMM-yy"));
                staffaccount.setFirstname(tbFirstName.Text);
                staffaccount.setSurname(tbSurname.Text);
                staffaccount.setCounty(tbCounty.Text);
                staffaccount.setEmail(tbEmail.Text);
                staffaccount.setUsername(tbEmail.Text);
                staffaccount.setPassword(tbPassword.Text);


                //INSERT data into the database
                staffaccount.addStaff();
                

                DialogResult dialog = MessageBox.Show("Account successfully created", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    frmMainMenu menu = new frmMainMenu();
                    this.Hide();
                    menu.Show();
                }


                //ClearEntry();
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkTermsAndConditions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
