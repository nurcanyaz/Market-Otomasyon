namespace Veritabani
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.satisislemleri = new System.Windows.Forms.Button();
            this.dukkanislemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // satisislemleri
            // 
            this.satisislemleri.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.satisislemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("satisislemleri.BackgroundImage")));
            this.satisislemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.satisislemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satisislemleri.Location = new System.Drawing.Point(222, 173);
            this.satisislemleri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.satisislemleri.Name = "satisislemleri";
            this.satisislemleri.Size = new System.Drawing.Size(194, 137);
            this.satisislemleri.TabIndex = 0;
            this.satisislemleri.Text = "SATIŞ İŞLEMLERİ";
            this.satisislemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.satisislemleri.UseVisualStyleBackColor = false;
            this.satisislemleri.Click += new System.EventHandler(this.satisislemleri_Click);
            // 
            // dukkanislemleri
            // 
            this.dukkanislemleri.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dukkanislemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dukkanislemleri.BackgroundImage")));
            this.dukkanislemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dukkanislemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dukkanislemleri.Location = new System.Drawing.Point(488, 173);
            this.dukkanislemleri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dukkanislemleri.Name = "dukkanislemleri";
            this.dukkanislemleri.Size = new System.Drawing.Size(203, 137);
            this.dukkanislemleri.TabIndex = 1;
            this.dukkanislemleri.Text = "MARKET İŞLERİ";
            this.dukkanislemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dukkanislemleri.UseVisualStyleBackColor = false;
            this.dukkanislemleri.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(876, 490);
            this.Controls.Add(this.dukkanislemleri);
            this.Controls.Add(this.satisislemleri);
            this.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private Button satisislemleri;
        private Button dukkanislemleri;
    }
}