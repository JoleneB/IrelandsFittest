using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrelandsFittest
{
    class events
    {
        int eventID;
        String eventName, eventVenue, eventSDate, eventEDate, activity;

        public events()
        {
            eventID = 0;
            eventName = "unknown";
            eventVenue = "unknown";
            eventSDate = "";
            eventEDate = "";
            activity = "";
        }

        public events(int eventID, String eventName, String eventVenue, String eventSDate, String eventEDate, String activity)
        {
            this.eventID = eventID;
            this.eventName = eventName;
            this.eventVenue = eventVenue;
            this.eventSDate = eventSDate;
            this.eventEDate = eventEDate;
            this.activity = activity;

        }

        public int getEventID()
        {
            return eventID;
        }

        public String getEventName()
        {
            return eventName;
        }

        public String getEventVenue()
        {
            return eventVenue;
        }

        public String getEventSDate()
        {
            return eventSDate;
        }

        public String getEventEDate()
        {
            return eventEDate;
        }

        public String getActivity()
        {
            return activity;
        }

        public void setEventID(int eventID)
        {
            this.eventID = eventID;
        }

        public void setEventName(String eventName)
        {
            this.eventName = eventName;
        }

        public void setEventVenue(String eventVenue)
        {
            this.eventVenue = eventVenue;
        }

        public void setEventSDate(String eventSDate)
        {
            this.eventSDate = eventSDate;
        }

        public void setEventEDate(String eventEDate)
        {
            this.eventEDate = eventEDate;
        }

        public void setActivity(String activity)
        {
            this.activity = activity;
        }


        public int getNextEventID()
        {
            int nextEventID;

            //ITT connection
            //OracleConnection myConn = new OracleConnection(DBconnect.oradb);

            //Home connection
             OracleConnection myConn = new OracleConnection(DBConnect.oradb);


            String strNewID = "SELECT MAX(eventID) FROM events";
            OracleCommand cmd = new OracleCommand(strNewID, myConn);
            myConn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextEventID = 1;
            else
                nextEventID = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();
            return nextEventID;

        } //end getNextEventID

        public void addEvent()
        {
            //ITT connection
            //OracleConnection myConn = new OracleConnection(DBconnect.oradb);

            //Home connection
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);


            //defining the SQL query
            String strSQL = "INSERT INTO Event VALUES (" + this.eventID + ",'" + this.eventName + "','" + this.eventVenue + "','" + this.eventSDate + "'," + this.eventEDate + "'," + this.activity + ")";

            //define oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //open connection
            myConn.Open();

            //excute
            cmd.ExecuteNonQuery();

            //close datatbase connection
            myConn.Close();

        }//End AddEvent method

        public bool EventNameExist(string checkActivity)
        {
            //connection
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            String strNewActivity = "SELECT * FROM Event WHERE Event_Name='" + checkActivity + "'";
            OracleCommand cmd = new OracleCommand(strNewActivity, myConn);
            myConn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.Read())
            {
                return true;
            }
            else
                return false;


            //myConn.Close();

        }//End  EventNameExist

        public void searchEvent()
        {
            //ITT connection
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);


            String strUpdate = "SELECT EVENT_ID FROM Event";

            OracleCommand cmd = new OracleCommand(strUpdate, myConn);
            myConn.Open();

            //excute
            cmd.ExecuteNonQuery();

            //close datatbase connection
            myConn.Close();


        }
    }
}
