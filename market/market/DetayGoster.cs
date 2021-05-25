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
    public partial class DetayGoster : Form
    {
        public DetayGoster()
        {
            InitializeComponent();
        }
        public int islemno { get; set; }
        private void DetayGoster_Load(object sender, EventArgs e)
        {
            lislemno.Text = "İşlem No : " + islemno.ToString();
            using (var db = new MarketSatisEntities())
            {
                gridListe.DataSource = db.Satislar.Select(x=> new {x.dIslemNo,x.dUrunAd,x.dMikar,x.dUrunGrup,x.dToplam }).Where(x => x.dIslemNo == islemno).ToList();//işlem noya göre istediğim alanları getirdim
                islemler.GridDuzenle(gridListe);
            }
        }
    }
}
