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
    public partial class frmAmendEvent : Form
 {
        events gameEvents = new events();

        String SqlString = "";
        String sortOrder = "";
        String updateSql = "";
        String delSql = "";
        String iD = "";

        public frmAmendEvent()
        {
            InitializeComponent();
        }


        private void frmAmendEvent_Load(object sender, EventArgs e)
        {
            FillDGV("name");
           
        }

        // Fill data grid with event details
        private void FillDGV(String sortOrder)
        {


            try
            {
                //connection
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                //define SQL query
                String strSQL = "SELECT * FROM events ORDER BY " + sortOrder;


                OracleCommand cmd = new OracleCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                dgvEditEvent.DataSource = ds.Tables["ss"];


                gbViewEdit.Visible = true;
                gbEditEvent.Visible = true;


            }

            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }//End FillDGV

        private void eventInfo(String iD)
        {
            try
            {

                //Connection
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                //define SQL query 
                SqlString = "SELECT * FROM events WHERE Event_ID =  " + iD + "";
                cmd.CommandText = SqlString;
                OracleDataReader dr = cmd.ExecuteReader();

                //Fills the textboxes with info of selected competitor
                dr.Read();
                tbEventID.Text = dr.GetValue(0).ToString();
                tbEventName.Text = dr.GetValue(1).ToString();
                tbEventVenue.Text = dr.GetValue(2).ToString();
                dtpStartEvent.Text = dr.GetValue(3).ToString();
                dtpEndEvent.Text = dr.GetValue(4).ToString();
                clbActivities.Text = dr.GetValue(5).ToString();

                //display the details in` textboxes in the form
                gbEditEvent.Visible = true;
            }

            catch (OracleException io)
            {
                MessageBox.Show(io.Message);
            }

        }//End EventInfo

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvEditEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iD = dgvEditEvent.Rows[dgvEditEvent.CurrentCell.RowIndex].Cells[0].Value.ToString();
            eventInfo(iD);
            
        }

        public void updateEvent()
        {
            //Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            sqlStatements();

            cmd.CommandText = updateSql;

            //excute
            cmd.ExecuteNonQuery();

            //close datatbase connection
            conn.Close();

            gbEditEvent.Refresh();


            DialogResult dialog = MessageBox.Show("The event has been Successfully Updated \nDo you want continue updating?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                frmAmendEvent add = new frmAmendEvent();
                this.Hide();
                add.Show();
            }
            if (dialog == DialogResult.No)
            {
                frmMainMenu menu = new frmMainMenu();
                this.Hide();
                menu.Show();
            }

        }


        public void sqlStatements()
        {
            updateSql = "UPDATE events SET Event_Name = '" + tbEventName.Text + "' ,Event_Venue = '" + tbEventVenue.Text + "' ,Event_SDate = '" + dtpStartEvent.Text + " ' ,Event_EDate = " + dtpEndEvent.Text + "' ,Event_Activity ='" + clbActivities.Text + " WHERE Event_ID = " + iD + "";



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            updateEvent();
            FillDGV("Event_ID");
            gbEditEvent.Refresh();
            //gbEditEvent.Visible = false;
        }

        //*** Menu Strip ***
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin add = new frmLogin();
            add.Show();
            this.Hide();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMenu add = new frmMainMenu();
            add.Show();
            this.Hide();
        }

    }

}
