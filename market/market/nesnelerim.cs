using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    class nesnelerim
    {
    }
    class lStandart : Label
    {
        public lStandart()
        {
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Text = "lStandart";
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point);
            this.Name = "lStandart";
        }
        
    }
    class bStandart : Button
    {
        public bStandart() {
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Image = global::market.Properties.Resources.wallet;
            this.Location = new System.Drawing.Point(329, 2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "bnakitkart";
            this.Size = new System.Drawing.Size(157, 159);
            this.TabIndex = 4;
            this.Text = "NAKİT-KART\r\n(F3)";
            this.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UseVisualStyleBackColor = false;
          
        }
    }
    class tStandart :TextBox
    {
        public tStandart()
        {
            this.Size = new System.Drawing.Size(250, 26);
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        }
    }
    class tNumeric : TextBox
    {
        public tNumeric()
        {
            this.Size = new System.Drawing.Size(115, 26);
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Microsıft Sans Serif", 12F);
            this.Name = "tNumeric";
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Click += tNumeric_Click;
            this.KeyPress += TNumeric_KeyPress;
        }

        private void TNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)==false && e.KeyChar !=(char)08)
            {
                e.Handled = true;
            }
        }

        private void tNumeric_Click(object sender, EventArgs e)
        {
            this.SelectAll();
        }
    }
    class gridGrid :DataGridView
    {
        public gridGrid()
        {
            this.AllowUserToAddRows = false;
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnHeadersDefaultCellStyle = this.DefaultCellStyle;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnableHeadersVisualStyles = false;
            this.Location = new System.Drawing.Point(3, 82);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "gridSatisListesi";
            this.RowHeadersVisible = false;
            this.RowHeadersWidth = 51;
            this.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RowTemplate.Height = 30;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Size = new System.Drawing.Size(818, 496);
        }
    }
}
