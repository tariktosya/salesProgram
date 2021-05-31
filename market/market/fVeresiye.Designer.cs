
namespace market
{
    partial class fVeresiye
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bBorcEkle = new System.Windows.Forms.Button();
            this.vBorcSil = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tMiktar = new market.tNumeric();
            this.tTelefon = new market.tStandart();
            this.tAdSoyad = new market.tStandart();
            this.lStandart4 = new market.lStandart();
            this.lStandart3 = new market.lStandart();
            this.lStandart2 = new market.lStandart();
            this.gridListe = new market.gridGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.bBorcEkle);
            this.splitContainer1.Panel1.Controls.Add(this.vBorcSil);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.tMiktar);
            this.splitContainer1.Panel1.Controls.Add(this.tTelefon);
            this.splitContainer1.Panel1.Controls.Add(this.tAdSoyad);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart4);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart3);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridListe);
            this.splitContainer1.Size = new System.Drawing.Size(1107, 660);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 0;
            // 
            // bBorcEkle
            // 
            this.bBorcEkle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bBorcEkle.Location = new System.Drawing.Point(765, 116);
            this.bBorcEkle.Name = "bBorcEkle";
            this.bBorcEkle.Size = new System.Drawing.Size(115, 71);
            this.bBorcEkle.TabIndex = 14;
            this.bBorcEkle.Text = "EKLE";
            this.bBorcEkle.UseVisualStyleBackColor = false;
            this.bBorcEkle.Click += new System.EventHandler(this.bBorcEkle_Click);
            // 
            // vBorcSil
            // 
            this.vBorcSil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.vBorcSil.Location = new System.Drawing.Point(903, 116);
            this.vBorcSil.Name = "vBorcSil";
            this.vBorcSil.Size = new System.Drawing.Size(115, 71);
            this.vBorcSil.TabIndex = 14;
            this.vBorcSil.Text = "SİL";
            this.vBorcSil.UseVisualStyleBackColor = false;
            this.vBorcSil.Click += new System.EventHandler(this.vBorcSil_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(160, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 71);
            this.button2.TabIndex = 14;
            this.button2.Text = "YENİ MÜŞTERİ EKLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // tMiktar
            // 
            this.tMiktar.BackColor = System.Drawing.Color.White;
            this.tMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tMiktar.Location = new System.Drawing.Point(903, 57);
            this.tMiktar.Name = "tMiktar";
            this.tMiktar.Size = new System.Drawing.Size(115, 30);
            this.tMiktar.TabIndex = 13;
            this.tMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tTelefon
            // 
            this.tTelefon.BackColor = System.Drawing.Color.White;
            this.tTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tTelefon.Location = new System.Drawing.Point(522, 57);
            this.tTelefon.Name = "tTelefon";
            this.tTelefon.Size = new System.Drawing.Size(250, 30);
            this.tTelefon.TabIndex = 12;
            // 
            // tAdSoyad
            // 
            this.tAdSoyad.BackColor = System.Drawing.Color.White;
            this.tAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tAdSoyad.Location = new System.Drawing.Point(133, 57);
            this.tAdSoyad.Name = "tAdSoyad";
            this.tAdSoyad.Size = new System.Drawing.Size(250, 30);
            this.tAdSoyad.TabIndex = 11;
            this.tAdSoyad.TextChanged += new System.EventHandler(this.tAdSoyad_TextChanged);
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart4.Location = new System.Drawing.Point(832, 60);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(65, 25);
            this.lStandart4.TabIndex = 10;
            this.lStandart4.Text = "Miktar";
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart3.Location = new System.Drawing.Point(438, 60);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(78, 25);
            this.lStandart3.TabIndex = 9;
            this.lStandart3.Text = "Telefon";
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart2.Location = new System.Drawing.Point(28, 60);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(99, 25);
            this.lStandart2.TabIndex = 8;
            this.lStandart2.Text = "Ad Soyad";
            // 
            // gridListe
            // 
            this.gridListe.AllowUserToAddRows = false;
            this.gridListe.AllowUserToDeleteRows = false;
            this.gridListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListe.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListe.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListe.EnableHeadersVisualStyles = false;
            this.gridListe.Location = new System.Drawing.Point(0, 0);
            this.gridListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridListe.Name = "gridListe";
            this.gridListe.ReadOnly = true;
            this.gridListe.RowHeadersVisible = false;
            this.gridListe.RowHeadersWidth = 51;
            this.gridListe.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.gridListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.gridListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gridListe.RowTemplate.Height = 30;
            this.gridListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListe.Size = new System.Drawing.Size(1107, 452);
            this.gridListe.TabIndex = 2;
            this.gridListe.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListe_CellContentDoubleClick);
            // 
            // fVeresiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 660);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fVeresiye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VERESİYE DEFTERİ";
            this.Load += new System.EventHandler(this.fVeresiye_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private tNumeric tMiktar;
        private tStandart tTelefon;
        private tStandart tAdSoyad;
        private lStandart lStandart4;
        private lStandart lStandart3;
        private lStandart lStandart2;
        private gridGrid gridListe;
        private System.Windows.Forms.Button vBorcSil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bBorcEkle;
    }
}