namespace Veritabani
{
    partial class MudurGirisi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MudurGirisi));
            this.mudurad = new System.Windows.Forms.Label();
            this.mudursoyad = new System.Windows.Forms.Label();
            this.mudursifre = new System.Windows.Forms.Label();
            this.mudurad_txt = new System.Windows.Forms.TextBox();
            this.mudursoyad_txt = new System.Windows.Forms.TextBox();
            this.mudursifre_txt = new System.Windows.Forms.TextBox();
            this.giris = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mudurad
            // 
            this.mudurad.AutoSize = true;
            this.mudurad.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mudurad.Location = new System.Drawing.Point(176, 96);
            this.mudurad.Name = "mudurad";
            this.mudurad.Size = new System.Drawing.Size(36, 18);
            this.mudurad.TabIndex = 0;
            this.mudurad.Text = "AD :";
            // 
            // mudursoyad
            // 
            this.mudursoyad.AutoSize = true;
            this.mudursoyad.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mudursoyad.Location = new System.Drawing.Point(150, 152);
            this.mudursoyad.Name = "mudursoyad";
            this.mudursoyad.Size = new System.Drawing.Size(64, 18);
            this.mudursoyad.TabIndex = 1;
            this.mudursoyad.Text = "SOYAD :";
            // 
            // mudursifre
            // 
            this.mudursifre.AutoSize = true;
            this.mudursifre.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mudursifre.Location = new System.Drawing.Point(161, 202);
            this.mudursifre.Name = "mudursifre";
            this.mudursifre.Size = new System.Drawing.Size(56, 18);
            this.mudursifre.TabIndex = 2;
            this.mudursifre.Text = "ŞİFRE :";
            // 
            // mudurad_txt
            // 
            this.mudurad_txt.Location = new System.Drawing.Point(219, 89);
            this.mudurad_txt.Name = "mudurad_txt";
            this.mudurad_txt.Size = new System.Drawing.Size(125, 27);
            this.mudurad_txt.TabIndex = 3;
            // 
            // mudursoyad_txt
            // 
            this.mudursoyad_txt.Location = new System.Drawing.Point(219, 149);
            this.mudursoyad_txt.Name = "mudursoyad_txt";
            this.mudursoyad_txt.Size = new System.Drawing.Size(125, 27);
            this.mudursoyad_txt.TabIndex = 4;
            // 
            // mudursifre_txt
            // 
            this.mudursifre_txt.Location = new System.Drawing.Point(219, 199);
            this.mudursifre_txt.Name = "mudursifre_txt";
            this.mudursifre_txt.PasswordChar = '*';
            this.mudursifre_txt.Size = new System.Drawing.Size(125, 27);
            this.mudursifre_txt.TabIndex = 5;
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("giris.BackgroundImage")));
            this.giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.giris.Location = new System.Drawing.Point(219, 256);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(125, 101);
            this.giris.TabIndex = 6;
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geri.BackgroundImage")));
            this.geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.geri.Location = new System.Drawing.Point(12, 24);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(91, 39);
            this.geri.TabIndex = 7;
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(163, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "YÖNETİCİ GİRİŞİ";
            // 
            // MudurGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.mudursifre_txt);
            this.Controls.Add(this.mudursoyad_txt);
            this.Controls.Add(this.mudurad_txt);
            this.Controls.Add(this.mudursifre);
            this.Controls.Add(this.mudursoyad);
            this.Controls.Add(this.mudurad);
            this.Name = "MudurGirisi";
            this.Text = "MudurGirisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label mudurad;
        private Label mudursoyad;
        private Label mudursifre;
        private TextBox mudurad_txt;
        private TextBox mudursoyad_txt;
        private TextBox mudursifre_txt;
        private Button giris;
        private Button geri;
        private Label label1;
    }
}