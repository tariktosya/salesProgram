using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lisans;

namespace market
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        private void girisYap()
        {
            if (tKullanici.Text != "" && tSifre.Text != "")
            {
                try
                {
                    using (var db = new MarketSatisEntities())
                    {
                        if (db.Kullanici.Any())
                        {
                            var bak = db.Kullanici.Where(x => x.dKullaniciAd == tKullanici.Text && x.dSifre == tSifre.Text).FirstOrDefault();
                            if (bak != null)
                            {
                                Cursor.Current = Cursors.WaitCursor;
                                Kontol kontrol = new Kontol();
                                if (kontrol.KontrolYap())
                                {
                                    fBaslangic f = new fBaslangic();
                                    f.bSatisIslemi.Enabled = (bool)bak.dSatis;
                                    f.bGenelRapor.Enabled = (bool)bak.dRapor;
                                    f.bStok.Enabled = (bool)bak.dStok;
                                    f.dUrunGiris.Enabled = (bool)bak.dUrunGiris;
                                    f.bFiyatGuncelle.Enabled = (bool)bak.dFiyatGuncelle;
                                    f.bYedekleme.Enabled = (bool)bak.dYedekleme;
                                    f.bYedektenYukle.Enabled = false;
                                    f.bYedektenYukle.Visible = false;
                                    var isyeri = db.Sabitlerim.FirstOrDefault();
                                    f.lIsyeri.Text = isyeri.dUnvan;
                                    if (bak.dKullaniciAd == "admingiris" && bak.dSifre == "admingiris")
                                    {
                                        f.bYedektenYukle.Enabled = true;
                                        f.bYedektenYukle.Visible = true;
                                    }
                                    f.lKullanici.Text = bak.dAdSoyad;
                                    f.Show();
                                    this.Hide();
                                }
                                Cursor.Current = Cursors.Default;
                            }
                            else
                            {
                                MessageBox.Show("Hatalı Giriş");
                            }
                        }
                        else
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            Kullanici k = new Kullanici();
                            k.dAdSoyad = "admin";
                            k.dAyarlar = true;
                            k.dEposta = "eposte";
                            k.dFiyatGuncelle = true;
                            k.dKullaniciAd = "admin";
                            k.dRapor = true;
                            k.dSatis = true;
                            k.dSifre = "admin";
                            k.dStok = true;
                            k.dTelefon = "telefon";
                            k.dUrunGiris = true;
                            k.dYedekleme = true;
                            db.Kullanici.Add(k);
                            db.SaveChanges();
                            var bak = db.Kullanici.Where(x => x.dKullaniciAd == tKullanici.Text && x.dSifre == tSifre.Text).FirstOrDefault();
                            fBaslangic f = new fBaslangic();
                            f.bSatisIslemi.Enabled = (bool)bak.dSatis;
                            f.bGenelRapor.Enabled = (bool)bak.dRapor;
                            f.bStok.Enabled = (bool)bak.dStok;
                            f.dUrunGiris.Enabled = (bool)bak.dUrunGiris;
                            f.bFiyatGuncelle.Enabled = (bool)bak.dFiyatGuncelle;
                            f.bYedekleme.Enabled = (bool)bak.dYedekleme;
                            f.bYedektenYukle.Enabled = false;
                            f.bYedektenYukle.Visible = false;
                            var isyeri = db.Sabitlerim.FirstOrDefault();
                            f.lIsyeri.Text = isyeri.dUnvan;
                            if (bak.dKullaniciAd == "admingiris" && bak.dSifre == "admingiris")
                            {
                                f.bYedektenYukle.Enabled = true;
                                f.bYedektenYukle.Visible = true;
                            }
                            f.lKullanici.Text = bak.dAdSoyad;
                            f.Show();
                            this.Hide();
                            Cursor.Current = Cursors.Default;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void bGiris_Click(object sender, EventArgs e)
        {
            girisYap();
        }

        private void fLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                girisYap();
            }
        }

        
    }
}
