using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelRehber11B
{
    public partial class GrupIslemleri : Form
    {
        SqlConnection conn = new SqlConnection();
        public GrupIslemleri()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            // EKLE BUTONU
            Grup grup_nesne = new Grup();
            grup_nesne.GrupAdi = txtGrupAd.Text;
            grup_nesne.GrupAciklama = txtGrupAciklama.Text;

            grup_nesne.GrupEkle();
            dgwGrupTablosu.DataSource = grup_nesne.GrupListele();


        }

        private void GrupIslemleri_Load(object sender, EventArgs e)
        {
            // Form AÇıldığında
            Grup grup = new Grup();
            dgwGrupTablosu.DataSource =  grup.GrupListele();
        }

        private void dgwGrupTablosu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        int seciliId = -1;

        private void dgwGrupTablosu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagridview seçiliyken, Şimşek resmine bas (olaylar),
            // CellClick olayına çift tıkla. aşağıdaki kodları yaz.

            seciliId = int.Parse( dgwGrupTablosu.CurrentRow.Cells[0].Value.ToString());
            txtGrupAd.Text = dgwGrupTablosu.CurrentRow.Cells[1].Value.ToString();
            txtGrupAciklama.Text = dgwGrupTablosu.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        { // Güncelle butonuna basıldığında
            Grup grup = new Grup();
            grup.GrupId = seciliId;
            grup.GrupAdi = txtGrupAd.Text;
            grup.GrupAciklama = txtGrupAciklama.Text;

            grup.GrupGuncelle();
            dgwGrupTablosu.DataSource = grup.GrupListele();
        }
        private void button3_Click(object sender, EventArgs e)
        { // Sil butonuna basıldığında
            Grup grup = new Grup();
            grup.GrupId = seciliId;
            grup.GrupSil();
            dgwGrupTablosu.DataSource = grup.GrupListele();
        }
    }
}
