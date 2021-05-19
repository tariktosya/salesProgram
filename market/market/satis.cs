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
    public partial class satis : Form
    {
        public satis()
        {
            InitializeComponent();
        }
        MarketSatisEntities db = new MarketSatisEntities();

        private void BarkodText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = BarkodText.Text.Trim();
                if (barkod.Length<=2) {
                    MiktarText.Text = barkod;
                    BarkodText.Focus();
                }
                else
                {
                    if (db.Urun.Any(a => a.dBarkod == barkod)) {
                        var urun = db.Urun.Where(a => a.dBarkod == barkod).FirstOrDefault();
                        UrunGetirListe(urun, barkod, Convert.ToDouble(MiktarText.Text));
                    }
                    else
                    {
                        int teraziOnEk = Convert.ToInt32(barkod.Substring(0, 2));//0. karakterden başla 2 taesini al
                        if(db.Terazi.Any(a=> a.TeraziOnEk == teraziOnEk))
                        {
                            string teraziurunno = barkod.Substring(2, 5);
                            if (db.Urun.Any(a=> a.dBarkod == teraziurunno))
                            {
                                var urunTerazi = db.Urun.Where(a => a.dBarkod == teraziurunno).FirstOrDefault();
                                double miktarkg = Convert.ToDouble(barkod.Substring(7, 5))/1000;
                                UrunGetirListe(urunTerazi, teraziurunno, miktarkg);
                            }
                            else
                            {
                                Console.Beep(900, 1000);
                                MessageBox.Show("Kg ürün ekleme sayfası");
                            }
                        }
                        else
                        {
                            Console.Beep(900, 1000);
                            MessageBox.Show("Normal ürün ekleme sayfası");
                        }
                    }
                }
                gridSatisListesi.ClearSelection();
                GenelToplam();
                BarkodText.Clear();
                BarkodText.Focus();
            }
        }
        private void UrunGetirListe(Urun urun, String barkod, double miktar)
        {
            int satirsayisi = gridSatisListesi.Rows.Count;
            //double miktar = Convert.ToDouble(MiktarText.Text);
            bool eklenmismi = false;
            if (satirsayisi > 0)
            {
                for (int i = 0; i < satirsayisi; i++)
                {
                    if (gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString() == barkod)
                    {
                        gridSatisListesi.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value);
                        gridSatisListesi.Rows[i].Cells["Toplam"].Value = Math.Round((Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Fiyat"].Value)), 2);
                        eklenmismi = true;
                    }
                }
            }
            if (!eklenmismi)
            {
                gridSatisListesi.Rows.Add();
                gridSatisListesi.Rows[satirsayisi].Cells["Barkod"].Value = barkod;
                gridSatisListesi.Rows[satirsayisi].Cells["UrunAdi"].Value = urun.dUrunAd;
                gridSatisListesi.Rows[satirsayisi].Cells["UrunGrup"].Value = urun.dUrunGrup;
                gridSatisListesi.Rows[satirsayisi].Cells["Birim"].Value = urun.dBirim;
                gridSatisListesi.Rows[satirsayisi].Cells["fiyat"].Value = urun.dSatisFiyat;
                gridSatisListesi.Rows[satirsayisi].Cells["miktar"].Value = miktar;
                gridSatisListesi.Rows[satirsayisi].Cells["toplam"].Value = Math.Round((miktar * (double)urun.dSatisFiyat), 2);
                gridSatisListesi.Rows[satirsayisi].Cells["AlisFiyat"].Value = urun.dAlisFiyat;
                gridSatisListesi.Rows[satirsayisi].Cells["KdvTutari"].Value = urun.dKdvTutari;
            }
        }

        private void GenelToplam()
        {
            
                double toplam = 0;
                for(int i=0; i < gridSatisListesi.Rows.Count; i++)
                {
                    toplam += Convert.ToDouble(gridSatisListesi.Rows[i].Cells["toplam"].Value);
                }
                genelToplam.Text = toplam.ToString("C2");
            }
        

        private void gridSatisListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                gridSatisListesi.Rows.Remove(gridSatisListesi.CurrentRow);
                gridSatisListesi.ClearSelection();
                GenelToplam();
                BarkodText.Focus();
            }
        }
    }
}
