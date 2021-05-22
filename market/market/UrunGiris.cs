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
    public partial class UrunGiris : Form
    {
        public UrunGiris()
        {
            InitializeComponent();
        }
        MarketSatisEntities db = new MarketSatisEntities();
        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string barkod = tBarkod.Text.Trim();
                if(db.Urun.Any(a=> a.dBarkod == barkod))
                {
                    var urun = db.Urun.Where(a => a.dBarkod == barkod).SingleOrDefault();
                    tUrunAdi.Text = urun.dUrunAd;
                    tAciklama.Text = urun.dAciklama;
                    cmbUrunGrubu.Text = urun.dUrunGrup;
                    tAlisFiyati.Text = urun.dAlisFiyat.ToString();
                    tSatisFiyati.Text = urun.dSatisFiyat.ToString();
                    tMiktar.Text = urun.dMiktar.ToString();
                    tKdvOrani.Text = urun.dKdvOrani.ToString();
                }
                else
                {
                    MessageBox.Show("Ürün Kayıtlı Değil, Kayıt Edilebilir.");
                }
            }
        }

        private void bKadet_Click(object sender, EventArgs e)
        {
            if(tBarkod.Text != "" && tUrunAdi.Text !="" && tAciklama.Text != "" && cmbUrunGrubu.Text != "" && tAlisFiyati.Text != "" && tSatisFiyati.Text!=""&& tKdvOrani.Text!=""&& tMiktar.Text != "")
            {
                if(db.Urun.Any(a=> a.dBarkod == tBarkod.Text))
                {
                    var urunGuncelle = db.Urun.Where(a => a.dBarkod == tBarkod.Text).SingleOrDefault();
                    urunGuncelle.dBarkod = tBarkod.Text;
                    urunGuncelle.dUrunAd = tUrunAdi.Text;
                    urunGuncelle.dAciklama = tAciklama.Text;
                    urunGuncelle.dUrunGrup = cmbUrunGrubu.Text;
                    urunGuncelle.dAlisFiyat = Convert.ToDouble(tAlisFiyati.Text);
                    urunGuncelle.dSatisFiyat = Convert.ToDouble(tSatisFiyati.Text);
                    urunGuncelle.dKdvOrani = Convert.ToInt16(tKdvOrani.Text);
                    urunGuncelle.dKdvTutari = Math.Round(islemler.DoubleYap(tSatisFiyati.Text) * Convert.ToInt32(tKdvOrani.Text) / 100, 2);
                    //urunGuncelle.dMiktar += Convert.ToDouble(tMiktar.Text); DEPO STOK YOK
                    urunGuncelle.dMiktar = Convert.ToDouble(tMiktar.Text);
                    urunGuncelle.dBirim = "Adet";
                    urunGuncelle.dTarih = DateTime.Now;
                    urunGuncelle.dKullanici = lKullanici.Text;
                    db.SaveChanges();
                    Temizle();
                    MessageBox.Show("Ürün Güncellendi...");
                }
                else {
                    Urun urun = new Urun();
                    urun.dBarkod = tBarkod.Text;
                    urun.dUrunAd = tUrunAdi.Text;
                    urun.dAciklama = tAciklama.Text;
                    urun.dUrunGrup = cmbUrunGrubu.Text;
                    urun.dAlisFiyat = Convert.ToDouble(tAlisFiyati.Text);
                    urun.dSatisFiyat = Convert.ToDouble(tSatisFiyati.Text);
                    urun.dKdvOrani = Convert.ToInt16(tKdvOrani.Text);
                    urun.dKdvTutari = Math.Round(islemler.DoubleYap(tSatisFiyati.Text) * Convert.ToInt32(tKdvOrani.Text) / 100, 2);
                    urun.dMiktar = Convert.ToDouble(tMiktar.Text);
                    urun.dBirim = "Adet";
                    urun.dTarih = DateTime.Now;
                    urun.dKullanici = lKullanici.Text;
                    db.Urun.Add(urun);
                    db.SaveChanges();
                    Temizle();                   
                }
                gridUrunListesi.DataSource = db.Urun.OrderByDescending(a => a.dUrunId).Take(10).ToList();//10 tanesini alıyoruz
            }
            else
            {
                MessageBox.Show("Bilgileri Kontrol Edin.");
                tBarkod.Focus();
            }
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text.Length >= 2)
            {
                string urunad = tUrunAra.Text;
                gridUrunListesi.DataSource = db.Urun.Where(a => a.dUrunAd.Contains(urunad)).ToList();//contains - bulunduruyorsa demek
            }
        }
        private void Temizle()
        {
            tBarkod.Clear();
            tUrunAdi.Clear();
            tAciklama.Clear();
            tAlisFiyati.Text = "0";
            tSatisFiyati.Text = "0";
            tMiktar.Text = "0";
            tKdvOrani.Text = "8";
            tBarkod.Focus();
        }

        private void bIptal_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void UrunGiris_Load(object sender, EventArgs e)
        {
            tUrunSayisi.Text = db.Urun.Count().ToString();
        }
    }
}
