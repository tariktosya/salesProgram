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
                                Console.Beep(900, 250);
                                Console.Beep(900, 250);
                                MessageBox.Show("Ürün Bulunamadı");
                            }
                        }
                        else
                        {
                            Console.Beep(900, 250);
                            Console.Beep(900, 250);
                            MessageBox.Show("Ürün Bulunamadı");
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
                        if (barkod.Length <= 2 && numbers.Text != "")
                        {
                            gridSatisListesi.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value);
                            gridSatisListesi.Rows[i].Cells["Toplam"].Value = ((Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Toplam"].Value))+(Convert.ToDouble(numbers.Text)));
                            eklenmismi = true;
                        }
                        
                        else {
                            gridSatisListesi.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value);
                            gridSatisListesi.Rows[i].Cells["Toplam"].Value = Math.Round((Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Fiyat"].Value)), 2);
                            eklenmismi = true;
                        }
                        
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
                if (barkod.Length <= 2 && numbers.Text != "")
                {
                    gridSatisListesi.Rows[satirsayisi].Cells["toplam"].Value = Convert.ToDouble(numbers.Text);
                }
                
                else
                {
                    gridSatisListesi.Rows[satirsayisi].Cells["toplam"].Value = Math.Round((miktar * (double)urun.dSatisFiyat), 2);
                }
                gridSatisListesi.Rows[satirsayisi].Cells["AlisFiyat"].Value = urun.dAlisFiyat;
                gridSatisListesi.Rows[satirsayisi].Cells["KdvTutari"].Value = urun.dKdvTutari;
            }
            MiktarText.Text = "1";
            if (odenenText.Text != "")
            {
                GenelToplam();
                double sonuc = islemler.DoubleYap(odenenText.Text) - islemler.DoubleYap(genelToplam.Text);
                paraustuText.Text = sonuc.ToString("C2");
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
                if (odenenText.Text != "")
                {
                    
                    double sonuc = islemler.DoubleYap(odenenText.Text) - islemler.DoubleYap(genelToplam.Text);
                    paraustuText.Text = sonuc.ToString("C2");
                }
                BarkodText.Focus();
            }
        }

        private void satis_Load(object sender, EventArgs e)
        {
            HizliButonEkle();
            b5.Text = 5.ToString("C2");
            b10.Text = 10.ToString("C2");
            b20.Text = 20.ToString("C2");
            b50.Text = 50.ToString("C2");
            b100.Text = 100.ToString("C2");
            b200.Text = 200.ToString("C2");
        }
        private void HizliButonEkle() {
            var hizliurun = db.HizliUrun.ToList();
            foreach(var item in hizliurun)
            {
                Button bh = this.Controls.Find("bh" + item.Id, true).FirstOrDefault() as Button;
                if(bh != null)
                {
                    
                    double fiyat = islemler.DoubleYap(item.dFiyat.ToString());
                    bh.Text = item.dUrunAd + "\n" + fiyat.ToString("C2");
                }
            }
        }
        private void HizliButonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;//gelen nesneyi buton olarak aç
            int butonid = Convert.ToInt32(button.Name.ToString().Substring(2, button.Name.Length - 2));
            if (button.Text.ToString().StartsWith("-")){
                hizliButonaEkleme f = new hizliButonaEkleme();
                f.butonId.Text = butonid.ToString();
                f.ShowDialog();
            }
            else {
                if(numbers.Text != "") {
                    var urunBarkod = db.HizliUrun.Where(a => a.Id == butonid).Select(a => a.dBarkod).FirstOrDefault();
                    var urun = db.Urun.Where(a => a.dBarkod == urunBarkod).FirstOrDefault();
                    UrunGetirListe(urun, urunBarkod, Convert.ToDouble(MiktarText.Text));
                    GenelToplam();
                    numbers.Text = "";
                }
                else
                {
                    MessageBox.Show("Fiyat Bilgisi Giriniz.");
                }
            }
        }
        
        private void RightClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                Button button = (Button)sender;//gelecek nesnemiz buton olacak
                if (!button.Text.StartsWith("-"))
                {
                    int butonid = Convert.ToInt16(button.Name.ToString().Substring(2, button.Name.Length - 2));//şimdilik 9 buton var ama ileride 2 haneli rakamlara çıkarsa burası dinamik işe yarar
                    ContextMenuStrip s = new ContextMenuStrip();
                    ToolStripMenuItem sil = new ToolStripMenuItem();
                    sil.Text = "Temizle - Buton no:" + butonid.ToString();
                    sil.Click += Sil_Click;
                    s.Items.Add(sil);
                    this.ContextMenuStrip = s;
                }
                else
                {
                    MessageBox.Show("Buton Temiz!");
                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            int butonid = Convert.ToInt16(sender.ToString().Substring(19, sender.ToString().Length - 19));
            var guncelle = db.HizliUrun.Find(butonid);
            guncelle.dBarkod = "-";
            guncelle.dFiyat = 0;
            guncelle.dUrunAd = "-";
            db.SaveChanges(); 
            Button b = this.Controls.Find("bh" + butonid, true).FirstOrDefault() as Button;//Tıklanan butonu buluyorum
            b.Text = "-" + "\n" + (0.ToString("C2"));
            
        }

        private void bNx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Text ==",")
            {
                int vrgl = numbers.Text.Count(x => x == ',');
                if (vrgl < 1)
                {
                    numbers.Text += b.Text;
                }
            }
            else if (b.Text == "<")
            {
                if (numbers.Text.Length > 0)
                {
                    numbers.Text = numbers.Text.Substring(0, numbers.Text.Length - 1);
                }
            }
            else
            {
                numbers.Text += b.Text;
            }
        }

        private void bAdet_Click(object sender, EventArgs e)
        {
            if (numbers.Text != "")
            {
                MiktarText.Text = numbers.Text;
                numbers.Clear();
                BarkodText.Clear();
                BarkodText.Focus();
            }
        }

        private void bOdenen_Click(object sender, EventArgs e)
        {
            if(numbers.Text != "")
            {
                double sonuc = islemler.DoubleYap(numbers.Text) - islemler.DoubleYap(genelToplam.Text);
                paraustuText.Text = sonuc.ToString("C2");
                odenenText.Text =islemler.DoubleYap(numbers.Text).ToString("C2");
                numbers.Clear();
                BarkodText.Focus();
            }
        }

        private void bBarkod_Click(object sender, EventArgs e)
        {
            if (numbers.Text != "")
            {
                if(db.Urun.Any(a=> a.dBarkod == numbers.Text))
                {
                    var urun = db.Urun.Where(a => a.dBarkod == numbers.Text).FirstOrDefault();
                    UrunGetirListe(urun, numbers.Text, Convert.ToDouble(MiktarText.Text));
                    numbers.Clear();
                    BarkodText.Focus();
                }
                else
                {
                    MessageBox.Show("Ürün Bulunamadı");
                    numbers.Clear();
                    BarkodText.Focus();
                }
            }
        }

        private void ParaUstu_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            double sonuc = islemler.DoubleYap(b.Text)- islemler.DoubleYap(genelToplam.Text);
            paraustuText.Text = sonuc.ToString("C2");
            odenenText.Text = islemler.DoubleYap(b.Text).ToString("C2");
            numbers.Clear();
            BarkodText.Focus();
        }

        private void bDigerUrun_Click(object sender, EventArgs e)
        {
            if(numbers.Text != "")
            {
                int satirsayisi = gridSatisListesi.Rows.Count;
                gridSatisListesi.Rows.Add();
                gridSatisListesi.Rows[satirsayisi].Cells["Barkod"].Value = "0";
                gridSatisListesi.Rows[satirsayisi].Cells["UrunAdi"].Value = "Barkodsuz Ürün";
                gridSatisListesi.Rows[satirsayisi].Cells["UrunGrup"].Value = "Barkodsuz Ürün";
                gridSatisListesi.Rows[satirsayisi].Cells["Birim"].Value = "Adet";
                gridSatisListesi.Rows[satirsayisi].Cells["miktar"].Value = "1";
                gridSatisListesi.Rows[satirsayisi].Cells["AlisFiyat"].Value = 0;
                gridSatisListesi.Rows[satirsayisi].Cells["fiyat"].Value = Convert.ToDouble(numbers.Text);
                gridSatisListesi.Rows[satirsayisi].Cells["KdvTutari"].Value = 0;
                gridSatisListesi.Rows[satirsayisi].Cells["toplam"].Value = Convert.ToDouble(numbers.Text);
                numbers.Text = "";
                GenelToplam();
                if (odenenText.Text != "")
                {
                    
                    double sonuc = islemler.DoubleYap(odenenText.Text) - islemler.DoubleYap(genelToplam.Text);
                    paraustuText.Text = sonuc.ToString("C2");
                }
                BarkodText.Focus();
            }
        }

        private void bIade_Click(object sender, EventArgs e)
        {
            if (SatisIade.Checked)
            {
                SatisIade.Checked = false;
                SatisIade.Text = "İADE İŞLEMİ";
               
            }
            else
            {
                SatisIade.Checked = true;
                SatisIade.Text = "SATIŞ YAPILIYOR";
            }
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            MiktarText.Text = "1";
            BarkodText.Clear();
            odenenText.Clear();
            paraustuText.Clear();
            genelToplam.Text = 0.ToString("C2");
            numbers.Clear();
            gridSatisListesi.Rows.Clear();
            BarkodText.Focus();
        }

        public void SatisYapilsin(string odemesekli)
        {
            int satirsayisi = gridSatisListesi.Rows.Count;
            bool satisiade = SatisIade.Checked; // True durumda
            double alisfiyattoplam = 0;
            if(satirsayisi > 0)
            {
                int? islemno = db.Islem.First().dIslemNo;
                Satislar satis = new Satislar();
                for (int i = 0; i < satirsayisi; i++)
                {
                    satis.dIslemNo = islemno;
                    satis.dUrunAd = gridSatisListesi.Rows[i].Cells["UrunAdi"].Value.ToString();
                    satis.dUrunGrup = gridSatisListesi.Rows[i].Cells["UrunGrup"].Value.ToString();
                    satis.dBarkod = gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString();
                    satis.dBirim = gridSatisListesi.Rows[i].Cells["Birim"].Value.ToString();
                    satis.dAlisFiyat = islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["AlisFiyat"].Value.ToString());
                    satis.dSatisFiyat = islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["fiyat"].Value.ToString());
                    satis.dMikar = islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["miktar"].Value.ToString());
                    satis.dToplam = islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["toplam"].Value.ToString());
                    satis.dKdvTutari = islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["KdvTutari"].Value.ToString())* islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["miktar"].Value.ToString());
                    satis.dOdemeSekli = odemesekli;
                    satis.dIade = !satisiade;
                    satis.dTarih = DateTime.Now;
                    satis.dKullanici = lKullanici.Text;
                    db.Satislar.Add(satis);
                    db.SaveChanges();

                    alisfiyattoplam += islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["AlisFiyat"].Value.ToString()) * islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["miktar"].Value.ToString());
                    //STOK İŞLEMLERİ
                    if (satis.dBarkod.Length != 1)
                    {
                        if (satisiade)
                        {
                            islemler.StokAzalt(gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString(), islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["miktar"].Value.ToString()));
                        }
                        else
                        {
                            islemler.StokArtir(gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString(), islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["miktar"].Value.ToString()));
                        }
                    }
                    
                }
                IslemOzet io = new IslemOzet();
                io.dIslemNo = islemno;
                io.dIade = !satisiade;
                io.dAlisFiyatToplam = alisfiyattoplam;
                io.dGelir = false;
                io.dGider = false;
                if (satisiade)
                {
                    io.dAciklama = odemesekli + " satış";
                }
                else
                {
                    io.dAciklama = "iade işlemi (" + odemesekli + ")";    
                }
                io.dOdemeSekli = odemesekli;
                io.dKullanici = lKullanici.Text;
                io.dTarih = DateTime.Now;
                switch (odemesekli)
                {
                    case "Nakit":
                        io.dNakit = islemler.DoubleYap(genelToplam.Text);
                        io.dKart = 0; 
                        break;
                    case "Kart":
                        io.dNakit = 0;
                        io.dKart = islemler.DoubleYap(genelToplam.Text);
                        break;
                    case "Nakit-Kart":
                        io.dNakit = islemler.DoubleYap(lNakit.Text);
                        io.dKart = islemler.DoubleYap(lKart.Text);
                        break;
                }
                db.IslemOzet.Add(io);
                db.SaveChanges();

                var islemNoArtir = db.Islem.First();
                islemNoArtir.dIslemNo += 1;
                db.SaveChanges();
                MessageBox.Show("yazdırma işlemi yap");
                Temizle();
            }
        }

        private void NakitButton_Click(object sender, EventArgs e)
        {
            SatisYapilsin("Nakit");
        }

        private void KartButton_Click(object sender, EventArgs e)
        {
            SatisYapilsin("Kart");
        }

        private void bnakitkart_Click(object sender, EventArgs e)
        {
            NakitKart f = new NakitKart();
            f.ShowDialog();
        }

        private void BarkodText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)//ve sağ tarafı = klavyeden backSpace ile silme işlemi
            {
                e.Handled = true;
            }
        }

        private void MiktarText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)//ve sağ tarafı = klavyeden backSpace ile silme işlemi
            {
                e.Handled = true;
            }
        }

        private void numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)//ve sağ tarafı = klavyeden backSpace ile silme işlemi
            {
                e.Handled = true;
            }
        }

        private void satis_KeyDown(object sender, KeyEventArgs e)//formdan tuş atama*
        {
            if(e.KeyCode == Keys.F1)
            {
                SatisYapilsin("Nakit");
            }
            if (e.KeyCode == Keys.F2)
            {
                SatisYapilsin("Kart");
            }
            if (e.KeyCode == Keys.F3)
            {
                NakitKart f = new NakitKart();
                f.ShowDialog();
            }
        }
        private void Bekle()
        {
            int satirSayisi = gridSatisListesi.Rows.Count;
            int sutunSayisi = gridSatisListesi.Columns.Count;
            if (satirSayisi > 0)
            {
                for (int i = 0; i < satirSayisi; i++)
                {
                    gridIslemBeklet.Rows.Add();
                    for (int j = 0; j < sutunSayisi ; j++)
                    {
                        gridIslemBeklet.Rows[i].Cells[j].Value = gridSatisListesi.Rows[i].Cells[j].Value;
                    }
                }
            }
        }

        private void BeklemeCikis() {

            
                int satirSayisi = gridIslemBeklet.Rows.Count;
                int sutunSayisi = gridIslemBeklet.Columns.Count;
                if (satirSayisi > 0)
                {
                    for (int i = 0; i < satirSayisi; i++)
                    {
                        gridSatisListesi.Rows.Add();
                        for (int j = 0; j < sutunSayisi ; j++)
                        {
                            gridSatisListesi.Rows[i].Cells[j].Value = gridIslemBeklet.Rows[i].Cells[j].Value;
                        }
                    }
                }
            
        }
        private void bIslemBeklet_Click(object sender, EventArgs e)
        {
            if(bIslemBeklet.Text=="İşlem Beklet") {
                Bekle();
                bIslemBeklet.BackColor = System.Drawing.Color.Red;
                bIslemBeklet.Text = "İşlem Bekliyor";
                gridSatisListesi.Rows.Clear();
            }
            else
            {
                BeklemeCikis();
                bIslemBeklet.BackColor = System.Drawing.Color.DimGray;
                gridIslemBeklet.Rows.Clear();
                bIslemBeklet.Text = "İşlem Beklet";
                BarkodText.Focus();
            }
            
        }
    }
}

