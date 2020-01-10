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
    public partial class frmLogin : Form
    {   accounts staffAccount = new accounts();
        String sql = " ";
        String username = " ";
        String password = " ";

        public frmLogin()
        {
            InitializeComponent();
            
        }
        
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            frmCreateAccount add = new frmCreateAccount();
            add.Show();
            this.Hide();
        }

        //this validates the username that was entered 
        private bool checkUsername()
        {
            if (!tbUsername.Text.Equals(""))
            {
                try
                {
                    //Connection
                    OracleConnection conn = new OracleConnection(DBConnect.oradb);

                    conn.Open();

                    //defining SQL query
                    sql = "SELECT Username FROM accounts WHERE username LIKE '" + tbUsername.Text + "' ";


                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;

                    //Execute reader
                    OracleDataReader data = cmd.ExecuteReader();
                    data.Read();

                    if (data.HasRows)
                    {
                        username = data.GetValue(0).ToString();
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("The username entered isn't recognised. \nPlease try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                //close datatbase connection
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }

            }
            else
                return false;
        }

        //validates a match of the password to the username
        public bool match()
        {

            try
            {
                //Connection
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                //Opening database connection
                conn.Open();

                //defining SQL query
                sql = "SELECT Pass1 FROM accounts WHERE username LIKE '" + tbUsername.Text + "' ";

                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                OracleDataReader data = cmd.ExecuteReader();
                data.Read();
                password = data.GetValue(0).ToString();

                if (password.Equals(tbPassword.Text.ToString()))
                {
                    return true;
                }

                else
                    return false;

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }//End Match


           private void frmLogin_Load(object sender, EventArgs e)
           {
            Timer MyTimer = new Timer();
            MyTimer.Stop();
           }

       

        private void LoginHeader_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            if (checkUsername())
            {
                if (match())
                {
                    MessageBox.Show("Welcome", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMainMenu main = new frmMainMenu();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect. \nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbPassword.Focus();
                    tbPassword.Clear();
                    tbUsername.Clear();
                }
            }
        }
    }
}
