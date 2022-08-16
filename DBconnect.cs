using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;


namespace Student_Management_System
{
    /*
     * connection between app and mysql database
     */
    class DBconnect
    {
        // Creating MySQL Connection 
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=studentdb");

        // Getting Connection
        public MySqlConnection getconnection
        {
            get
            {
                return connect;
            }
        }

        // creating function to open the Connection
        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }

        // Creating function to close the Connection
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
    }
}
