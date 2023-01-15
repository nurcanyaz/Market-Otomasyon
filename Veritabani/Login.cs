namespace Veritabani
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void kasiyergirisi_Click(object sender, EventArgs e)
        {
            KasiyerGirisi kasiyerGirisi = new KasiyerGirisi();
            kasiyerGirisi.Show();
            this.Hide();
        }

        private void Mudurgirisi_Click(object sender, EventArgs e)
        {
            MudurGirisi mudur = new MudurGirisi();
            mudur.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}