using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    class Yazdir
    {
        public int? IslemNo { get; set; }
        public Yazdir(int? islemno)
        {
            IslemNo = islemno;
        }

        PrintDocument pd = new PrintDocument();
        public void YazdirBasla()//58 mm termal yazıcıya göre dizayn edildi. 220 piksel
        {
            try
            {
                pd.PrintPage += Pd_PrintPage;
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            MarketSatisEntities db = new MarketSatisEntities();
            var isyeri = db.Sabitlerim.FirstOrDefault();
            var liste = db.Satislar.Where(x => x.dIslemNo == IslemNo).ToList();
            if (isyeri != null && liste !=null)
            {
                int kagituzunluk = 120;//kağıt uzunluğunu belirledik
                for (int i = 0; i < liste.Count; i++)//listedeki elleman kadar 15 ekledik
                {
                    kagituzunluk += 15;
                }
                PaperSize ps58 = new PaperSize("58mm Termal", 220, kagituzunluk + 120);
                pd.DefaultPageSettings.PaperSize = ps58;



                Font fontbaslik = new Font("Calibri", 10, FontStyle.Bold);
                Font fontbilgi = new Font("Calibri",8,FontStyle.Bold);
                Font fontIcerikBaslik = new Font("Calibri", 8, FontStyle.Underline);
                StringFormat ortala = new StringFormat(StringFormatFlags.FitBlackBox);//başlığı ortaladık
                ortala.Alignment = StringAlignment.Center;//devamı
                RectangleF rcUnvanKonum = new RectangleF(0, 10, 220, 20);//Konumunu da girmemiz gerekliydi
                e.Graphics.DrawString(isyeri.dUnvan, fontbaslik, Brushes.Black,rcUnvanKonum,ortala);
                e.Graphics.DrawString("Telefon : " + isyeri.dTelefon,fontbilgi,Brushes.Black,new Point(5,35));
                e.Graphics.DrawString("İşlem No : " + IslemNo.ToString(), fontbilgi, Brushes.Black, new Point(5,50));
                e.Graphics.DrawString("Tarih : " + DateTime.Now, fontbilgi, Brushes.Black, new Point(5, 65));
                e.Graphics.DrawString("------------------------------------------------ " , fontbilgi, Brushes.Black, new Point(5, 80));


                e.Graphics.DrawString("Ürün Adı", fontIcerikBaslik, Brushes.Black, new Point(5, 95));
                e.Graphics.DrawString("Miktar", fontIcerikBaslik, Brushes.Black, new Point(70, 95));
                e.Graphics.DrawString("Fiyat", fontIcerikBaslik, Brushes.Black, new Point(125, 95));
                e.Graphics.DrawString("Tutar", fontIcerikBaslik, Brushes.Black, new Point(180, 95));
                int yukseklik = 120;
                double geneltoplam = 0;

                foreach (var item in liste)
                {
                    e.Graphics.DrawString(item.dUrunAd, fontbilgi, Brushes.Black, new Point(5, yukseklik));
                    e.Graphics.DrawString(item.dMikar.ToString(), fontbilgi, Brushes.Black, new Point(75, yukseklik));
                    e.Graphics.DrawString(Convert.ToDouble(item.dSatisFiyat).ToString("C2"), fontbilgi, Brushes.Black, new Point(125, yukseklik));
                    e.Graphics.DrawString(Convert.ToDouble(item.dToplam).ToString("C2"), fontbilgi, Brushes.Black, new Point(180, yukseklik));
                    yukseklik += 15;
                    geneltoplam +=Convert.ToDouble(item.dToplam);
                }
                e.Graphics.DrawString("------------------------------------------------ ", fontbilgi, Brushes.Black, new Point(5, yukseklik+15));
                e.Graphics.DrawString("Toplam : "+ geneltoplam, fontbaslik, Brushes.Black, new Point(5, yukseklik+35));
                e.Graphics.DrawString("------------------------------------------------ ", fontbilgi, Brushes.Black, new Point(5, yukseklik+55));
                e.Graphics.DrawString("(Mali Değeri Yoktur)", fontbilgi, Brushes.Black, new Point(5, yukseklik+75));
                //Markaya ögöre kağıdın kesilmesi işlemi oluyor ona bak
                
            }
        }
    }
}
