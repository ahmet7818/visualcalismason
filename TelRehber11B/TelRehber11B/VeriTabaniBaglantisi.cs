using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelRehber11B
{
    class VeriTabaniBaglantisi
    {
        private static readonly string connectionString = "Server=LAB7-00;Database=127.0.0.1;Password=123456;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection baglan()
        {

            SqlConnection baglanti = new SqlConnection(connectionString);

            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }


            return baglanti;
        }
    }
}
