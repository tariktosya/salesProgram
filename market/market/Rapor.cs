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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        public void bGoster_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;//mouse işaretçisi işlem yapıyor gibi yuvarlak olacak
            DateTime baslangic = DateTime.Parse(dateBaslangic.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(dateBitis.Value.ToShortDateString());
            bitis = bitis.AddDays(1);
            using (var db=new MarketSatisEntities())
            {
                if (listFiltreleme.SelectedIndex ==0)
                {
                    db.Satislar.Where(x => x.dTarih >= baslangic && x.dTarih <= bitis).Load();
                    var satisim = db.Satislar.Local.ToBindingList(); 

                    db.IslemOzet.Where(x => x.dTarih >= baslangic && x.dTarih <= bitis).OrderByDescending(x => x.dTarih).Load();//tarihe göre tersten. Load headera basınca sıralama işlemi
                    var islemozet = db.IslemOzet.Local.ToBindingList();//veritabanını gereksiz yormadık buraya aldık listeyi O TARİH ARALIĞINDAKİ VERİLERİ
                    gridListe.DataSource = islemozet;

                    tCigkofte.Text = Convert.ToDouble(satisim.Where(x=> x.dUrunAd =="Çiğköfte").Sum(x=> x.dToplam)).ToString("C2");
                    tDondurma.Text = Convert.ToDouble(satisim.Where(x => x.dUrunAd == "Dondurma").Sum(x => x.dToplam)).ToString("C2");
                    tDigerurun.Text = Convert.ToDouble(satisim.Where(x => x.dUrunAd == "Barkodsuz Ürün").Sum(x => x.dToplam)).ToString("C2");
                    tManav.Text = Convert.ToDouble(satisim.Where(x => x.dUrunGrup == "Manav").Sum(x => x.dToplam)).ToString("C2");

                    tSatisNakit.Text = Convert.ToDouble(islemozet.Where(x => x.dIade == false && x.dGelir == false && x.dGider == false).Sum(x => x.dNakit)).ToString("C2");
                    tSatisKart.Text = Convert.ToDouble(islemozet.Where(y => y.dIade == false && y.dGelir == false && y.dGider == false).Sum(y => y.dKart)).ToString("C2");

                    tIadeNakit.Text = Convert.ToDouble(islemozet.Where(x => x.dIade == true).Sum(x => x.dNakit)).ToString("C2");
                    tIadeKart.Text = Convert.ToDouble(islemozet.Where(x => x.dIade == true).Sum(x => x.dKart)).ToString("C2");
                    
                    tGelirNakit.Text = Convert.ToDouble(islemozet.Where(x => x.dGelir == true).Sum(x => x.dNakit)).ToString("C2");
                    tGelirKart.Text = Convert.ToDouble(islemozet.Where(x => x.dGelir == true).Sum(x => x.dKart)).ToString("C2");

                    tGiderNakit.Text = Convert.ToDouble(islemozet.Where(x => x.dGider == true).Sum(x => x.dNakit)).ToString("C2");
                    tGiderKart.Text = Convert.ToDouble(islemozet.Where(x => x.dGider == true).Sum(x => x.dKart)).ToString("C2");

                    tToplamAlisFiyat.Text = Convert.ToDouble(db.IslemOzet.Where(x => x.dTarih >= baslangic && x.dTarih <= bitis && x.dIade == false && x.dGelir==false && x.dGider==false).Sum(x => x.dAlisFiyatToplam)).ToString("C2");
                    tSatisToplam.Text = (islemler.DoubleYap(tSatisKart.Text) + islemler.DoubleYap(tSatisNakit.Text)).ToString("C2");

                    db.Satislar.Where(x => x.dTarih >= baslangic && x.dTarih <= bitis).Load();
                    var satistablosu = db.Satislar.Local.ToBindingList();
                    double kdvtutarisatis = islemler.DoubleYap(satistablosu.Where(x => x.dIade == false).Sum(x => x.dKdvTutari).ToString());
                    double kdvtutariiade = islemler.DoubleYap(satistablosu.Where(x => x.dIade == true).Sum(x => x.dKdvTutari).ToString());
                    tKdvToplam.Text = (kdvtutarisatis - kdvtutariiade).ToString("C2");
                    
                }
                else if(listFiltreleme.SelectedIndex == 1)//Satış
                {
                    db.IslemOzet.Where(x => x.dTarih >= baslangic && x.dTarih <= bitis && x.dIade == false && x.dGelir == false && x.dGider == false).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemozet;
                }
                else if (listFiltreleme.SelectedIndex == 2)//iade
                {
                    db.IslemOzet.Where(x => x.dTarih >= baslangic && x.dTarih <= bitis && x.dIade == true).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemozet;
                }
                else if (listFiltreleme.SelectedIndex == 3)//gelir
                {
                    db.IslemOzet.Where(x => x.dTarih >= baslangic && x.dTarih <= bitis && x.dGelir == true ).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemozet;
                }
                else if (listFiltreleme.SelectedIndex == 1)
                {
                    db.IslemOzet.Where(x => x.dTarih >= baslangic && x.dTarih <= bitis && x.dGider == true).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemozet;
                }
                
            }
            islemler.GridDuzenle(gridListe);
            Cursor.Current = Cursors.Default;
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            listFiltreleme.SelectedIndex = 0;
            tKartKomisyon.Text = islemler.KartKomisyon().ToString();
        }

        private void gridListe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex==2 || e.ColumnIndex ==6 || e.ColumnIndex ==7)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value=(value) ? "Evet" : "Hayır";
                    e.FormattingApplied = true;
                }
            }
        }

        private void bGelirEkle_Click(object sender, EventArgs e)
        {
            GelirGider f = new GelirGider();
            f.gelirgider = "GELİR";
            f.kullanici = lKullanici.Text;
            f.ShowDialog();
        }

        private void bGiderEkle_Click(object sender, EventArgs e)
        {
            GelirGider f = new GelirGider();
            f.gelirgider = "GİDER";
            f.kullanici = lKullanici.Text;
            f.ShowDialog();
        }

        private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridListe.Rows.Count >0)
            {
                int islemno = Convert.ToInt32(gridListe.CurrentRow.Cells["dIslemNo"].Value.ToString());
                if (islemno != 0)
                {
                    DetayGoster f = new DetayGoster();
                    f.islemno = islemno;
                    f.ShowDialog();
                }
            }
        }

        private void bRaporAl_Click(object sender, EventArgs e)
        {
            Raporlar.Baslik = "GENEL RAPOR";
            Raporlar.SatisKart = tSatisKart.Text;
            Raporlar.SatisNakit = tSatisNakit.Text;
            Raporlar.IadeKart = tIadeKart.Text;
            Raporlar.IadeNakit = tIadeNakit.Text;
            Raporlar.GelirKart = tGelirKart.Text;
            Raporlar.GelirNakit = tGelirNakit.Text;
            Raporlar.GiderKart = tGiderKart.Text;
            Raporlar.GiderNakit = tGiderNakit.Text;
            Raporlar.TarihBaslangic = dateBaslangic.Value.ToShortDateString();
            Raporlar.TarihBitis = dateBitis.Value.ToShortDateString();
            Raporlar.KdvToplam = tKdvToplam.Text;
            Raporlar.KartKomisyon = tKartKomisyon.Text;
            Raporlar.Cigkofte = tCigkofte.Text;
            Raporlar.Dondurma = tDondurma.Text;
            Raporlar.RaporSayfasiRaporu(gridListe);
        }

       
    }
}
