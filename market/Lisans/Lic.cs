using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lisans
{
    public class Lic
    {
        public string CpuNo()
        {
            string islemciid = "";
            ManagementObjectSearcher ara = new ManagementObjectSearcher("Select * From WIN32_Processor");
            ManagementObjectCollection obje = ara.Get();
            foreach (ManagementObject item in obje)
            {
                islemciid = item["ProcessorId"].ToString();
            }
            return islemciid;
        }
        public int CpuKarakterToplam()
        {
            int toplam = 0;
            foreach (char item in CpuNo().ToCharArray())//string içerisindeki tüm karakterleri tek tek gezer
            {
                toplam += (int)item;//item in ascii karşılığını aldık
            }
            return toplam;
        }
        public string gunkarakter = "MNBVCXZLKJHGFDSAPOIUYTREWQQAZWSXEDCRFVTGBYHNUJMIKOLQSCWDVEFBRGNTHMYJKASDFGHJKLZXCVBNM";
        public string aykarakter = "PLOKMIJNUHBYGVTFCRDXESZWAQAZWSXEDCRFVTGBYHNUJMIKOL";
        string yilkarakter = "QWERTYUIOPASDFGHJKLZXCVBNMQAZWSXEDCRFVTGBYHNUJMIKLMNBVCZLKJHGFDSAPOIUYTREWQOLIKUJMYHNTGBRFVEDCWSXQAZ";

        public bool TarihKontrol(DateTime baslangic, DateTime bitis) {
            return baslangic < DateTime.Now && DateTime.Now < bitis;
        }
        public int GirilenLisansiKontrolEt(string girilenlisansbilgisi)
        {
            Cursor.Current = Cursors.WaitCursor;
            double girilen = Convert.ToDouble(girilenlisansbilgisi);
            bool demomu = girilen == CpuKarakterToplam() * TarihFonksiyon() * 3;
            bool yillikmi = girilen == CpuKarakterToplam() * TarihFonksiyon() * 13;
            int durum = 0;
            if (demomu)
            {
                durum = 1; // demo kurulum için 1 döndür
            }
            else if (yillikmi)
            {
                durum = 2;//yıllık durum için 2 döndürdük
            }
            else
            {
                durum = 0;
            }
            Cursor.Current = Cursors.Default;
            return durum;
        }

        public DateTime demoTarihiOlustur(int gun)
        {
            DateTime tarih = DateTime.Now.AddDays(gun);
            return tarih;
        }
        public DateTime YillikTarihOlustur()
        {
            DateTime tarih = DateTime.Now.AddYears(1);
            return tarih;
        }
        public long EkrandaGoster()
        {
            long gosterilecekno = CpuKarakterToplam() * TarihFonksiyon();
            return gosterilecekno;
        }
        public long TarihFonksiyon()//kontrol için önemli
        {
            return (DateTime.Now.Day + DateTime.Now.Month) * DateTime.Now.Year;
        }
        public DateTime TarihCoz(string sifrelitarih)
        {
            string strgun = sifrelitarih.Substring(0, 2);
            string stray = sifrelitarih.Substring(2, 2);
            string stryil = sifrelitarih.Substring(4, 2);
            int gun = gunler().Where(x => x.Ad == strgun).FirstOrDefault().Numara;
            int ay = aylar().Where(x => x.Ad == stray).FirstOrDefault().Numara;
            int yil = yillar().Where(x => x.Ad == stryil).FirstOrDefault().Numara;
            DateTime tarih = new DateTime(yil, ay, gun);
            return tarih;

        }
        public String TarihSifrele(DateTime tarih)
        {
            int gun = tarih.Day;
            int ay = tarih.Month;
            int yil = tarih.Year;
            String strgun = gunler().Where(x => x.Numara == gun).FirstOrDefault().Ad;
            String stray = aylar().Where(x => x.Numara == ay).FirstOrDefault().Ad;
            String stryil = yillar().Where(x => x.Numara == yil).FirstOrDefault().Ad;
            string olusan = strgun + stray + stryil;
            return olusan;
        }
        public List<Sablon> gunler()
        {
            List<Sablon> listGun = new List<Sablon>();
            for (int i = 0; i < 31; i++)
            {
                listGun.Add(new Sablon { Numara = i + 1, Ad = gunkarakter.ToString().Substring(i * 2, 2) });
            }
            return listGun;
        }
        public List<Sablon> aylar()
        {
            List<Sablon> listAy = new List<Sablon>();
            for (int i = 0; i < 12; i++)
            {
                listAy.Add(new Sablon { Numara = i + 1, Ad = aykarakter.ToString().Substring(i * 2, 2) });
            }
            return listAy;
        }
        public List<Sablon> yillar()
        {
            List<Sablon> listYil = new List<Sablon>();
            int karaktersayisi = 0;
            for (int i = 2020; i < 2050; i++)
            {
                listYil.Add(new Sablon { Numara = i, Ad = yilkarakter.ToString().Substring(karaktersayisi * 2, 2) });
                karaktersayisi += 1;
            }
            return listYil;
        }
        public class Sablon
        {
            public int Numara { get; set; }
            public string Ad { get; set; }
        }
    }
}
