
namespace market
{
    partial class fFiyatGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFiyatGuncelle));
            this.bGelirEkle = new System.Windows.Forms.Button();
            this.bAlisFiyat = new System.Windows.Forms.Button();
            this.tAlisFiyat = new market.tNumeric();
            this.tYeniFiyat = new market.tNumeric();
            this.lStandart6 = new market.lStandart();
            this.lStandart5 = new market.lStandart();
            this.lStandart8 = new market.lStandart();
            this.lStandart4 = new market.lStandart();
            this.lStandart3 = new market.lStandart();
            this.lAlisFiyat = new market.lStandart();
            this.lStandart2 = new market.lStandart();
            this.lFiyat = new market.lStandart();
            this.lUrunAdi = new market.lStandart();
            this.lBarkod = new market.lStandart();
            this.lStandart1 = new market.lStandart();
            this.tBarkod = new market.tStandart();
            this.SuspendLayout();
            // 
            // bGelirEkle
            // 
            this.bGelirEkle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bGelirEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGelirEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.bGelirEkle.Location = new System.Drawing.Point(146, 277);
            this.bGelirEkle.Name = "bGelirEkle";
            this.bGelirEkle.Size = new System.Drawing.Size(100, 30);
            this.bGelirEkle.TabIndex = 2;
            this.bGelirEkle.Text = "KAYDET";
            this.bGelirEkle.UseVisualStyleBackColor = false;
            this.bGelirEkle.Click += new System.EventHandler(this.bGelirEkle_Click);
            // 
            // bAlisFiyat
            // 
            this.bAlisFiyat.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bAlisFiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAlisFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.bAlisFiyat.Location = new System.Drawing.Point(146, 366);
            this.bAlisFiyat.Name = "bAlisFiyat";
            this.bAlisFiyat.Size = new System.Drawing.Size(100, 30);
            this.bAlisFiyat.TabIndex = 4;
            this.bAlisFiyat.Text = "KAYDET";
            this.bAlisFiyat.UseVisualStyleBackColor = false;
            this.bAlisFiyat.Click += new System.EventHandler(this.bAlisFiyat_Click);
            // 
            // tAlisFiyat
            // 
            this.tAlisFiyat.BackColor = System.Drawing.Color.White;
            this.tAlisFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tAlisFiyat.Location = new System.Drawing.Point(25, 366);
            this.tAlisFiyat.Name = "tAlisFiyat";
            this.tAlisFiyat.Size = new System.Drawing.Size(115, 30);
            this.tAlisFiyat.TabIndex = 3;
            this.tAlisFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tYeniFiyat
            // 
            this.tYeniFiyat.BackColor = System.Drawing.Color.White;
            this.tYeniFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tYeniFiyat.Location = new System.Drawing.Point(25, 277);
            this.tYeniFiyat.Name = "tYeniFiyat";
            this.tYeniFiyat.Size = new System.Drawing.Size(115, 30);
            this.tYeniFiyat.TabIndex = 1;
            this.tYeniFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart6.Location = new System.Drawing.Point(20, 338);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(139, 25);
            this.lStandart6.TabIndex = 3;
            this.lStandart6.Text = "Yeni Alış Fiyatı";
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart5.Location = new System.Drawing.Point(20, 244);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(151, 25);
            this.lStandart5.TabIndex = 3;
            this.lStandart5.Text = "Yeni Satış Fiyatı";
            // 
            // lStandart8
            // 
            this.lStandart8.AutoSize = true;
            this.lStandart8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart8.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart8.Location = new System.Drawing.Point(20, 208);
            this.lStandart8.Name = "lStandart8";
            this.lStandart8.Size = new System.Drawing.Size(95, 25);
            this.lStandart8.TabIndex = 3;
            this.lStandart8.Text = "Alış Fiyatı";
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart4.Location = new System.Drawing.Point(20, 183);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(107, 25);
            this.lStandart4.TabIndex = 3;
            this.lStandart4.Text = "Satış Fiyatı";
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart3.Location = new System.Drawing.Point(20, 158);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(88, 25);
            this.lStandart3.TabIndex = 3;
            this.lStandart3.Text = "Ürün Adı";
            // 
            // lAlisFiyat
            // 
            this.lAlisFiyat.AutoSize = true;
            this.lAlisFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lAlisFiyat.ForeColor = System.Drawing.Color.DarkCyan;
            this.lAlisFiyat.Location = new System.Drawing.Point(158, 208);
            this.lAlisFiyat.Name = "lAlisFiyat";
            this.lAlisFiyat.Size = new System.Drawing.Size(99, 25);
            this.lAlisFiyat.TabIndex = 2;
            this.lAlisFiyat.Text = "lStandart";
            this.lAlisFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart2.Location = new System.Drawing.Point(20, 133);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(74, 25);
            this.lStandart2.TabIndex = 3;
            this.lStandart2.Text = "Barkod";
            // 
            // lFiyat
            // 
            this.lFiyat.AutoSize = true;
            this.lFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lFiyat.ForeColor = System.Drawing.Color.DarkCyan;
            this.lFiyat.Location = new System.Drawing.Point(158, 183);
            this.lFiyat.Name = "lFiyat";
            this.lFiyat.Size = new System.Drawing.Size(99, 25);
            this.lFiyat.TabIndex = 2;
            this.lFiyat.Text = "lStandart";
            this.lFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lUrunAdi
            // 
            this.lUrunAdi.AutoSize = true;
            this.lUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lUrunAdi.ForeColor = System.Drawing.Color.DarkCyan;
            this.lUrunAdi.Location = new System.Drawing.Point(158, 158);
            this.lUrunAdi.Name = "lUrunAdi";
            this.lUrunAdi.Size = new System.Drawing.Size(90, 25);
            this.lUrunAdi.TabIndex = 2;
            this.lUrunAdi.Text = "lStandart";
            // 
            // lBarkod
            // 
            this.lBarkod.AutoSize = true;
            this.lBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lBarkod.ForeColor = System.Drawing.Color.DarkCyan;
            this.lBarkod.Location = new System.Drawing.Point(158, 133);
            this.lBarkod.Name = "lBarkod";
            this.lBarkod.Size = new System.Drawing.Size(90, 25);
            this.lBarkod.TabIndex = 2;
            this.lBarkod.Text = "lStandart";
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(20, 20);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(74, 25);
            this.lStandart1.TabIndex = 1;
            this.lStandart1.Text = "Barkod";
            // 
            // tBarkod
            // 
            this.tBarkod.BackColor = System.Drawing.Color.White;
            this.tBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tBarkod.Location = new System.Drawing.Point(25, 48);
            this.tBarkod.Name = "tBarkod";
            this.tBarkod.Size = new System.Drawing.Size(250, 30);
            this.tBarkod.TabIndex = 0;
            this.tBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBarkod_KeyDown);
            // 
            // fFiyatGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(341, 408);
            this.Controls.Add(this.bAlisFiyat);
            this.Controls.Add(this.bGelirEkle);
            this.Controls.Add(this.tAlisFiyat);
            this.Controls.Add(this.tYeniFiyat);
            this.Controls.Add(this.lStandart6);
            this.Controls.Add(this.lStandart5);
            this.Controls.Add(this.lStandart8);
            this.Controls.Add(this.lStandart4);
            this.Controls.Add(this.lStandart3);
            this.Controls.Add(this.lAlisFiyat);
            this.Controls.Add(this.lStandart2);
            this.Controls.Add(this.lFiyat);
            this.Controls.Add(this.lUrunAdi);
            this.Controls.Add(this.lBarkod);
            this.Controls.Add(this.lStandart1);
            this.Controls.Add(this.tBarkod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fFiyatGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN FİYAT GÜNCELLE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private tStandart tBarkod;
        private lStandart lStandart1;
        private lStandart lBarkod;
        private lStandart lUrunAdi;
        private lStandart lFiyat;
        private lStandart lStandart2;
        private lStandart lStandart3;
        private lStandart lStandart4;
        private tNumeric tYeniFiyat;
        private System.Windows.Forms.Button bGelirEkle;
        private lStandart lStandart5;
        private tNumeric tAlisFiyat;
        private System.Windows.Forms.Button bAlisFiyat;
        private lStandart lStandart6;
        private lStandart lAlisFiyat;
        private lStandart lStandart8;
    }
}