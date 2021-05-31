using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class fAyarlar : Form
    {
        public fAyarlar()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            tAdSoyad.Clear();
            tTelefon.Clear();
            tEposta.Clear();
            tKullaniciAdi.Clear();
            tSifre.Clear();
            tSifreTekrar.Clear();
            chSatisEkrani.Checked = false;
            chRaporEkrani.Checked = false;
            chStok.Checked = false;
            chUrunGiris.Checked = false;
            chAyarlar.Checked = false;
            chFiyatGuncelle.Checked = false;
            chYedekleme.Checked = false;
        }
        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (bKaydet.Text == "KAYDET")
            {
                if (tAdSoyad.Text != "" && tKullaniciAdi.Text != "" && tSifre.Text != "" && tSifreTekrar.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        try
                        {
                            using (var db = new MarketSatisEntities())
                            {
                                if (!db.Kullanici.Any(x => x.dKullaniciAd == tKullaniciAdi.Text))
                                {
                                    Kullanici k = new Kullanici();
                                    k.dAdSoyad = tAdSoyad.Text;
                                    k.dTelefon = tTelefon.Text;
                                    k.dEposta = tEposta.Text;
                                    k.dKullaniciAd = tKullaniciAdi.Text.Trim();
                                    k.dSifre = tSifre.Text;
                                    //Yetkiler
                                    k.dSatis = chSatisEkrani.Checked;
                                    k.dRapor = chStok.Checked;
                                    k.dStok = chStok.Checked;
                                    k.dUrunGiris = chUrunGiris.Checked;
                                    k.dAyarlar = chAyarlar.Checked;
                                    k.dFiyatGuncelle = chFiyatGuncelle.Checked;
                                    k.dYedekleme = chYedekleme.Checked;
                                    db.Kullanici.Add(k);
                                    db.SaveChanges();
                                    gridListeKullanici.DataSource = db.Kullanici.Select(x => new {x.Id, x.dAdSoyad, x.dKullaniciAd, x.dTelefon, x.dEposta }).ToList();
                                    islemler.GridDuzenle(gridListeKullanici);
                                    Temizle();
                                }
                                else
                                {
                                    MessageBox.Show("Kullanıcı Zaten Kayıtlı.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Zorunlu Alanları Doldurunuz" + "\nAd Soyad\nKullanıcı Adı\nŞifre\nŞifre Tekrar");
                }
            }
            else if (bKaydet.Text == "DÜZENLE")
            {
                if (tAdSoyad.Text != "" && tKullaniciAdi.Text != "" && tSifre.Text != "" && tSifreTekrar.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        int id = Convert.ToInt16(lId.Text);
                        using (var db = new MarketSatisEntities())
                        {
                            var k = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                            k.dAdSoyad = tAdSoyad.Text;
                            k.dTelefon = tTelefon.Text;
                            k.dEposta = tEposta.Text;
                            k.dKullaniciAd = tKullaniciAdi.Text.Trim();
                            k.dSifre = tSifre.Text;
                            //Yetkiler
                            k.dSatis = chSatisEkrani.Checked;
                            k.dRapor = chStok.Checked;
                            k.dStok = chStok.Checked;
                            k.dUrunGiris = chUrunGiris.Checked;
                            k.dAyarlar = chAyarlar.Checked;
                            k.dFiyatGuncelle = chFiyatGuncelle.Checked;
                            k.dYedekleme = chYedekleme.Checked;
                            db.SaveChanges();
                            MessageBox.Show("Güncelleme Tamamlandı.");
                            Temizle();
                            bKaydet.Text = "KAYDET";
                            gridListeKullanici.DataSource = db.Kullanici.Select(x => new { x.Id, x.dAdSoyad, x.dKullaniciAd, x.dTelefon, x.dEposta }).ToList();
                            islemler.GridDuzenle(gridListeKullanici);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Zorunlu Alanları Doldurunuz" + "\nAd Soyad\nKullanıcı Adı\nŞifre\nŞifre Tekrar");
                }
            }
        }

        private void fAyarlar_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var db = new MarketSatisEntities();
            islemler.SabitVarsayilan();
            var yazici = db.Sabitlerim.FirstOrDefault();
            chYazmaDurumu.Checked = Convert.ToBoolean(yazici.dYazici);
            gridListeKullanici.DataSource = db.Kullanici.Select(x => new {x.Id, x.dAdSoyad, x.dKullaniciAd, x.dTelefon, x.dEposta }).ToList();
            islemler.GridDuzenle(gridListeKullanici);
            var sabitler = db.Sabitlerim.FirstOrDefault();
            tKartKomisyon.Text = sabitler.dKartKomisyonum.ToString();
            var terazionek = db.Terazi.ToList();
            cmbTeraziOnek.DisplayMember = "TeraziOnEk";
            cmbTeraziOnek.ValueMember = "Id";
            cmbTeraziOnek.DataSource = terazionek;
            Cursor.Current = Cursors.Default;

            //işyeri doldur
            tIsyeriAdSoyad.Text = sabitler.dAdSoyad;
            tIsyeriUnvan.Text = sabitler.dUnvan;
            tIsyeriTelefon.Text = sabitler.dTelefon;
            tIsyeriEposta.Text = sabitler.dEposta;
            tIsyeriAdres.Text = sabitler.dAdres;
        }

        private void bIptal_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridListeKullanici.Rows.Count>0)
            {
                int id = Convert.ToInt32(gridListeKullanici.CurrentRow.Cells["Id"].Value.ToString());
                lId.Text = id.ToString();
                using(var db = new MarketSatisEntities())
                {
                    var getir = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                    tAdSoyad.Text = getir.dAdSoyad;
                    tTelefon.Text = getir.dTelefon;
                    tEposta.Text = getir.dEposta;
                    tKullaniciAdi.Text = getir.dKullaniciAd;
                    tSifre.Text = getir.dSifre;
                    tSifreTekrar.Text = getir.dSifre;
                    chSatisEkrani.Checked = (bool)getir.dSatis;
                    chRaporEkrani.Checked = (bool)getir.dRapor;
                    chStok.Checked = (bool)getir.dStok;
                    chUrunGiris.Checked = (bool)getir.dUrunGiris;
                    chAyarlar.Checked = (bool)getir.dAyarlar;
                    chFiyatGuncelle.Checked = (bool)getir.dAyarlar;
                    chYedekleme.Checked = (bool)getir.dYedekleme;
                    bKaydet.Text = "DÜZENLE";
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Seçiniz.");
            }
        }

        private void chYazmaDurumu_CheckedChanged(object sender, EventArgs e)
        {
            using (var db = new MarketSatisEntities())
            {
                if (chYazmaDurumu.Checked)
                {
                    islemler.SabitVarsayilan();
                    var ayarla = db.Sabitlerim.FirstOrDefault();
                    ayarla.dYazici = true;
                    db.SaveChanges();
                    chYazmaDurumu.Text = "Yazma Durumu AKTİF";
                }
                else
                {
                    islemler.SabitVarsayilan();
                    var ayarla = db.Sabitlerim.FirstOrDefault();
                    ayarla.dYazici = false;
                    db.SaveChanges();
                    chYazmaDurumu.Text = "Yazma Durumu PASİF";
                }
            }
        }

        private void bKartKomisyon_Click(object sender, EventArgs e)
        {
            if (tKartKomisyon.Text != "")
            {
                using(var db = new MarketSatisEntities())
                {
                    var sabit = db.Sabitlerim.FirstOrDefault();
                    sabit.dKartKomisyonum = Convert.ToInt16(tKartKomisyon.Text);
                    db.SaveChanges();
                    MessageBox.Show("Kart Komisyon Ayarlandı");
                }
            }
            else
            {
                MessageBox.Show("Kart Komisyon Bilgisi Girin.");
            }
        }

        private void bTeraziOnekKaydet_Click(object sender, EventArgs e)
        {
            if (tTeraziOnek.Text != "")
            {
                int onek = Convert.ToInt32(tTeraziOnek.Text);
                using (var db = new MarketSatisEntities())
                {
                    if (db.Terazi.Any(x=> x.TeraziOnEk == onek))
                    {
                        MessageBox.Show("Eklemek istedğiniz önek zaten kayıtlı!");
                    }
                    else
                    {
                        Terazi t = new Terazi();
                        t.TeraziOnEk = onek;
                        db.Terazi.Add(t);
                        db.SaveChanges();
                        MessageBox.Show("Önek Bilgileri Kaydedildi.");
                        cmbTeraziOnek.DisplayMember = "TeraziOnEk";
                        cmbTeraziOnek.ValueMember = "Id";
                        cmbTeraziOnek.DataSource = db.Terazi.ToList();
                        tTeraziOnek.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Bilgileri Giriniz.");
            }
        }

        private void bTeraziOnekSil_Click(object sender, EventArgs e)
        {
            if (cmbTeraziOnek.Text !="")
            {
                int onekid =Convert.ToInt16(cmbTeraziOnek.SelectedValue);
                DialogResult onay = MessageBox.Show(cmbTeraziOnek.Text + " önekini silmek istiyor musunuz?", "Terazi Önek Silme İşlemi", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    using (var db = new MarketSatisEntities())
                    {
                        var terazionek = db.Terazi.Find(onekid);
                        db.Terazi.Remove(terazionek);
                        db.SaveChanges();
                        cmbTeraziOnek.DisplayMember = "TeraziOnEk";
                        cmbTeraziOnek.ValueMember = "Id";
                        cmbTeraziOnek.DataSource = db.Terazi.ToList();
                        MessageBox.Show("Önek Kaldırıldı.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Önek Seçiniz.");
            }
        }

        private void bIsyeriKaydet_Click(object sender, EventArgs e)
        {
            if (tIsyeriAdSoyad.Text != "" && tIsyeriUnvan.Text !="" && tIsyeriAdres.Text != "" && tIsyeriTelefon.Text !="")
            {
                using (var db = new MarketSatisEntities())
                {
                    var isyeri = db.Sabitlerim.FirstOrDefault();
                    isyeri.dAdSoyad = tIsyeriAdSoyad.Text;
                    isyeri.dUnvan = tIsyeriUnvan.Text;
                    isyeri.dAdres = tIsyeriAdres.Text;
                    isyeri.dTelefon = tIsyeriTelefon.Text;
                    isyeri.dEposta = tIsyeriEposta.Text;
                    db.SaveChanges();
                    MessageBox.Show("İşyeri Bilgileri Kaydedilmiştir.");
                    var yeni = db.Sabitlerim.FirstOrDefault();
                    tIsyeriAdSoyad.Text = yeni.dAdSoyad;
                    tIsyeriUnvan.Text = yeni.dUnvan;
                    tIsyeriTelefon.Text = yeni.dTelefon;
                    tIsyeriEposta.Text = yeni.dEposta;
                    tIsyeriAdres.Text = yeni.dAdres;
                }
            }
        }

        private void bYedektenYukle_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\ProgramRestore.exe");
            Application.Exit();
        }
    }
}
