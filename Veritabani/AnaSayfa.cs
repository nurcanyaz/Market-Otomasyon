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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Marketİsleri marketİsleri = new Marketİsleri();
            marketİsleri.Show();
            this.Hide();
        }

        private void satisislemleri_Click(object sender, EventArgs e)
        {
            Satisİslemleri satis = new Satisİslemleri();
            satis.Show();
            this.Hide();
        }
    }
}
