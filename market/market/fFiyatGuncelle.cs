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
    public partial class fFiyatGuncelle : Form
    {
        public fFiyatGuncelle()
        {
            InitializeComponent();
        }

        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var db=new MarketSatisEntities())
                {
                    if (db.Urun.Any(x=> x.dBarkod == tBarkod.Text.Trim()))
                    {
                        var getir = db.Urun.Where(x => x.dBarkod == tBarkod.Text).SingleOrDefault();
                        lBarkod.Text = getir.dBarkod;
                        lUrunAdi.Text = getir.dUrunAd;
                        double mevcut = Convert.ToDouble(getir.dSatisFiyat);
                        double alis = Convert.ToDouble(getir.dAlisFiyat);
                        lFiyat.Text = mevcut.ToString("C2");
                        lAlisFiyat.Text = alis.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Ürün Kayıtlı Değil.");
                    }
                }
            }
        }

        private void bGelirEkle_Click(object sender, EventArgs e)
        {
            if (tYeniFiyat.Text !="" && lBarkod.Text !="")
            {
                using (var db = new MarketSatisEntities())
                {
                    var guncelle = db.Urun.Where(x => x.dBarkod == lBarkod.Text).SingleOrDefault();
                    guncelle.dSatisFiyat = islemler.DoubleYap(tYeniFiyat.Text);
                    int kdvorani = Convert.ToInt32(guncelle.dKdvOrani);
                    Math.Round(islemler.DoubleYap(tYeniFiyat.Text) * kdvorani / 100, 2);
                    db.SaveChanges();
                    MessageBox.Show("Satış Fiyatı Güncellenmiştir.");
                    lBarkod.Text = "";
                    lUrunAdi.Text = "";
                    lFiyat.Text = "";
                    tBarkod.Clear();
                    tYeniFiyat.Clear();
                    lAlisFiyat.Text = "";
                    tBarkod.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ürün Okutunuz");
            }
        }

        private void bAlisFiyat_Click(object sender, EventArgs e)
        {
            if (tAlisFiyat.Text != "" && lBarkod.Text != "")
            {
                using (var db = new MarketSatisEntities())
                {
                    var guncelle = db.Urun.Where(x => x.dBarkod == lBarkod.Text).SingleOrDefault();
                    guncelle.dAlisFiyat = islemler.DoubleYap(tAlisFiyat.Text);
                    db.SaveChanges();
                    MessageBox.Show("Alış Fiyatı Güncellenmiştir.");
                    lBarkod.Text = "";
                    lUrunAdi.Text = "";
                    lFiyat.Text = "";
                    tBarkod.Clear();
                    tYeniFiyat.Clear();
                    tAlisFiyat.Text = "";
                    tBarkod.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ürün Okutunuz");
            }
        }
    }
}
