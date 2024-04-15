using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PCBuilder
{
    class DB
    {
        SqlConnection connection = new SqlConnection("Server=LAPTOP-A5I4C8BV\\MSSQLSERVER01; Database= PCBuilder;Trusted_Connection=True;"); //DESKTOP-RNGC4SV + DESKTOP-R7CO1DI\\SQLEXPRESS

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
        

    }
}
