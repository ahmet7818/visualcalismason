using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelRehber11B
{
    internal class Kisi
    {
        public int kisiId {  get; set; }
        public string kisiAdi { get; set; }
        public string kisiSoyadi { get; set; }
        public string telNo { get; set; }
        public string telNo2 { get; set; }
        public string mail { get; set; }
        public string unvan { get; set; }
        public int grupId { get; set; }


        VeriTabaniBaglantisi vtbaglantisi = new VeriTabaniBaglantisi();
        SqlConnection baglanti;
        SqlCommand komut;


        public Kisi() {
            // Yapıcı fonksiyon

            vtbaglantisi = new VeriTabaniBaglantisi();
            baglanti = vtbaglantisi.baglan();

            komut = new SqlCommand();
            komut.Connection = baglanti;            
           
        }


        public void KisiEkle()
        {
            komut.CommandText = "INSERT INTO kisiler (kisi_ad,kisi_soyad,telefon1,telefon2,mail,unvan,grup_id) " +
                "VALUES (@kisi_ad,@kisi_soyad,@telefon1,@telefon2,@mail,@unvan,@grup_id) ";
            komut.Parameters.AddWithValue("kisi_ad",kisiAdi);
            komut.Parameters.AddWithValue("kisi_soyad", kisiSoyadi);
            komut.Parameters.AddWithValue("telefon1", telNo);
            komut.Parameters.AddWithValue("telefon2", telNo2);
            komut.Parameters.AddWithValue("mail", mail);
            komut.Parameters.AddWithValue("unvan", unvan);
            komut.Parameters.AddWithValue("grup_id", grupId);

            komut.ExecuteNonQuery();

        }

        public void KisiSil()
        {
            komut.CommandText = "DELETE FROM kisiler WHERE kisi_id = @kid";
            komut.Parameters.AddWithValue("kid", kisiId);
            komut.ExecuteNonQuery ();

        }

        public void KisiGuncelle()
        {


        }

        public void KisiAra()
        {

            

        }

        public DataTable KisiListele()
        {
            komut.CommandText = "SELECT * FROM kisiler  ORDER BY kisi_ad";
            SqlDataAdapter sda = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            sda.Fill(dt);


            return dt;
        }


    }
}
