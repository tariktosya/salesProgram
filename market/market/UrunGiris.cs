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
                    if (urun.dBirim =="Kg")
                    {
                        chUrunType.Checked = false;
                    }
                    else
                    {
                        chUrunType.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Ürün Kayıtlı Değil, Kayıt Edilebilir.");
                }
            }
        }

        private void bKadet_Click(object sender, EventArgs e)
        {
            if (tBarkod.Text != "" && tUrunAdi.Text != "" && tAciklama.Text != "" && cmbUrunGrubu.Text != "" && tAlisFiyati.Text != "" && tSatisFiyati.Text != "" && tKdvOrani.Text != "" && tMiktar.Text != "")
            {
                if (db.Urun.Any(a => a.dBarkod == tBarkod.Text))
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
                    urunGuncelle.dMiktar += Convert.ToDouble(tMiktar.Text); //DEPO STOK YOK
                    if (!chUrunType.Checked)
                    {
                        urunGuncelle.dBirim = "Kg";
                    }
                    else
                    {
                        urunGuncelle.dBirim = "Adet";
                    }
                    urunGuncelle.dTarih = DateTime.Now;
                    urunGuncelle.dKullanici = lKullanici.Text;
                    db.SaveChanges();
                    Temizle();
                    MessageBox.Show("Ürün Güncellendi...");
                }
                else
                {
                    Urun urun = new Urun();
                    urun.dBarkod = tBarkod.Text;
                    urun.dUrunAd = tUrunAdi.Text;
                    urun.dAciklama = tAciklama.Text;
                    urun.dUrunGrup = cmbUrunGrubu.Text;
                    urun.dAlisFiyat = islemler.DoubleYap(tAlisFiyati.Text);
                    urun.dSatisFiyat = islemler.DoubleYap(tSatisFiyati.Text);
                    urun.dKdvOrani = islemler.DoubleYap(tKdvOrani.Text);
                    urun.dKdvTutari = Math.Round(islemler.DoubleYap(tSatisFiyati.Text) * islemler.DoubleYap(tKdvOrani.Text) / 100, 2);
                    urun.dMiktar = Convert.ToDouble(tMiktar.Text);
                    if (!chUrunType.Checked)
                    {
                        urun.dBirim = "Kg";
                    }
                    else
                    {
                        urun.dBirim = "Adet";
                    }
                    
                    urun.dTarih = DateTime.Now;
                    urun.dKullanici = lKullanici.Text;
                    db.Urun.Add(urun);
                    db.SaveChanges();
                    if (tBarkod.Text.Length == 8)
                    {
                        var ozelBarkod = db.Barkod.First();
                        ozelBarkod.dBarkodNo += 1;
                        db.SaveChanges();
                    }

                    
                    gridUrunListesi.DataSource = db.Urun.OrderByDescending(a => a.dUrunId).Take(20).ToList();//20 tanesini alıyoruz
                    islemler.GridDuzenle(gridUrunListesi);
                }
                islemler.StokHareket(tBarkod.Text, tUrunAdi.Text, "Adet", Convert.ToDouble(tMiktar.Text), cmbUrunGrubu.Text, lKullanici.Text);
                Temizle();
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
                islemler.GridDuzenle(gridUrunListesi);
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
            gridUrunListesi.DataSource = db.Urun.OrderByDescending(a => a.dUrunId).Take(20).ToList();
            islemler.GridDuzenle(gridUrunListesi);
            GrupDoldur();
        }
        public void GrupDoldur()
        {
            cmbUrunGrubu.DisplayMember = "dUrunGrupAd";
            cmbUrunGrubu.ValueMember = "Id";
            cmbUrunGrubu.DataSource = db.UrunGrubu.OrderBy(a => a.dUrunGrupAd).ToList();
        }

        private void bUrunGrubuEkle_Click(object sender, EventArgs e)
        {
            UrunGrup f = new UrunGrup();
            f.ShowDialog();
        }

        private void bBarkodOlustur_Click(object sender, EventArgs e)
        {
            var barkodno = db.Barkod.First();
            int karakter = barkodno.dBarkodNo.ToString().Length;
            string sifirlar = string.Empty;
            for (int i = 0; i < 8-karakter; i++)
            {
                sifirlar = sifirlar + "0";
            }
            string olusanBarkod = sifirlar + barkodno.dBarkodNo.ToString();
            tBarkod.Text = olusanBarkod;
            tUrunAdi.Focus();
        }

        private void tSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)== false && e.KeyChar!=(char)08 && e.KeyChar !=(char)44 && e.KeyChar !=(char)45)
            {
                e.Handled = true;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridUrunListesi.Rows.Count>0)
            {
                int urunid = Convert.ToInt32(gridUrunListesi.CurrentRow.Cells["dUrunId"].Value.ToString());
                string urunad = gridUrunListesi.CurrentRow.Cells["dUrunAd"].Value.ToString();
                string barkod = gridUrunListesi.CurrentRow.Cells["dBarkod"].Value.ToString();
                DialogResult onay = MessageBox.Show(urunad + " Ürününü Silmek İstiyor Musunuz?", "Ürün Silme İşlemi", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    var urun = db.Urun.Find(urunid);
                    var hizli = db.HizliUrun.Where(x => x.dBarkod == barkod).SingleOrDefault();
                    if (hizli != null){
                        hizli.dBarkod = "-";
                        hizli.dUrunAd = "-";
                        hizli.dFiyat = 0;
                    }
                    
                    db.Urun.Remove(urun);
                    db.SaveChanges();
                    gridUrunListesi.DataSource = db.Urun.OrderByDescending(a => a.dUrunId).Take(20).ToList();//10 tanesini alıyoruz
                    islemler.GridDuzenle(gridUrunListesi);
                    MessageBox.Show("Ürün Silinmiştir.");
                    tBarkod.Focus();
                }
            }
            
        }

        private void chUrunType_CheckedChanged(object sender, EventArgs e)
        {
            if (!chUrunType.Checked)
            {
                chUrunType.Text = "Gramajlı Ürün İşlemi";
                bBarkodOlustur.Enabled = false;
            }
            else
            {
                chUrunType.Text = "Barkodlu Ürün İşlemi";
                bBarkodOlustur.Enabled = true;
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridUrunListesi.Rows.Count>0)
            {
                tBarkod.Text = gridUrunListesi.CurrentRow.Cells["dBarkod"].Value.ToString();
                tUrunAdi.Text = gridUrunListesi.CurrentRow.Cells["dUrunAd"].Value.ToString();
                tAciklama.Text = gridUrunListesi.CurrentRow.Cells["dAciklama"].Value.ToString();
                cmbUrunGrubu.Text = gridUrunListesi.CurrentRow.Cells["dUrunGrup"].Value.ToString();
                tAlisFiyati.Text = gridUrunListesi.CurrentRow.Cells["dAlisFiyat"].Value.ToString();
                tSatisFiyati.Text = gridUrunListesi.CurrentRow.Cells["dSatisFiyat"].Value.ToString();
                tKdvOrani.Text = gridUrunListesi.CurrentRow.Cells["dKdvOrani"].Value.ToString();
                string birim = gridUrunListesi.CurrentRow.Cells["dBirim"].Value.ToString();
                tMiktar.Text = gridUrunListesi.CurrentRow.Cells["dMiktar"].Value.ToString();
                if (birim == "kg")
                {
                    chUrunType.Checked = false;
                }
                else
                {
                    chUrunType.Checked = true;
                }
            }
        }
    }
}
