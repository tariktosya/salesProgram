
namespace market
{
    partial class GelirGider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GelirGider));
            this.lStandart1 = new market.lStandart();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.lGelirGider = new market.lStandart();
            this.tKart = new market.tNumeric();
            this.tNakit = new market.tNumeric();
            this.lStandart3 = new market.lStandart();
            this.lStandart4 = new market.lStandart();
            this.tAciklama = new market.tStandart();
            this.lStandart5 = new market.lStandart();
            this.dateTarih = new System.Windows.Forms.DateTimePicker();
            this.lStandart6 = new market.lStandart();
            this.bEkle = new market.bStandart();
            this.SuspendLayout();
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(35, 92);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(123, 25);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "Ödeme Türü";
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "NAKİT",
            "KART",
            "NAKİT-KART"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(40, 120);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(261, 33);
            this.cmbOdemeTuru.TabIndex = 2;
            this.cmbOdemeTuru.SelectedIndexChanged += new System.EventHandler(this.cmbOdemeTuru_SelectedIndexChanged);
            // 
            // lGelirGider
            // 
            this.lGelirGider.AutoSize = true;
            this.lGelirGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lGelirGider.ForeColor = System.Drawing.Color.DarkCyan;
            this.lGelirGider.Location = new System.Drawing.Point(35, 27);
            this.lGelirGider.Name = "lGelirGider";
            this.lGelirGider.Size = new System.Drawing.Size(103, 25);
            this.lGelirGider.TabIndex = 3;
            this.lGelirGider.Text = "lGelirGider";
            // 
            // tKart
            // 
            this.tKart.BackColor = System.Drawing.Color.White;
            this.tKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tKart.Location = new System.Drawing.Point(186, 222);
            this.tKart.Name = "tKart";
            this.tKart.Size = new System.Drawing.Size(115, 30);
            this.tKart.TabIndex = 4;
            this.tKart.Text = "0";
            this.tKart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tNakit
            // 
            this.tNakit.BackColor = System.Drawing.Color.White;
            this.tNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tNakit.Location = new System.Drawing.Point(40, 222);
            this.tNakit.Name = "tNakit";
            this.tNakit.Size = new System.Drawing.Size(115, 30);
            this.tNakit.TabIndex = 5;
            this.tNakit.Text = "0";
            this.tNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart3.Location = new System.Drawing.Point(181, 194);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(48, 25);
            this.lStandart3.TabIndex = 6;
            this.lStandart3.Text = "Kart";
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart4.Location = new System.Drawing.Point(35, 194);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(56, 25);
            this.lStandart4.TabIndex = 7;
            this.lStandart4.Text = "Nakit";
            // 
            // tAciklama
            // 
            this.tAciklama.BackColor = System.Drawing.Color.White;
            this.tAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tAciklama.Location = new System.Drawing.Point(40, 303);
            this.tAciklama.Multiline = true;
            this.tAciklama.Name = "tAciklama";
            this.tAciklama.Size = new System.Drawing.Size(261, 154);
            this.tAciklama.TabIndex = 8;
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart5.Location = new System.Drawing.Point(35, 275);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(92, 25);
            this.lStandart5.TabIndex = 9;
            this.lStandart5.Text = "Açıklama";
            // 
            // dateTarih
            // 
            this.dateTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dateTarih.Location = new System.Drawing.Point(40, 507);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(261, 30);
            this.dateTarih.TabIndex = 10;
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart6.Location = new System.Drawing.Point(35, 479);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(57, 25);
            this.lStandart6.TabIndex = 11;
            this.lStandart6.Text = "Tarih";
            // 
            // bEkle
            // 
            this.bEkle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bEkle.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.bEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bEkle.ForeColor = System.Drawing.Color.White;
            this.bEkle.Image = global::market.Properties.Resources.plus;
            this.bEkle.Location = new System.Drawing.Point(169, 566);
            this.bEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(132, 81);
            this.bEkle.TabIndex = 12;
            this.bEkle.Text = "EKLE";
            this.bEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bEkle.UseVisualStyleBackColor = false;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // GelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(353, 668);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.lStandart6);
            this.Controls.Add(this.dateTarih);
            this.Controls.Add(this.lStandart5);
            this.Controls.Add(this.tAciklama);
            this.Controls.Add(this.lStandart4);
            this.Controls.Add(this.lStandart3);
            this.Controls.Add(this.tNakit);
            this.Controls.Add(this.tKart);
            this.Controls.Add(this.lGelirGider);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.lStandart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(371, 715);
            this.Name = "GelirGider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir-Gider İşlemleri";
            this.Load += new System.EventHandler(this.GelirGider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lStandart lStandart1;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private lStandart lGelirGider;
        private tNumeric tKart;
        private tNumeric tNakit;
        private lStandart lStandart3;
        private lStandart lStandart4;
        private tStandart tAciklama;
        private lStandart lStandart5;
        private System.Windows.Forms.DateTimePicker dateTarih;
        private lStandart lStandart6;
        private bStandart bEkle;
    }
}