using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class fVeresiye : Form
    {
        public fVeresiye()
        {
            InitializeComponent();
        }
        
        private void fVeresiye_Load(object sender, EventArgs e)
        {
            using (var db = new MarketSatisEntities()) {
                gridListe.DataSource = db.Veresiye.ToList();
                islemler.GridDuzenle(gridListe);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new MarketSatisEntities())
            {
                Veresiye veresiye = new Veresiye();
                if (tAdSoyad.Text != "" && tMiktar.Text != "")
                {
                    if (db.Veresiye.Any(a => a.dAdSoyad == tAdSoyad.Text))
                    {
                        MessageBox.Show("Müşteri Zaten Kayıtlı.");
                    }
                    else
                    {
                        veresiye.dAdSoyad = tAdSoyad.Text.ToLower();
                        veresiye.dMiktar = Convert.ToDouble(tMiktar.Text);
                        if (tTelefon.Text == "")
                        {
                            veresiye.dTelefon = "-";
                        }
                        else
                        {
                            veresiye.dTelefon = tTelefon.Text;
                        }
                        db.Veresiye.Add(veresiye);
                        db.SaveChanges();
                        tAdSoyad.Clear();
                        tTelefon.Clear();
                        tMiktar.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("AD-SOYAD ve MİKTAR alanlarını doldurunuz.");
                }
                gridListe.DataSource = db.Veresiye.ToList();
                islemler.GridDuzenle(gridListe);
            }
        }

        private void tAdSoyad_TextChanged(object sender, EventArgs e)
        {
            if (tAdSoyad.Text.Length>=2) {
                string musteriAd = tAdSoyad.Text.ToLower();
                using (var db = new MarketSatisEntities())
                {
                    db.Veresiye.Where(x => x.dAdSoyad.Contains(musteriAd)).Load();
                    gridListe.DataSource = db.Veresiye.Local.ToList();
                    islemler.GridDuzenle(gridListe);
                }
            }
        }

        private void gridListe_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string adsoyad = gridListe.CurrentRow.Cells["dAdSoyad"].Value.ToString();
            string telefon = gridListe.CurrentRow.Cells["dTelefon"].Value.ToString();
            double fiyat = Convert.ToDouble(gridListe.CurrentRow.Cells["dMiktar"].Value.ToString());
            tAdSoyad.Text = adsoyad;
            tTelefon.Text = telefon;
            //tMiktar.Text = fiyat.ToString();
        }

        private void bBorcEkle_Click(object sender, EventArgs e)
        {
            using (var db = new MarketSatisEntities())
            {
                if (db.Veresiye.Any(a => a.dAdSoyad == tAdSoyad.Text))
                {
                    var urunGuncelle = db.Veresiye.Where(a => a.dAdSoyad == tAdSoyad.Text).SingleOrDefault();
                    urunGuncelle.dMiktar += Convert.ToDouble(tMiktar.Text);
                    db.SaveChanges();
                    
                    gridListe.DataSource = db.Veresiye.ToList();
                    islemler.GridDuzenle(gridListe);
                }
                else
                {
                    MessageBox.Show("Müşteri Bulunamadı.");
                }
                tAdSoyad.Clear();
                tTelefon.Clear();
                tMiktar.Clear();
            }
        }

        private void vBorcSil_Click(object sender, EventArgs e)
        {
            using (var db = new MarketSatisEntities())
            {
                if (db.Veresiye.Any(a => a.dAdSoyad == tAdSoyad.Text))
                {
                    var urunGuncelle = db.Veresiye.Where(a => a.dAdSoyad == tAdSoyad.Text).SingleOrDefault();
                    if ((urunGuncelle.dMiktar - Convert.ToDouble(tMiktar.Text))<=0)
                    {
                        MessageBox.Show(urunGuncelle.dAdSoyad + " Adlı Müşterinin Borcu Sıfırlanmıştır.");
                        db.Veresiye.Remove(urunGuncelle);
                    }
                    else
                    {
                        urunGuncelle.dMiktar -= Convert.ToDouble(tMiktar.Text);
                    }
                    db.SaveChanges();
                    tAdSoyad.Clear();
                    tTelefon.Clear();
                    tMiktar.Clear();
                    gridListe.DataSource = db.Veresiye.ToList();
                    islemler.GridDuzenle(gridListe);
                }
                else
                {
                    MessageBox.Show("Müşteri Bulunamadı.");
                }
            }
        }

    }
}
