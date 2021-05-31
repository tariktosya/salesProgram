using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class fBaslangic : Form
    {
        public fBaslangic()
        {
            InitializeComponent();
        }

        private void bSatisIslemi_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            satis f = new satis();
            f.lKullanici.Text = lKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void bGenelRapor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Rapor f = new Rapor();
            f.lKullanici.Text = lKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void bStok_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Stok f = new Stok();
            f.lKullanici.Text = lKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

      

        private void dUrunGiris_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            UrunGiris f = new UrunGiris();
            f.lKullanici.Text = lKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void bCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bFiyatGuncelle_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fFiyatGuncelle f = new fFiyatGuncelle();
            
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void bAyarlar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fAyarlar f = new fAyarlar();
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void bYedekleme_Click(object sender, EventArgs e)
        {
            islemler.BackUp();
        }

        

        private void bKullaniciDegistir_Click(object sender, EventArgs e)
        {
            
            fLogin login = new fLogin();
            login.Show();
            this.Hide();
        }

        private void bYedektenYukle_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\ProgramRestore.exe");
            Application.Exit();
        }
    }
}
