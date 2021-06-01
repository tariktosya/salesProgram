
namespace market
{
    partial class fLisans
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
            this.bTamam = new System.Windows.Forms.Button();
            this.lKontrolNo = new market.lStandart();
            this.lStandart1 = new market.lStandart();
            this.tLisansNo = new market.tNumeric();
            this.SuspendLayout();
            // 
            // bTamam
            // 
            this.bTamam.Location = new System.Drawing.Point(52, 117);
            this.bTamam.Name = "bTamam";
            this.bTamam.Size = new System.Drawing.Size(75, 46);
            this.bTamam.TabIndex = 2;
            this.bTamam.Text = "TAMAM";
            this.bTamam.UseVisualStyleBackColor = true;
            this.bTamam.Click += new System.EventHandler(this.bTamam_Click);
            // 
            // lKontrolNo
            // 
            this.lKontrolNo.AutoSize = true;
            this.lKontrolNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lKontrolNo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lKontrolNo.Location = new System.Drawing.Point(47, 46);
            this.lKontrolNo.Name = "lKontrolNo";
            this.lKontrolNo.Size = new System.Drawing.Size(90, 25);
            this.lKontrolNo.TabIndex = 0;
            this.lKontrolNo.Text = "lStandart";
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(31, 21);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(144, 25);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "KONTROL NO";
            // 
            // tLisansNo
            // 
            this.tLisansNo.BackColor = System.Drawing.Color.White;
            this.tLisansNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tLisansNo.Location = new System.Drawing.Point(36, 74);
            this.tLisansNo.Name = "tLisansNo";
            this.tLisansNo.Size = new System.Drawing.Size(115, 30);
            this.tLisansNo.TabIndex = 3;
            this.tLisansNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fLisans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 175);
            this.Controls.Add(this.tLisansNo);
            this.Controls.Add(this.bTamam);
            this.Controls.Add(this.lKontrolNo);
            this.Controls.Add(this.lStandart1);
            this.Name = "fLisans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LİSANS İŞLEMİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lStandart lStandart1;
        private System.Windows.Forms.Button bTamam;
        internal lStandart lKontrolNo;
        private tNumeric tLisansNo;
    }
}