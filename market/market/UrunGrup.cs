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
    public partial class UrunGrup : Form
    {
        public UrunGrup()
        {
            InitializeComponent();
        }
        MarketSatisEntities db = new MarketSatisEntities();
        private void UrunGrup_Load(object sender, EventArgs e)
        {
            GrupDoldur();
        }

        private void bStandart1_Click(object sender, EventArgs e)
        {
            if (tUrunGrupAd.Text !="")
            {
                UrunGrubu urungrup = new UrunGrubu();
                urungrup.dUrunGrupAd = tUrunGrupAd.Text;
                db.UrunGrubu.Add(urungrup);
                db.SaveChanges();
                GrupDoldur();
                tUrunGrupAd.Clear();
                UrunGiris f = (UrunGiris)Application.OpenForms["UrunGiris"];
                if (f != null)
                {
                    f.GrupDoldur();
                }
                MessageBox.Show("Ürün Grubu Eklendi.");
            }
            else
            {
                MessageBox.Show("Grup Bilgisi Girin.");
            }
        }
        private void GrupDoldur()
        {
            listBox1.DisplayMember = "dUrunGrupAd";
            listBox1.ValueMember = "Id";
            listBox1.DataSource = db.UrunGrubu.OrderBy(a => a.dUrunGrupAd).ToList();
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            int grupid = Convert.ToInt32(listBox1.SelectedValue.ToString());
            string grupad = listBox1.Text;
            DialogResult onay = MessageBox.Show(grupad + " Grubunu Silmek İstiyor Musun?", "Silme İşlemi",MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                var grup = db.UrunGrubu.FirstOrDefault(x => x.Id == grupid);
                db.UrunGrubu.Remove(grup);
                db.SaveChanges();
                GrupDoldur();
                tUrunGrupAd.Focus();
                UrunGiris f = (UrunGiris)Application.OpenForms["UrunGiris"];
                f.GrupDoldur();
                MessageBox.Show(grupad + " Adlı Ürün Grubu Silindi");
            }
        }
    }
}
