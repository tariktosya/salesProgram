
namespace market
{
    partial class UrunGrup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunGrup));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tUrunGrupAd = new market.tStandart();
            this.lStandart1 = new market.lStandart();
            this.bSil = new market.bStandart();
            this.bStandart1 = new market.bStandart();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(17, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(398, 329);
            this.listBox1.TabIndex = 2;
            // 
            // tUrunGrupAd
            // 
            this.tUrunGrupAd.BackColor = System.Drawing.Color.White;
            this.tUrunGrupAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunGrupAd.Location = new System.Drawing.Point(165, 22);
            this.tUrunGrupAd.Name = "tUrunGrupAd";
            this.tUrunGrupAd.Size = new System.Drawing.Size(250, 30);
            this.tUrunGrupAd.TabIndex = 1;
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(12, 25);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(147, 25);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "Ürün Grubu Adı";
            // 
            // bSil
            // 
            this.bSil.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bSil.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.bSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bSil.ForeColor = System.Drawing.Color.White;
            this.bSil.Image = global::market.Properties.Resources.trash;
            this.bSil.Location = new System.Drawing.Point(19, 392);
            this.bSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(140, 109);
            this.bSil.TabIndex = 5;
            this.bSil.Text = " SİL";
            this.bSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bSil.UseVisualStyleBackColor = false;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // bStandart1
            // 
            this.bStandart1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bStandart1.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.bStandart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStandart1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bStandart1.ForeColor = System.Drawing.Color.White;
            this.bStandart1.Image = global::market.Properties.Resources.plus;
            this.bStandart1.Location = new System.Drawing.Point(275, 392);
            this.bStandart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bStandart1.Name = "bStandart1";
            this.bStandart1.Size = new System.Drawing.Size(140, 109);
            this.bStandart1.TabIndex = 4;
            this.bStandart1.Text = "EKLE";
            this.bStandart1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bStandart1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bStandart1.UseVisualStyleBackColor = false;
            this.bStandart1.Click += new System.EventHandler(this.bStandart1_Click);
            // 
            // UrunGrup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 530);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bStandart1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tUrunGrupAd);
            this.Controls.Add(this.lStandart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UrunGrup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunGrup";
            this.Load += new System.EventHandler(this.UrunGrup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lStandart lStandart1;
        private tStandart tUrunGrupAd;
        private System.Windows.Forms.ListBox listBox1;
        private bStandart bStandart1;
        private bStandart bSil;
    }
}