using System;
using System.Collections.Generic;
using System.Globalization;
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
    }
}
