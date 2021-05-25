
namespace market
{
    partial class UrunGiris
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chUrunType = new System.Windows.Forms.CheckBox();
            this.lKullanici = new System.Windows.Forms.Label();
            this.tBarkod = new System.Windows.Forms.TextBox();
            this.bBarkodOlustur = new System.Windows.Forms.Button();
            this.tUrunSayisi = new System.Windows.Forms.TextBox();
            this.tUrunAra = new System.Windows.Forms.TextBox();
            this.bRaporAl = new System.Windows.Forms.Button();
            this.bUrunGrubuEkle = new System.Windows.Forms.Button();
            this.bIptal = new System.Windows.Forms.Button();
            this.bKadet = new System.Windows.Forms.Button();
            this.tKdvOrani = new System.Windows.Forms.TextBox();
            this.tMiktar = new System.Windows.Forms.TextBox();
            this.tSatisFiyati = new System.Windows.Forms.TextBox();
            this.tAlisFiyati = new System.Windows.Forms.TextBox();
            this.tAciklama = new System.Windows.Forms.TextBox();
            this.tUrunAdi = new System.Windows.Forms.TextBox();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lStandart10 = new market.lStandart();
            this.lStandart9 = new market.lStandart();
            this.lStandart8 = new market.lStandart();
            this.lStandart7 = new market.lStandart();
            this.lStandart6 = new market.lStandart();
            this.lStandart5 = new market.lStandart();
            this.lStandart4 = new market.lStandart();
            this.lStandart3 = new market.lStandart();
            this.lStandart2 = new market.lStandart();
            this.lStandart1 = new market.lStandart();
            this.gridUrunListesi = new market.gridGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chUrunType);
            this.splitContainer1.Panel1.Controls.Add(this.lKullanici);
            this.splitContainer1.Panel1.Controls.Add(this.tBarkod);
            this.splitContainer1.Panel1.Controls.Add(this.bBarkodOlustur);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunSayisi);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart10);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunAra);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart9);
            this.splitContainer1.Panel1.Controls.Add(this.bRaporAl);
            this.splitContainer1.Panel1.Controls.Add(this.bUrunGrubuEkle);
            this.splitContainer1.Panel1.Controls.Add(this.bIptal);
            this.splitContainer1.Panel1.Controls.Add(this.bKadet);
            this.splitContainer1.Panel1.Controls.Add(this.tKdvOrani);
            this.splitContainer1.Panel1.Controls.Add(this.tMiktar);
            this.splitContainer1.Panel1.Controls.Add(this.tSatisFiyati);
            this.splitContainer1.Panel1.Controls.Add(this.tAlisFiyati);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart8);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart7);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart6);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart5);
            this.splitContainer1.Panel1.Controls.Add(this.tAciklama);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunAdi);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart4);
            this.splitContainer1.Panel1.Controls.Add(this.cmbUrunGrubu);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart3);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart2);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridUrunListesi);
            this.splitContainer1.Size = new System.Drawing.Size(1228, 553);
            this.splitContainer1.SplitterDistance = 392;
            this.splitContainer1.TabIndex = 0;
            // 
            // chUrunType
            // 
            this.chUrunType.Appearance = System.Windows.Forms.Appearance.Button;
            this.chUrunType.AutoSize = true;
            this.chUrunType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chUrunType.Checked = true;
            this.chUrunType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chUrunType.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chUrunType.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.chUrunType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chUrunType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chUrunType.Location = new System.Drawing.Point(499, 11);
            this.chUrunType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chUrunType.Name = "chUrunType";
            this.chUrunType.Size = new System.Drawing.Size(201, 30);
            this.chUrunType.TabIndex = 31;
            this.chUrunType.Text = "BARKODLU ÜRÜN İŞLEMİ";
            this.chUrunType.UseVisualStyleBackColor = false;
            this.chUrunType.CheckedChanged += new System.EventHandler(this.chUrunType_CheckedChanged);
            // 
            // lKullanici
            // 
            this.lKullanici.AutoSize = true;
            this.lKullanici.Location = new System.Drawing.Point(1110, 69);
            this.lKullanici.Name = "lKullanici";
            this.lKullanici.Size = new System.Drawing.Size(46, 17);
            this.lKullanici.TabIndex = 30;
            this.lKullanici.Text = "label1";
            this.lKullanici.Visible = false;
            // 
            // tBarkod
            // 
            this.tBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tBarkod.Location = new System.Drawing.Point(138, 69);
            this.tBarkod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBarkod.Name = "tBarkod";
            this.tBarkod.Size = new System.Drawing.Size(323, 30);
            this.tBarkod.TabIndex = 0;
            this.tBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBarkod_KeyDown);
            // 
            // bBarkodOlustur
            // 
            this.bBarkodOlustur.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bBarkodOlustur.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.bBarkodOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBarkodOlustur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bBarkodOlustur.ForeColor = System.Drawing.Color.White;
            this.bBarkodOlustur.Image = global::market.Properties.Resources.barcode_product__1_;
            this.bBarkodOlustur.Location = new System.Drawing.Point(309, 243);
            this.bBarkodOlustur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bBarkodOlustur.Name = "bBarkodOlustur";
            this.bBarkodOlustur.Size = new System.Drawing.Size(152, 97);
            this.bBarkodOlustur.TabIndex = 11;
            this.bBarkodOlustur.Text = "  BARKOD \r\n OLUŞTUR";
            this.bBarkodOlustur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bBarkodOlustur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bBarkodOlustur.UseVisualStyleBackColor = false;
            this.bBarkodOlustur.Click += new System.EventHandler(this.bBarkodOlustur_Click);
            // 
            // tUrunSayisi
            // 
            this.tUrunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tUrunSayisi.Location = new System.Drawing.Point(663, 341);
            this.tUrunSayisi.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tUrunSayisi.Name = "tUrunSayisi";
            this.tUrunSayisi.ReadOnly = true;
            this.tUrunSayisi.Size = new System.Drawing.Size(159, 30);
            this.tUrunSayisi.TabIndex = 27;
            this.tUrunSayisi.TabStop = false;
            this.tUrunSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tUrunAra
            // 
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tUrunAra.Location = new System.Drawing.Point(138, 345);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(323, 30);
            this.tUrunAra.TabIndex = 12;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // bRaporAl
            // 
            this.bRaporAl.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bRaporAl.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.bRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRaporAl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bRaporAl.ForeColor = System.Drawing.Color.White;
            this.bRaporAl.Image = global::market.Properties.Resources.report;
            this.bRaporAl.Location = new System.Drawing.Point(1017, 235);
            this.bRaporAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRaporAl.Name = "bRaporAl";
            this.bRaporAl.Size = new System.Drawing.Size(157, 136);
            this.bRaporAl.TabIndex = 13;
            this.bRaporAl.Text = "RAPOR Al";
            this.bRaporAl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bRaporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bRaporAl.UseVisualStyleBackColor = false;
            // 
            // bUrunGrubuEkle
            // 
            this.bUrunGrubuEkle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bUrunGrubuEkle.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.bUrunGrubuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUrunGrubuEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bUrunGrubuEkle.ForeColor = System.Drawing.Color.White;
            this.bUrunGrubuEkle.Image = global::market.Properties.Resources.plus;
            this.bUrunGrubuEkle.Location = new System.Drawing.Point(138, 243);
            this.bUrunGrubuEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bUrunGrubuEkle.Name = "bUrunGrubuEkle";
            this.bUrunGrubuEkle.Size = new System.Drawing.Size(152, 97);
            this.bUrunGrubuEkle.TabIndex = 10;
            this.bUrunGrubuEkle.Text = "ÜRÜN GRUBU EKLE";
            this.bUrunGrubuEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bUrunGrubuEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bUrunGrubuEkle.UseVisualStyleBackColor = false;
            this.bUrunGrubuEkle.Click += new System.EventHandler(this.bUrunGrubuEkle_Click);
            // 
            // bIptal
            // 
            this.bIptal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bIptal.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.bIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIptal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bIptal.ForeColor = System.Drawing.Color.White;
            this.bIptal.Image = global::market.Properties.Resources.cancel;
            this.bIptal.Location = new System.Drawing.Point(848, 156);
            this.bIptal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bIptal.Name = "bIptal";
            this.bIptal.Size = new System.Drawing.Size(112, 74);
            this.bIptal.TabIndex = 9;
            this.bIptal.Text = " İPTAL";
            this.bIptal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bIptal.UseVisualStyleBackColor = false;
            this.bIptal.Click += new System.EventHandler(this.bIptal_Click);
            // 
            // bKadet
            // 
            this.bKadet.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bKadet.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.bKadet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKadet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bKadet.ForeColor = System.Drawing.Color.White;
            this.bKadet.Image = global::market.Properties.Resources.floppy_disk;
            this.bKadet.Location = new System.Drawing.Point(848, 69);
            this.bKadet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bKadet.Name = "bKadet";
            this.bKadet.Size = new System.Drawing.Size(112, 77);
            this.bKadet.TabIndex = 8;
            this.bKadet.Text = "KAYDET";
            this.bKadet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bKadet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bKadet.UseVisualStyleBackColor = false;
            this.bKadet.Click += new System.EventHandler(this.bKadet_Click);
            // 
            // tKdvOrani
            // 
            this.tKdvOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tKdvOrani.Location = new System.Drawing.Point(663, 203);
            this.tKdvOrani.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tKdvOrani.Name = "tKdvOrani";
            this.tKdvOrani.Size = new System.Drawing.Size(159, 30);
            this.tKdvOrani.TabIndex = 7;
            this.tKdvOrani.Text = "8";
            this.tKdvOrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tMiktar
            // 
            this.tMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tMiktar.Location = new System.Drawing.Point(663, 156);
            this.tMiktar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tMiktar.Name = "tMiktar";
            this.tMiktar.Size = new System.Drawing.Size(159, 30);
            this.tMiktar.TabIndex = 6;
            this.tMiktar.Text = "0";
            this.tMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tSatisFiyati
            // 
            this.tSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tSatisFiyati.Location = new System.Drawing.Point(663, 109);
            this.tSatisFiyati.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tSatisFiyati.Name = "tSatisFiyati";
            this.tSatisFiyati.Size = new System.Drawing.Size(159, 30);
            this.tSatisFiyati.TabIndex = 5;
            this.tSatisFiyati.Text = "0";
            this.tSatisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tSatisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tSatisFiyati_KeyPress);
            // 
            // tAlisFiyati
            // 
            this.tAlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tAlisFiyati.Location = new System.Drawing.Point(663, 70);
            this.tAlisFiyati.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tAlisFiyati.Name = "tAlisFiyati";
            this.tAlisFiyati.Size = new System.Drawing.Size(159, 30);
            this.tAlisFiyati.TabIndex = 4;
            this.tAlisFiyati.Text = "0";
            this.tAlisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tAciklama
            // 
            this.tAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tAciklama.Location = new System.Drawing.Point(138, 158);
            this.tAciklama.Name = "tAciklama";
            this.tAciklama.Size = new System.Drawing.Size(323, 30);
            this.tAciklama.TabIndex = 2;
            // 
            // tUrunAdi
            // 
            this.tUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tUrunAdi.Location = new System.Drawing.Point(138, 111);
            this.tUrunAdi.Name = "tUrunAdi";
            this.tUrunAdi.Size = new System.Drawing.Size(323, 30);
            this.tUrunAdi.TabIndex = 1;
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(138, 205);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(323, 33);
            this.cmbUrunGrubu.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.düzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 52);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // lStandart10
            // 
            this.lStandart10.AutoSize = true;
            this.lStandart10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart10.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart10.Location = new System.Drawing.Point(548, 346);
            this.lStandart10.Name = "lStandart10";
            this.lStandart10.Size = new System.Drawing.Size(112, 25);
            this.lStandart10.TabIndex = 26;
            this.lStandart10.Text = "Ürün Sayısı";
            // 
            // lStandart9
            // 
            this.lStandart9.AutoSize = true;
            this.lStandart9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart9.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart9.Location = new System.Drawing.Point(42, 348);
            this.lStandart9.Name = "lStandart9";
            this.lStandart9.Size = new System.Drawing.Size(90, 25);
            this.lStandart9.TabIndex = 24;
            this.lStandart9.Text = "Ürün Ara";
            // 
            // lStandart8
            // 
            this.lStandart8.AutoSize = true;
            this.lStandart8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart8.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart8.Location = new System.Drawing.Point(560, 205);
            this.lStandart8.Name = "lStandart8";
            this.lStandart8.Size = new System.Drawing.Size(100, 25);
            this.lStandart8.TabIndex = 11;
            this.lStandart8.Text = "Kdv Oranı";
            // 
            // lStandart7
            // 
            this.lStandart7.AutoSize = true;
            this.lStandart7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart7.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart7.Location = new System.Drawing.Point(595, 159);
            this.lStandart7.Name = "lStandart7";
            this.lStandart7.Size = new System.Drawing.Size(65, 25);
            this.lStandart7.TabIndex = 10;
            this.lStandart7.Text = "Miktar";
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart6.Location = new System.Drawing.Point(553, 112);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(107, 25);
            this.lStandart6.TabIndex = 9;
            this.lStandart6.Text = "Satış Fiyatı";
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart5.Location = new System.Drawing.Point(565, 70);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(95, 25);
            this.lStandart5.TabIndex = 8;
            this.lStandart5.Text = "Alış Fiyatı";
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart4.Location = new System.Drawing.Point(24, 208);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(108, 25);
            this.lStandart4.TabIndex = 4;
            this.lStandart4.Text = "ÜrünGrubu";
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart3.Location = new System.Drawing.Point(40, 161);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(92, 25);
            this.lStandart3.TabIndex = 2;
            this.lStandart3.Text = "Açıklama";
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart2.Location = new System.Drawing.Point(44, 114);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(88, 25);
            this.lStandart2.TabIndex = 1;
            this.lStandart2.Text = "Ürün Adı";
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(58, 72);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(74, 25);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "Barkod";
            // 
            // gridUrunListesi
            // 
            this.gridUrunListesi.AllowUserToAddRows = false;
            this.gridUrunListesi.AllowUserToDeleteRows = false;
            this.gridUrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUrunListesi.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridUrunListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUrunListesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridUrunListesi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrunListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUrunListesi.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrunListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrunListesi.EnableHeadersVisualStyles = false;
            this.gridUrunListesi.Location = new System.Drawing.Point(0, 0);
            this.gridUrunListesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridUrunListesi.Name = "gridUrunListesi";
            this.gridUrunListesi.ReadOnly = true;
            this.gridUrunListesi.RowHeadersVisible = false;
            this.gridUrunListesi.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.gridUrunListesi.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUrunListesi.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.gridUrunListesi.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.gridUrunListesi.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.gridUrunListesi.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gridUrunListesi.RowTemplate.Height = 30;
            this.gridUrunListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUrunListesi.Size = new System.Drawing.Size(1228, 157);
            this.gridUrunListesi.TabIndex = 0;
            // 
            // UrunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1228, 553);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UrunGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN GİRİŞİ";
            this.Load += new System.EventHandler(this.UrunGiris_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private lStandart lStandart4;
        private lStandart lStandart3;
        private lStandart lStandart2;
        private lStandart lStandart1;
        private System.Windows.Forms.TextBox tAciklama;
        private System.Windows.Forms.TextBox tUrunAdi;
        private lStandart lStandart8;
        private lStandart lStandart7;
        private lStandart lStandart6;
        private lStandart lStandart5;
        private System.Windows.Forms.TextBox tKdvOrani;
        private System.Windows.Forms.TextBox tMiktar;
        private System.Windows.Forms.TextBox tSatisFiyati;
        private System.Windows.Forms.TextBox tAlisFiyati;
        private System.Windows.Forms.TextBox tUrunAra;
        private lStandart lStandart9;
        private System.Windows.Forms.Button bRaporAl;
        private System.Windows.Forms.Button bUrunGrubuEkle;
        private System.Windows.Forms.Button bIptal;
        private System.Windows.Forms.Button bKadet;
        private System.Windows.Forms.TextBox tUrunSayisi;
        private lStandart lStandart10;
        private gridGrid gridUrunListesi;
        private System.Windows.Forms.Button bBarkodOlustur;
        private System.Windows.Forms.TextBox tBarkod;
        public System.Windows.Forms.Label lKullanici;
        public System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.CheckBox chUrunType;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
    }
}