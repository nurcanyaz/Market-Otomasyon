using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritabani
{
    public partial class MudurTakip : Form
    {
        public MudurTakip()
        {
            InitializeComponent();

            string connString = "server=localHost; port=5432; Database=SuperMarket; user ID=postgres; password=nurcan2002";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT SUM(urunadedi) FROM urunler", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var toplam = reader.GetInt32(0);
                        stoktaki_lbl.Text = toplam.ToString();
                    }
                }
            }
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT uruncesitsayisi FROM uruncesidi", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var toplam = reader.GetInt32(0);
                        label5.Text = toplam.ToString();
                    }
                }
            }

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();


                using (var cmd = new NpgsqlCommand("SELECT kasatutar FROM kasa", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var kasatutar = reader.GetInt32(0);
                        toplamtutar_lbl.Text = kasatutar.ToString();
                    }

                }

            }

        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=SuperMarket; user ID=postgres; password=nurcan2002");



        void VeriGetir()
        {


            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from personel", baglanti);
            DataTable table = new DataTable();
            da.Fill(table);
            personel_datagrid.DataSource = table;


        }


        private void listele_btn_Click(object sender, EventArgs e)
        {
            
            NpgsqlCommand komut = new NpgsqlCommand("select * from personel", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            personel_datagrid.DataSource = dt;
           baglanti.Close();
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu = new NpgsqlCommand();

            if (pad_txt.Text == "" || psigortano_txt.Text == "")
            {
                MessageBox.Show("Lütfen bos birakmayiniz.");
            }

            else
            {
                baglanti.Open();
                    
                
                sorgu.Connection = baglanti;
                sorgu.CommandType = CommandType.StoredProcedure;

                sorgu.CommandText = "KullaniciEkle";

                sorgu.Parameters.Add(new NpgsqlParameter("@personeladi", NpgsqlTypes.NpgsqlDbType.Char));
                sorgu.Parameters[0].Value = pad_txt.Text.PadRight(50, ' '); 
                sorgu.Parameters.Add(new NpgsqlParameter("@personelsoyadi", NpgsqlTypes.NpgsqlDbType.Char));
                sorgu.Parameters[1].Value = psoyad_txt.Text.PadRight(50, ' '); 
                sorgu.Parameters.AddWithValue("@personelsigortano", Convert.ToInt32(psigortano_txt.Text));

                sorgu.ExecuteNonQuery();
                VeriGetir();
                MessageBox.Show("eklendi");
                baglanti.Close();
            }

        }
        
    
        private void sil_btn_Click(object sender, EventArgs e)
        {

            string sorgu = "Delete from personel where personelno=@personelno";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@personelno", Convert.ToInt32(personelno_txt.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();

            baglanti.Close();
            VeriGetir();
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {

            string sorgu = "UPDATE personel SET  personelno=@personelno,personeladi=@personeladi,personelsoyadi=@personelsoyadi,personelsigortano=@personelsigortano WHERE personelno=@personelno";

            NpgsqlCommand komut = new NpgsqlCommand();
            baglanti.Open();
            komut = new NpgsqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@personelno", Convert.ToInt32(personelno_txt.Text));
            komut.Parameters.AddWithValue("@personeladi", pad_txt.Text);
            komut.Parameters.AddWithValue("@personelsoyadi", psoyad_txt.Text);
            komut.Parameters.AddWithValue("@personelsigortano", Convert.ToInt32(psigortano_txt.Text));
            komut.ExecuteNonQuery();
            VeriGetir();
            baglanti.Close();

        }
        private void personel_datagrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            personelno_txt.Text = personel_datagrid.CurrentRow.Cells[0].Value.ToString();
            pad_txt.Text = personel_datagrid.CurrentRow.Cells[1].Value.ToString();
            psoyad_txt.Text = personel_datagrid.CurrentRow.Cells[2].Value.ToString();
            psigortano_txt.Text = personel_datagrid.CurrentRow.Cells[3].Value.ToString();

        }

        private void stoktaki_lbl_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT SUM(satistutari) FROM satislar";

            
            using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, baglanti))
            {
                decimal toplamsatistutari = (decimal)cmd.ExecuteScalar();
                toplamtutar_lbl.Text = toplamsatistutari.ToString();

                baglanti.Close();

            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Login login= new Login();
            login.Show();
            this.Hide();
        }


   
        private void toplamtutar_lbl_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("Select * From urunbilgisi", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
        }
    }
}
