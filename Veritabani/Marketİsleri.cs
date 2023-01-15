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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veritabani
{
    public partial class Marketİsleri : Form
    {
        public Marketİsleri()
        {
            InitializeComponent();        
        }
           NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=SuperMarket; user ID=postgres; password=nurcan2002");
         
        void VeriGetir()
        {
           
            
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from urunler",baglanti);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource= table;
            

        }
        private void listele_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from urunler", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            urunkodu_txt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            uruntanimi_combo.Text = dataGridView1.CurrentRow.Cells[1].Selected.ToString();
            urunadi_txt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            alisfiyat_txt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            satisfiyat_txt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            adet_numericUpDown1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select kategoriadi from urunkategori", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            uruntanimi_combo.DisplayMember = "kategoriadi";
            uruntanimi_combo.ValueMember = "kategoriid";
            uruntanimi_combo.DataSource = dt;
            baglanti.Close();
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO urunler(kategoriid,urunadi,alisfiyati,satisfiyati,urunadedi) values((select kategoriid from urunkategori where kategoriadi='"+uruntanimi_combo.Text+"'),@urunadi,@alisfiyati,@satisfiyati,@urunadedi)";
            NpgsqlCommand komut = new NpgsqlCommand();
            baglanti.Open();
            komut=new NpgsqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@urunid",Convert.ToInt32(urunkodu_txt.Text));
            komut.Parameters.AddWithValue("@urunadi", urunadi_txt.Text);
            komut.Parameters.AddWithValue("@alisfiyati", Convert.ToInt32(alisfiyat_txt.Text));
            komut.Parameters.AddWithValue("@satisfiyati", Convert.ToInt32(satisfiyat_txt.Text));
            komut.Parameters.AddWithValue("@urunadedi", Convert.ToInt32(adet_numericUpDown1.Value));
            
            komut.ExecuteNonQuery();
            VeriGetir();
            baglanti.Close();
            
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from urunler where urunid=@urunid";
           NpgsqlCommand komut = new NpgsqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@urunid", Convert.ToInt32(urunkodu_txt.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            
            baglanti.Close();
            VeriGetir();


        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE urunler SET urunid=@urunid,urunadi=@urunadi,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati,urunadedi=@urunadedi WHERE urunid=@urunid";

            NpgsqlCommand komut = new NpgsqlCommand();
            baglanti.Open();
            komut = new NpgsqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@urunid", Convert.ToInt32(urunkodu_txt.Text));
            komut.Parameters.AddWithValue("@urunadi", urunadi_txt.Text);
            komut.Parameters.AddWithValue("@alisfiyati", Convert.ToInt32(alisfiyat_txt.Text));
            komut.Parameters.AddWithValue("@satisfiyati", Convert.ToInt32(satisfiyat_txt.Text));
            komut.Parameters.AddWithValue("@urunadedi", Convert.ToInt32(adet_numericUpDown1.Value));
           

            komut.ExecuteNonQuery();
            VeriGetir();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa=new AnaSayfa();
            anaSayfa.Show();
            this.Hide();

        }
    }

}