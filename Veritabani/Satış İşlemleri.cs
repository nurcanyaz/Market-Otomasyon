using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Veritabani
{
    public partial class Satisİslemleri : Form
    {
        public Satisİslemleri()
        {
            InitializeComponent();
            NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=SuperMarket; user ID=postgres; password=nurcan2002");

            komut = new NpgsqlCommand();

            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = "SELECT urunadi,satisfiyati,urunadedi,kategoriid FROM urunler";
            dr = komut.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                VeriGoster_datagrid.DataSource = dt;
            }
            baglanti.Dispose();
            baglanti.Close();
            tarih_lbl.Text = DateTime.Now.ToLongDateString();

        }

        NpgsqlConnection baglanti;
        NpgsqlCommand komut;
        NpgsqlDataReader dr;



        // NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=SuperMarket; user ID=postgres; password=nurcan2002");

        private void back_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in VeriGoster_datagrid.SelectedRows)
            {
                string value = row.Cells[1].Value.ToString();
                int s1 = Convert.ToInt32(textBox1.Text);
                int s2 = Convert.ToInt32(value);
                int tutar = s1 * s2;
                tutarTL_lbl.Text = tutar.ToString();
                string kategoriid = row.Cells[3].Value.ToString();
                string value1 = row.Cells[2].Value.ToString();
                if (Convert.ToInt32(textBox1.Text) > Convert.ToInt32(value1))
                {
                    MessageBox.Show("Magazının toplam stogunda bu kadar ürün yok,girebileceginiz maksimum deger:" + value1 + " " + " dir");
                }
                else if (textBox1.Text == "")
                    MessageBox.Show("Lütfen Kac Adet Almak istediginizi giriniz", "Tüm alanları doldurun");


            }
        }


        private void market_btn_Click(object sender, EventArgs e)
        {
            Marketİsleri marketİsleri = new Marketİsleri();
            marketİsleri.Show();
            this.Hide();
        }

        private void Satisİslemleri_Load(object sender, EventArgs e)
        {
            sepet.View = View.Details;
            sepet.GridLines = true;
            sepet.FullRowSelect = true;

            sepet.Columns.Add("ÜRÜN ADI", 130);
            sepet.Columns.Add("ÜRÜN FİYATI (TL)", 120);
            sepet.Columns.Add("ADET", 80);
            sepet.Columns.Add("KATEGORİİD", 105);

        }


        private void sepeteekle_btn_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow row in VeriGoster_datagrid.SelectedRows)
            {
                string ad = row.Cells[0].Value.ToString();
                string fiyat = row.Cells[1].Value.ToString();
                string kategoriid = row.Cells[3].Value.ToString();

                int s1 = Convert.ToInt32(textBox1.Text);
                int s2 = Convert.ToInt32(fiyat);
                int yfiyat = s1 * s2;
                string yyfiyat = Convert.ToString(yfiyat);

                string[] sira = { ad, yyfiyat, textBox1.Text,kategoriid};
                var satir = new ListViewItem(sira);
                sepet.Items.Add(satir);



            }
        }

        private void toptutar_btn_Click(object sender, EventArgs e)
        {

            decimal topla = 0;

            for (int sayi = 0; sayi <= sepet.Items.Count - 1; sayi++)

            {
                decimal sayi1;
                string sayi2;
                sayi2 = sepet.Items[sayi].SubItems[1].Text;
                sayi1 = decimal.Parse(sayi2);
                topla = topla + sayi1;
            }

            toptutar_lbl.Text = Convert.ToString(topla);
        }

        private void nalit_rb_CheckedChanged(object sender, EventArgs e)
        {
            double indirimorani = 0.05;
            double indirim = Convert.ToDouble(toptutar_lbl.Text) * indirimorani;
            double odememiktari = Convert.ToDouble(toptutar_lbl.Text) - indirim;
            sontutar_txt.Text = Convert.ToString(odememiktari);
            odemetamamla.Visible = true;
        }

        private void kredikarti_rb_CheckedChanged(object sender, EventArgs e)
        {
            double indirimorani2 = 0.03;
            double indirim2 = Convert.ToDouble(toptutar_lbl.Text) * indirimorani2;
            double odememiktari2 = Convert.ToDouble(toptutar_lbl.Text) - indirim2;
            sontutar_txt.Text = Convert.ToString(odememiktari2);
            odemetamamla.Visible = true;

        }

        private void odemetamamla_Click(object sender, EventArgs e)
        {

            MessageBox.Show("NY MARKET" + "\n" + "ÇANKAYA/ANKARA" + "\n \n Satış Tarihi:" + DateTime.Now + "\n\n " + "Ödeme Tutarı:" + toptutar_lbl.Text);
            odemetamamla.Enabled = false;
            sepeteekle_btn.Enabled = false;
            hesapla_btn.Enabled = false;
            kredikarti_rb.Enabled = false;
            nalit_rb.Enabled = false;

            int etkilenen = 0;

            for (int i = 0; i < sepet.Items.Count; i++)
            {
                try
                {
                    NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=SuperMarket; user ID=postgres; password=nurcan2002");
                    NpgsqlCommand komut = new NpgsqlCommand();
                    komut.Connection = baglanti;
                    
                    string urunadi = sepet.Items[i].SubItems[0].Text;
                    string urunadedi = sepet.Items[i].SubItems[2].Text;
                    string kategoriid = sepet.Items[i].SubItems[3].Text;
                    komut.CommandType = System.Data.CommandType.Text;
                    komut.CommandText = "insert into satislar (satistutari,urunadi,urunadedi,satistarihi,kategoriid) values (@satistutari,@urunadi,@urunadedi,@satistarihi,@kategoriid)";

                    komut.Parameters.AddWithValue("@satistutari", Convert.ToInt32(sontutar_txt.Text));
                    komut.Parameters.AddWithValue("@urunadi", urunadi);
                    komut.Parameters.AddWithValue("@urunadedi", Convert.ToInt32(urunadedi));
                    komut.Parameters.Add("@satistarihi", NpgsqlTypes.NpgsqlDbType.Date).Value = DateTime.Now;
                    komut.Parameters.AddWithValue("@kategoriid",Convert.ToInt32(kategoriid));
             


                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kayıt edildi");
                }
            }

            if (etkilenen != 0)
            { MessageBox.Show("Kayıt edilmedi !!!"); }
            else { MessageBox.Show("Kayıt edildi..."); }
        }

        private void newsiparis_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[0] == this)
            {
                Application.Restart();
            }
            else
            {
                Satisİslemleri f = new Satisİslemleri();
                f.Show();
                this.Close();

            }
        }
    }
}