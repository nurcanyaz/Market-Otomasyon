namespace Veritabani
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Mudurgirisi = new System.Windows.Forms.Button();
            this.kasiyergirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mudurgirisi
            // 
            this.Mudurgirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mudurgirisi.BackgroundImage")));
            this.Mudurgirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mudurgirisi.Location = new System.Drawing.Point(115, 89);
            this.Mudurgirisi.Name = "Mudurgirisi";
            this.Mudurgirisi.Size = new System.Drawing.Size(216, 156);
            this.Mudurgirisi.TabIndex = 0;
            this.Mudurgirisi.UseVisualStyleBackColor = true;
            this.Mudurgirisi.Click += new System.EventHandler(this.Mudurgirisi_Click);
            // 
            // kasiyergirisi
            // 
            this.kasiyergirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kasiyergirisi.BackgroundImage")));
            this.kasiyergirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kasiyergirisi.Location = new System.Drawing.Point(517, 248);
            this.kasiyergirisi.Name = "kasiyergirisi";
            this.kasiyergirisi.Size = new System.Drawing.Size(216, 160);
            this.kasiyergirisi.TabIndex = 1;
            this.kasiyergirisi.UseVisualStyleBackColor = true;
            this.kasiyergirisi.Click += new System.EventHandler(this.kasiyergirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(554, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "KASİYER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(168, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "YÖNETİCİ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(846, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kasiyergirisi);
            this.Controls.Add(this.Mudurgirisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Mudurgirisi;
        private Button kasiyergirisi;
        private Label label1;
        private Label label2;
    }
}