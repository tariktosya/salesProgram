using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class NakitKart : Form
    {
        public NakitKart()
        {
            InitializeComponent();
        }

        private void tNakit_KeyDown(object sender, KeyEventArgs e)
        {
            if (tNakit.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Hesap();
                }
            }
        }

        private void Hesap()
        {
            satis f = (satis)Application.OpenForms["satis"];
            double nakit = islemler.DoubleYap(tNakit.Text);
            double kart = islemler.DoubleYap(f.genelToplam.Text) - nakit;
            f.lNakit.Text = nakit.ToString("C2");
            f.lKart.Text = kart.ToString("C2");
            f.SatisYapilsin("Nakit-Kart");
            this.Hide();
        }
        private void bNx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                int vrgl = tNakit.Text.Count(x => x == ',');
                if (vrgl < 1)
                {
                    tNakit.Text += b.Text;
                }
            }
            else if (b.Text == "<")
            {
                if (tNakit.Text.Length > 0)
                {
                    tNakit.Text = tNakit.Text.Substring(0, tNakit.Text.Length - 1);
                }
            }
            else
            {
                tNakit.Text += b.Text;
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (tNakit.Text != "")
            {
                
                    Hesap();
                
            }
        }

        private void tNakit_KeyPress(object sender, KeyPressEventArgs e)//yalnızca rakam yazabiliriz içerisine
        {
            if (char.IsDigit(e.KeyChar)==false && e.KeyChar !=(char)08)//ve sağ tarafı = klavyeden backSpace ile silme işlemi
            {
                e.Handled = true;
            }
        }
    }
}
