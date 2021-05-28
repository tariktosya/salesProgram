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
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }

        private void bAra_Click(object sender, EventArgs e)
        {
            gridListe.DataSource = null;
            using(var db = new MarketSatisEntities())
            {
                if(cmbIslemTuru.Text != "")
                {
                    string urungrubu = cmbUrunGrubu.Text;
                    if (cmbIslemTuru.SelectedIndex == 0)
                    {
                        if (rdTumu.Checked)//Ürünleri tarihe göre listeleme
                        {
                            db.Urun.OrderBy(x => x.dMiktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();//BURASI ÖNEMLİ. Datagrid ana sekmeye basında o veriye göre listeleme yapmasını sağlıyor bu
                            islemler.GridDuzenle(gridListe);
                        }
                        else if (rdUrunGrubu.Checked)
                        {
                            db.Urun.Where(x => x.dUrunGrup == urungrubu).OrderBy(x => x.dMiktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();
                            islemler.GridDuzenle(gridListe);
                        }
                        else
                        {
                            MessageBox.Show("Filtreleme Türünü Seçiniz.");
                        }
                    }
                    else if (cmbIslemTuru.SelectedIndex == 1)
                    {
                        DateTime baslangic = DateTime.Parse(dateBaslangic.Value.ToShortDateString());
                        DateTime bitis = DateTime.Parse(dateBitis.Value.ToShortDateString());
                        bitis = bitis.AddDays(1);
                        if (rdTumu.Checked)
                        {
                            db.StokHareket.OrderByDescending(x => x.dTarih).Where(x => x.dTarih >= baslangic && x.dTarih <= bitis).Load();
                            gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                            islemler.GridDuzenle(gridListe);
                        }
                        else if (rdUrunGrubu.Checked)
                        {
                            db.StokHareket.OrderByDescending(x => x.dTarih).Where(x => x.dTarih >= baslangic && x.dTarih <= bitis && x.dUrunGrup.Contains(urungrubu)).Load();
                            gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                            islemler.GridDuzenle(gridListe);
                        }
                        else
                        {
                            MessageBox.Show("Filtreleme Türünü Seçiniz.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("İşlem Türünü Seçiniz.");
                }
            }
        }
        MarketSatisEntities dbx = new MarketSatisEntities();
        private void Stok_Load(object sender, EventArgs e)
        {
            cmbUrunGrubu.DisplayMember = "dUrunGrupAd";
            cmbUrunGrubu.ValueMember = "Id";
            cmbUrunGrubu.DataSource = dbx.UrunGrubu.ToList();
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text.Length>=2)
            {
                string urunad = tUrunAra.Text;
                using (var db = new MarketSatisEntities())
                {
                    if (cmbIslemTuru.SelectedIndex==0)
                    {
                        db.Urun.Where(x => x.dUrunAd.Contains(urunad)).Load();
                        gridListe.DataSource = db.Urun.Local.ToBindingList();
                        islemler.GridDuzenle(gridListe);
                    }
                    else if (cmbIslemTuru.SelectedIndex==1)
                    {
                        db.StokHareket.Where(x => x.dUrunAd.Contains(urunad)).Load();
                        gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                        islemler.GridDuzenle(gridListe);
                    }
                }
            }
        }

        private void bRaporAl_Click(object sender, EventArgs e)
        {
            if (cmbIslemTuru.SelectedIndex==0)
            {
                Raporlar.Baslik = cmbIslemTuru.Text + " RAPORU";
                Raporlar.TarihBaslangic = dateBaslangic.Value.ToShortDateString();
                Raporlar.TarihBitis = dateBitis.Value.ToShortDateString();
                Raporlar.StokRaporu(gridListe);
            }
            else if(cmbIslemTuru.SelectedIndex ==1){
                Raporlar.Baslik = cmbIslemTuru.Text + " RAPORU";
                Raporlar.TarihBaslangic = dateBaslangic.Value.ToShortDateString();
                Raporlar.TarihBitis = dateBitis.Value.ToShortDateString();
                Raporlar.StokIzlemeRaporu(gridListe);
            }
        }
    }
}
