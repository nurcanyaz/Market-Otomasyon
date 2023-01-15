using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql.PostgresTypes;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Npgsql.Internal;

namespace Veritabani
{
    public partial class KasiyerGirisi : Form
    {
        public KasiyerGirisi()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=SuperMarket; user ID=postgres; password=nurcan2002");

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void geri_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }
      
        private void giris_Click(object sender, EventArgs e)
        {
            

            baglanti.Open();
            string PersonelAdi;
            string PersonelSoyadi;
            String PersonelSigortaNo;
            PersonelAdi = ad_txt.Text;
            PersonelSoyadi = soyad_txt.Text;
            PersonelSigortaNo=sigortano_txt.Text;
            NpgsqlCommand komut = new NpgsqlCommand("Select * from personel WHERE personeladi='" + ad_txt.Text + "' AND personelsoyadi='" + soyad_txt.Text + "' AND personelsigortano='" + sigortano_txt.Text + "'", baglanti);
            NpgsqlDataReader oku = komut.ExecuteReader();
            
            if (oku.Read())
            {
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız...");
            }

            baglanti.Close();
        }

    }
    
}

