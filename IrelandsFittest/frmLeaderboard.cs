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
    public partial class frmLeaderboard : Form
    {

        Results results = new Results();

        String SqlString = "";
        public frmLeaderboard()
        {
            InitializeComponent();
        }

        private void cbEvents_Click(object sender, EventArgs e)
        {
            cbEvents.Items.Clear();
            string eventSQL = "SELECT EVENT_NAME FROM Event";
            results.Results_ComboBox(cbEvents, eventSQL);
        }
        private void cbEventName_MouseClick(object sender, MouseEventArgs e)
        {
            string test = cbEvents.Text;
            
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMenu add = new frmMainMenu();
            this.Hide();
            add.Show();
        }

        private void resultsMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResultsMenu add = new frmResultsMenu();
            this.Hide();
            add.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin add = new frmLogin();
            this.Hide();
            add.Show();
        }

        private void frmLeaderboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {


            try
            {
                //connection
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                //defining SQL query
                String strSQL = "SELECT * FROM EventResults WHERE Event_ID = " + results.Event_ID_Return(cbEvents.Text) + " ORDER BY Score";


                OracleCommand cmd = new OracleCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                dgvLeaderboard.DataSource = ds.Tables["ss"];
                

                dgvLeaderboard.Visible = true;

            }

            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }//End FillGrid
    }
}
