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
    public partial class MudurGirisi : Form
    {
        public MudurGirisi()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=SuperMarket; user ID=postgres; password=nurcan2002");
        private void geri_Click(object sender, EventArgs e)
        {
            Login form1=new Login();
            form1.Show();
            this.Hide();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("Select * from admingiris WHERE adminad='" + mudurad_txt.Text + "' AND adminsoyad='" + mudursoyad_txt.Text + "' AND adminsifre='" + mudursifre_txt.Text + "'",baglanti);
            NpgsqlDataReader oku= komut.ExecuteReader();
            if(oku.Read())
            {
                MudurTakip form3=new MudurTakip();
                form3.Show();
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
