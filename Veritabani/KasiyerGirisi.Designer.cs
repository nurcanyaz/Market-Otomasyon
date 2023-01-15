namespace Veritabani
{
    partial class KasiyerGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasiyerGirisi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ad_txt = new System.Windows.Forms.TextBox();
            this.sigortano_txt = new System.Windows.Forms.TextBox();
            this.soyad_txt = new System.Windows.Forms.TextBox();
            this.giris = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(244, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "KASİYER GİRİŞİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(202, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(176, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYAD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(139, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "SİGORTA NO :";
            // 
            // ad_txt
            // 
            this.ad_txt.Location = new System.Drawing.Point(245, 137);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(166, 27);
            this.ad_txt.TabIndex = 4;
            // 
            // sigortano_txt
            // 
            this.sigortano_txt.Location = new System.Drawing.Point(244, 229);
            this.sigortano_txt.Name = "sigortano_txt";
            this.sigortano_txt.PasswordChar = '*';
            this.sigortano_txt.Size = new System.Drawing.Size(166, 27);
            this.sigortano_txt.TabIndex = 5;
            this.sigortano_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // soyad_txt
            // 
            this.soyad_txt.Location = new System.Drawing.Point(245, 183);
            this.soyad_txt.Name = "soyad_txt";
            this.soyad_txt.Size = new System.Drawing.Size(166, 27);
            this.soyad_txt.TabIndex = 6;
            // 
            // giris
            // 
            this.giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("giris.BackgroundImage")));
            this.giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.giris.Location = new System.Drawing.Point(262, 292);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(137, 109);
            this.giris.TabIndex = 7;
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // geri
            // 
            this.geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geri.BackgroundImage")));
            this.geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.geri.Location = new System.Drawing.Point(15, 12);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(94, 59);
            this.geri.TabIndex = 8;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // KasiyerGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(727, 479);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.soyad_txt);
            this.Controls.Add(this.sigortano_txt);
            this.Controls.Add(this.ad_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KasiyerGirisi";
            this.Text = "KasiyerGirisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox ad_txt;
        private TextBox sigortano_txt;
        private TextBox soyad_txt;
        private Button giris;
        private Button geri;
    }
}