using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelRehber11B
{
    internal class Grup
    {

        public int GrupId { get; set; }
        public string GrupAdi { get; set; }
        public string GrupAciklama { get; set; }

        VeriTabaniBaglantisi DBbaglanti;
        SqlConnection baglanti;
        SqlCommand komut;

        public Grup()
        {
            // Yapıcı Fonksiyon
            DBbaglanti = new VeriTabaniBaglantisi();
            baglanti = DBbaglanti.baglan();
            komut = new SqlCommand();
            komut.Connection = baglanti;

        }

       

        public DataTable GrupListele()
        {
            komut.CommandText = "SELECT * FROM gruplar ORDER BY grup_ad";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            return dt;
        }

        public void GrupEkle()
        {

            komut.CommandText = "INSERT INTO gruplar (grup_ad,grup_aciklama) VALUES (@gad,@gaciklama)";
            komut.Parameters.AddWithValue("gad", GrupAdi);
            komut.Parameters.AddWithValue("gaciklama", GrupAciklama);
            komut.ExecuteNonQuery();
        }

        public void GrupSil()
        {
            komut.CommandText = "DELETE FROM gruplar WHERE grup_id = @gid";
            komut.Parameters.AddWithValue("gid", GrupId);
            komut.ExecuteNonQuery();

        }
        public void GrupGuncelle()
        {
            komut.CommandText = "UPDATE gruplar SET grup_ad = @p1, grup_aciklama=@p2 WHERE grup_id = @gid";
            komut.Parameters.AddWithValue("gid", GrupId);
            komut.Parameters.AddWithValue("p1", GrupAdi);
            komut.Parameters.AddWithValue("p2", GrupAciklama);
            komut.ExecuteNonQuery();
        }
    }
}
