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
    public partial class hizliButonaEkleme : Form
    {
        public hizliButonaEkleme()
        {
            InitializeComponent();
        }
        MarketSatisEntities db = new MarketSatisEntities();
        private void urunAraText_TextChanged(object sender, EventArgs e)
        {
            if(urunAraText.Text != "")
            {
                string urunad = urunAraText.Text;
                var urunler = db.Urun.Where(a => a.dUrunAd.Contains(urunad)).ToList();//örneğin DO yazdın. İçinde do karakterleri olan ürünleri listeler
                gridUrunler.DataSource = urunler;
                islemler.GridDuzenle(gridUrunler);
            }
        }

        private void gridUrunler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridUrunler.Rows.Count > 0)
            {
                string barkod = gridUrunler.CurrentRow.Cells["dBarkod"].Value.ToString();
                string urunad = gridUrunler.CurrentRow.Cells["dUrunAd"].Value.ToString();
                double fiyat =Convert.ToDouble(gridUrunler.CurrentRow.Cells["dSatisFiyat"].Value.ToString());
                int id = Convert.ToInt16(butonId.Text);
                var guncellenen = db.HizliUrun.Find(id);
                guncellenen.dBarkod = barkod;
                guncellenen.dUrunAd = urunad;
                guncellenen.dFiyat = fiyat;
                db.SaveChanges();
                MessageBox.Show("Buton Güncellendi");
                satis f = (satis)Application.OpenForms["satis"];
                if(f !=null)
                {
                    Button b = f.Controls.Find("bh" + id, true).FirstOrDefault() as Button;
                    b.Text = urunad + "\n" + fiyat.ToString("C2");
                }
            }
        }

        private void chcTumu_CheckedChanged(object sender, EventArgs e)
        {
            if (chcTumu.Checked) 
            {
                gridUrunler.DataSource = db.Urun.ToList();
                gridUrunler.Columns["dAlisFiyat"].Visible = false;
                gridUrunler.Columns["dSatisFiyat"].Visible = false;
                gridUrunler.Columns["dKdvOrani"].Visible = false;
                gridUrunler.Columns["dKdvTutari"].Visible = false;
                gridUrunler.Columns["dMiktar"].Visible = false;
                islemler.GridDuzenle(gridUrunler);
            }
            else
            {
                gridUrunler.DataSource = null;
            }
        }

       
    }
}
