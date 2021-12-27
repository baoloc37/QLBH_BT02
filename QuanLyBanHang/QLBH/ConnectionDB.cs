using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace QLBH
{
    class ConnectionDB
    {
        string conn = @"Data Source = BAOLOC; Initial Catalog = QLBH; Integrated Security = True";
        public SqlConnection conStr = new SqlConnection();
        public void DataConnection()
        {
            if (conStr.State == ConnectionState.Open)
            {
                conStr.Close();
            }
            conStr.ConnectionString = conn;
            conStr.Open();
        }
    }
}
