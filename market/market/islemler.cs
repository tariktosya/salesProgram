using Lisans;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    class islemler
    {
        public static double DoubleYap(String deger)
        {
            double degers;
            double.TryParse(deger, NumberStyles.Currency, CultureInfo.CurrentUICulture.NumberFormat, out degers);
            return Math.Round(degers, 2);
        }

        public static void StokAzalt(string barkod, double miktar)
        {
            using (var db = new MarketSatisEntities())
            {
                var urunbilgi = db.Urun.SingleOrDefault(x => x.dBarkod == barkod);//Yalnızca o satırı al
                urunbilgi.dMiktar -= miktar;
                db.SaveChanges();

            }
        }
        public static void StokArtir(string barkod, double miktar)
        {
            using (var db = new MarketSatisEntities())
            {
                var urunbilgi = db.Urun.SingleOrDefault(x => x.dBarkod == barkod);//Yalnızca o satırı al
                urunbilgi.dMiktar += miktar;
                db.SaveChanges();

            }
        }
        public static void GridDuzenle(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    switch (dgv.Columns[i].HeaderText)
                    {
                        case "dAdSoyad":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Ad Soyad"; break;
                        case "dTelefon":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Telefon"; break;
                        case "dEposta":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "E-Posta"; break;
                        case "dKullaniciAd":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Kullanıcı Adı"; break;
                        case "dIade":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "İade"; break;
                        case "dIslemNo":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "İşlem No"; break;
                        case "dTarih":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Tarih"; break;

                        case "dKdvTutari":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            dgv.Columns[i].HeaderText = "Kdv Tutarı"; break;
                        case "dBarkod":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Barkod"; break;
                        case "dKullanici":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Kullanıcı"; break;
                        case "Id":
                            dgv.Columns[i].HeaderText = "Numara";
                            break;
                        case "dUrunId":
                            dgv.Columns[i].HeaderText = "Urun Numarası"; break;
                        case "dUrunAd":
                            dgv.Columns[i].HeaderText = "Ürün Adı"; break;
                        case "dAciklama":
                            dgv.Columns[i].HeaderText = "Açıklama"; break;
                        case "dUrunGrup":
                            dgv.Columns[i].HeaderText = "Ürün Grubu"; break;
                        case "dAlisFiyat":
                            dgv.Columns[i].HeaderText = "Alış Fiyatı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "dSatisFiyat":
                            dgv.Columns[i].HeaderText = "Satış Fiyatı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "dKdvOrani":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "KDV Oranı"; break;
                        case "dBirim":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Birim"; break;
                        case "dMiktar":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Miktar"; break;
                        case "dOdemeSekli":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Ödeme Şekli"; break;
                        case "dKart":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            dgv.Columns[i].HeaderText = "Kart"; break;
                        case "dNakit":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            dgv.Columns[i].HeaderText = "Nakit"; break;
                        case "dGelir":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            dgv.Columns[i].HeaderText = "Gelir"; break;
                        case "dGider":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            dgv.Columns[i].HeaderText = "Gider"; break;
                        case "dAlisFiyatToplam":
                            dgv.Columns[i].HeaderText = "Alış Fiyat Toplam";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "dToplam":
                            dgv.Columns[i].HeaderText = "Toplam";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;

                    }
                }
            }
        }

        public static void StokHareket(string barkod, string urunad, string birim, double miktar, string urungrup, string kullanici)
        {
            using (var db = new MarketSatisEntities())
            {
                StokHareket s = new StokHareket();
                s.dBarkod = barkod;
                s.dBirim = birim;
                s.dKullanici = kullanici;
                s.dMiktar = miktar;
                s.dTarih = DateTime.Now;
                s.dUrunAd = urunad;
                s.dUrunGrup = urungrup;
                db.StokHareket.Add(s);
                db.SaveChanges();
            }
        }
        public static int KartKomisyon() {
            int sonuc = 0;
            using (var db = new MarketSatisEntities())
            {
                if (db.Sabitlerim.Any())
                {
                    sonuc =Convert.ToInt32(db.Sabitlerim.First().dKartKomisyonum);
                }
                else
                {
                    sonuc = 0;
                }
            }
            return sonuc;
        }

        public static void SabitVarsayilan()
        {
            using (var db = new MarketSatisEntities())
            {
                if (!db.Sabitlerim.Any())
                {
                    Sabitlerim s = new Sabitlerim();
                    s.dKartKomisyonum = 0;
                    s.dYazici = false;
                    s.dAdres = "admin";
                    s.dUnvan = "admin";
                    s.dAdres = "admin";
                    s.dTelefon = "admin";
                    s.dEposta = "admin";
                    db.Sabitlerim.Add(s);
                    db.SaveChanges();
                }
            }
        }
        public static void BackUp()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Veri yedek dosyası|0.bak";
            save.FileName = "Barkodlu_Satis_Programi_" + DateTime.Now.ToShortDateString();
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (File.Exists(save.FileName))
                    {
                        File.Delete(save.FileName);
                    }
                    var dbHedef = save.FileName;
                    string dbKaynak = Application.StartupPath + @"\MarketSatis.mdf";
                    using (var db=new MarketSatisEntities())
                    {
                        var cmd = @"BACKUP DATABASE[" + dbKaynak + "] TO DISK='" + dbHedef + "'";
                        db.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, cmd);
                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Yedekleme Tamamlanmıştır.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
    public class Kontol
    {
        MarketSatisEntities db = new MarketSatisEntities();
        Depom depom = new Depom();
        Lic lic = new Lic();
        public bool KontrolYap()
        {
            bool durum = false;
            if (db.Depom.Count() == 0)
            {
                LisansFormuAc();
            }
            else
            {
                Lic lic = new Lic();
                var guvenlik = db.Depom.First();
                if (lic.TarihCoz(guvenlik.baslangic)< DateTime.Now)
                {
                    guvenlik.baslangic = lic.TarihSifrele(DateTime.Now);
                    db.SaveChanges();
                    durum = true;
                }
                if (lic.TarihKontrol(lic.TarihCoz(guvenlik.baslangic), lic.TarihCoz(guvenlik.bitis)))
                {
                    durum = true;
                }
                else
                {
                    durum = false;
                    LisansFormuAc();
                }
            }
            return durum;
        }
        public void LisansFormuAc()
        {
            fLisans f = new fLisans();
            Lic lic = new Lic();
            f.lKontrolNo.Text = lic.EkrandaGoster().ToString();
            f.Show();
        }
        public void Lisansla(string kod) {
            int durum = lic.GirilenLisansiKontrolEt(kod);
            if (durum == 0)
            {
                MessageBox.Show("Geçersiz Lisans Kodu");
            }
            else if (durum == 1)
            {
                DemoOlustur();
            }
            else if (durum == 2)
            {
                YillikOlustur();
            }
        }

        public int GuvenlikEkliMi()
        {
            return db.Depom.Count();
        }
        public void guvenlikEkle(string baslangic, string bitis)
        {
            depom.baslangic = baslangic;
            depom.bitis = bitis;
            db.Depom.Add(depom);
            db.SaveChanges();
        }
        public void guvenlikGuncelle(string baslangic, string bitis)
        {
            var depomguncelle = db.Depom.First();
            depomguncelle.baslangic = baslangic;
            depomguncelle.bitis = bitis;
            db.SaveChanges();
        }
        private void DemoOlustur()
        {
            try
            {
                if (GuvenlikEkliMi() == 0)
                {
                    guvenlikEkle(lic.TarihSifrele(DateTime.Now), lic.TarihSifrele(lic.demoTarihiOlustur(10)));
                }
                else
                {
                    guvenlikGuncelle(lic.TarihSifrele(DateTime.Now), lic.TarihSifrele(lic.demoTarihiOlustur(10)));
                }
                MessageBox.Show("Programınız 10 günlük kullanıma açılmıştır. \n Programı tekrar çalıştırınız....");
                Application.Exit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        public void YillikOlustur()
        {
            try
            {
                if (GuvenlikEkliMi() == 0)
                {
                    guvenlikEkle(lic.TarihSifrele(DateTime.Now), lic.TarihSifrele(lic.YillikTarihOlustur()));
                }
                else
                {
                    guvenlikGuncelle(lic.TarihSifrele(DateTime.Now), lic.TarihSifrele(lic.YillikTarihOlustur()));
                }
                MessageBox.Show("Programınız 1 yıllık kullanıma açılmıştır. \n Programı tekrar çalıştırınız....");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
