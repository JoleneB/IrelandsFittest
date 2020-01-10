using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrelandsFittest
{
    class Results
    {

        String /*winners,*/ email, activity;
        int activityScore, eventID;


        public Results()
        {
            email = "unknown";
            activity = "";
            activityScore = 0;
            eventID = 0;
        }

        public Results(String email, String activity, int activityScore, int eventID)
        {
            this.email = email;
            this.activity = activity;
            this.activityScore = activityScore;
            this.eventID = eventID;
        }

        public int ActivityScore
        {
            get
            {
                return activityScore;
            }

            set
            {
                activityScore = value;
            }
        }

        public int EventID
        {
            get
            {
                return eventID;
            }

            set
            {
                eventID = value;
            }
        }

        public String Activity
        {
            get
            {
                return activity;
            }

            set
            {
                activity = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }



        public void Results_ComboBox(ComboBox con, string sqlSta)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            //Define SQL query
            String strSQL = sqlSta;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //execute
            OracleDataReader dr = cmd.ExecuteReader();

            //Move data from DR to ComboBox

            while (dr.Read())
            {
                con.Items.Add(dr.GetString(0));
            }

            myConn.Close();
        }

        public int Event_ID_Return(string name)
        {
            int intNextID;

            //connection
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            String strNewID = "SELECT Event_ID FROM Event WHERE Event_Name = '" + name + "'";
            OracleCommand cmd = new OracleCommand(strNewID, myConn);
            myConn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                intNextID = 1;
            else
                intNextID = Convert.ToInt16(dr.GetValue(0));

            myConn.Close();

            return intNextID;
        }

        public int competitor_ID_Return(string email)
        {
            int intNextID;

            //connection
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            String strNewID = "SELECT Competitor_ID FROM accounts WHERE Email = '" + email + "'";
            OracleCommand cmd = new OracleCommand(strNewID, myConn);
            myConn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                intNextID = 1;
            else
                intNextID = Convert.ToInt16(dr.GetValue(0));

            myConn.Close();

            return intNextID;
        }

        public String7777 Activity_Return(string name)
        {
            int intNextID;

            //connection
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            String strNewID = "SELECT Activity FROM events WHERE Activity_Name = '" + name + "'";
            OracleCommand cmd = new OracleCommand(strNewID, myConn);
            myConn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                intNextID = 1;
            else
                intNextID = Convert.ToInt16(dr.GetValue(0));

            myConn.Close();

            return intNextID;
        }

        public void addResult()
        {

            //connection
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            //defining the SQL query
            String strSQL = "INSERT INTO EventResults VALUES (" + this.activityScore + "," + this.eventID + "," + this.activity + "," + competitor_ID_Return(this.email) + ")";

            //define oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //open connection
            myConn.Open();

            //excute
            cmd.ExecuteNonQuery();

            //close datatbase connection
            myConn.Close();

        }//End addActivity method

    }
}
