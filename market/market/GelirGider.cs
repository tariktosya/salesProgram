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
    public partial class GelirGider : Form
    {
        public GelirGider()
        {
            InitializeComponent();
        }
        public string gelirgider { get; set; }
        public string kullanici { get; set; }
        private void GelirGider_Load(object sender, EventArgs e)
        {
            lGelirGider.Text = gelirgider + " İŞLEMİ YAPILIYOR";
        }

        private void cmbOdemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbOdemeTuru.SelectedIndex == 0)
            {
                tNakit.Enabled = true;
                tKart.Enabled = false;
            }
            else if (cmbOdemeTuru.SelectedIndex ==1)
            {
                tNakit.Enabled = false;
                tKart.Enabled = true;
            }
            else if (cmbOdemeTuru.SelectedIndex==3)
            {
                tNakit.Enabled = true;
                tKart.Enabled = true;
            }
            tNakit.Text = "0";
            tKart.Text = "0";
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (cmbOdemeTuru.Text != "")
            {
                if (tNakit.Text !="" && tKart.Text !="" && (tNakit.Text != "0" || tKart.Text!="0"))
                {
                    using(var db = new MarketSatisEntities())
                    {
                        IslemOzet io = new IslemOzet();
                        io.dIslemNo = 0;
                        io.dIade = false;
                        io.dOdemeSekli = cmbOdemeTuru.Text;
                        io.dNakit = islemler.DoubleYap(tNakit.Text);
                        io.dKart = islemler.DoubleYap(tKart.Text);
                        if (gelirgider =="GELİR")
                        {
                            io.dGelir = true;
                            io.dGider = false;
                        }
                        else
                        {
                            io.dGelir = false;
                            io.dGider = true;
                        }
                        io.dAlisFiyatToplam = 0;
                        io.dAciklama = gelirgider + " - " + tAciklama.Text;
                        io.dTarih = dateTarih.Value;
                        io.dKullanici = kullanici;
                        db.IslemOzet.Add(io);
                        db.SaveChanges();
                        MessageBox.Show(gelirgider + " İşlemi Kaydedildi.");
                        tNakit.Text = "0";
                        tKart.Text = "0";
                        tAciklama.Clear();
                        cmbOdemeTuru.Text = "";
                        Rapor f = (Rapor)Application.OpenForms["Rapor"];
                        if (f != null)
                        {
                            f.bGoster_Click(null, null);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen ödeme türünü seçin");
            }
        }
    }
}
