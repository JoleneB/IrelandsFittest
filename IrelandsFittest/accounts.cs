using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrelandsFittest
{
    class accounts
    {
        int staffID;
        String firstName, surname, username, password, county, email, dob;
        char gender;

        public accounts()
        {
            staffID = 0;
            firstName = "unknown";
            surname = "unknown";
            username = "unknown";
            password = "unknown";
            county = "unknown";
            email = "unknown";
            dob = "";
            gender = 'a';
        }

        public accounts(int staffID, String firstName, String surname, String username, String password, String dob, String county, String email, char gender)
        {
            this.staffID = staffID;
            this.firstName = firstName;
            this.surname = surname;
            this.username = username;
            this.password = password;
            this.dob = dob;
            this.county = county;
            this.email = email;
            this.gender = gender;
        }

        //Accessor methods
        public int getStaffID()
        {
            return staffID;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public String getSurname()
        {
            return surname;
        }

        public String getUsername()
        {
            return username;
        }

        public String getPassword()
        {
            return password;
        }

        public String getDob()
        {
            return dob;
        }

        public String getCounty()
        {
            return county;
        }

        public String getEmail()
        {
            return email;
        }

        public char getGender()
        {
            return gender;
        }

        //Mutator methods
        public void setStaffID(int staffID)
        {
            this.staffID = staffID;
        }

        public void setFirstname(String firstName)
        {
            this.firstName = firstName;
        }

        public void setSurname(String surname)
        {
            this.surname = surname;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public void setDob(String dob)
        {
            this.dob = dob;
        }

        public void setCounty(String county)
        {
            this.county = county;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public void setGender(char gender)
        {
            this.gender = gender;
        }

        //Updates the competitor ID each time a new competitor is added
        public int getNextStaffID()
        {
            int intNextID;

            

            //connection
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);


            String strNewID = "SELECT MAX(Competitor_ID) FROM Competitors";
            OracleCommand cmd = new OracleCommand(strNewID, myConn);
            myConn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                intNextID = 1;
            else
                intNextID = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();
            return intNextID;

        } //end getNextCompetitorID

        public void addStaff()
        {
            //create database connectgion string
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            //OracleConnection myConnHome = new OracleConnection(DBConnect.oradbHome);


            //defining the SQL query
            String strSQL = "INSERT INTO Competitors VALUES (" + this.staffID + ",'" + this.password + "','" + this.username + "','" + this.firstName + "','" + this.surname + "','" + this.gender + "','" + this.dob + ")";

            //define oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //open connection
            myConn.Open();

            //excute
            cmd.ExecuteNonQuery();

            //close datatbase connection
            myConn.Close();

        }

        //Checks if the username already exists within the database
        public bool userNameExist(string checkname)
        {
            // connection
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            String strNewID = "SELECT * FROM StaffAccounts WHERE username='" + checkname + "'";
            OracleCommand cmd = new OracleCommand(strNewID, myConn);
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

        }//End userNameExist

    }
}
