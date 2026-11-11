using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelRehber11B
{
    internal class VTBaglanti
    {
        private static readonly string baglantiMetni = "Server=LAB7-00;Database=RehberDB;Password=123456;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection baglan()
        
        {

            SqlConnection conn = new SqlConnection(baglantiMetni);
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;

        }

        

        

    }
}
