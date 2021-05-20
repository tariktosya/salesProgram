using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
