using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    static class Raporlar
    {
        public static string Baslik { get; set; }
        public static string TarihBaslangic { get; set; }
        public static string TarihBitis  { get; set; }
        public static string SatisNakit { get; set; }
        public static string SatisKart { get; set; }
        public static string IadeNakit { get; set; }
        public static string IadeKart { get; set; }
        public static string GelirNakit { get; set; }
        public static string GelirKart { get; set; }
        public static string GiderNakit { get; set; }
        public static string GiderKart { get; set; }
        public static string KdvToplam { get; set; }
        public static string KartKomisyon { get; set; }
        public static string Cigkofte { get; set; }
        public static string Dondurma { get; set; }
        public static void RaporSayfasiRaporu(DataGridView dgv)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<IslemOzet> list = new List<IslemOzet>();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new IslemOzet
                {
                    dIslemNo = Convert.ToInt32(dgv.Rows[i].Cells["dIslemNo"].Value.ToString()),
                    dIade = Convert.ToBoolean(dgv.Rows[i].Cells["dIade"].Value),
                    dOdemeSekli = dgv.Rows[i].Cells["dOdemeSekli"].Value.ToString(),
                    dNakit = islemler.DoubleYap(dgv.Rows[i].Cells["dNakit"].Value.ToString()),
                    dKart = islemler.DoubleYap(dgv.Rows[i].Cells["dKart"].Value.ToString()),
                    dGelir = Convert.ToBoolean(dgv.Rows[i].Cells["dGelir"].Value),
                    dGider = Convert.ToBoolean(dgv.Rows[i].Cells["dGider"].Value),
                    dAlisFiyatToplam = islemler.DoubleYap(dgv.Rows[i].Cells["dAlisFiyatToplam"].Value.ToString()),
                    dAciklama = dgv.Rows[i].Cells["dAciklama"].Value.ToString(),
                    dTarih = Convert.ToDateTime(dgv.Rows[i].Cells["dTarih"].Value.ToString()),
                    dKullanici = dgv.Rows[i].Cells["dKullanici"].Value.ToString()
                }); 
            }
            ReportDataSource rs = new ReportDataSource();
            rs.Name = "dsGenelRapor";
            rs.Value = list;
            fRaporGoster f = new fRaporGoster();
            f.reportViewer1.LocalReport.DataSources.Clear();
            f.reportViewer1.LocalReport.DataSources.Add(rs);
            f.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpGenelRapor.rdlc";

            ReportParameter[] prm = new ReportParameter[15];
            prm[0] = new ReportParameter("Baslik", Baslik);
            prm[1] = new ReportParameter("TarihBaslangic", TarihBaslangic );
            prm[2] = new ReportParameter("TarihBitis", TarihBitis );
            prm[3] = new ReportParameter("SatisNakit", SatisNakit );
            prm[4] = new ReportParameter("SatisKart", SatisKart );
            prm[5] = new ReportParameter("IadeNakit", IadeNakit );
            prm[6] = new ReportParameter("IadeKart", IadeKart );
            prm[7] = new ReportParameter("GelirNakit", GelirNakit );
            prm[8] = new ReportParameter("GelirKart", GelirKart );
            prm[9] = new ReportParameter("GiderNakit", GiderNakit );
            prm[10] = new ReportParameter("GiderKart", GiderKart );
            prm[11] = new ReportParameter("KdvToplam", KdvToplam );
            prm[12] = new ReportParameter("KartKomisyon", KartKomisyon);
            prm[13] = new ReportParameter("Cigkofte", Cigkofte);
            prm[14] = new ReportParameter("Dondurma", Dondurma);
            f.reportViewer1.LocalReport.SetParameters(prm);
            f.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            f.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
        public static void StokRaporu(DataGridView dgv)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<Urun> list = new List<Urun>();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new Urun
                {
                    dBarkod = dgv.Rows[i].Cells["dBarkod"].Value.ToString(),
                    dUrunAd= dgv.Rows[i].Cells["dUrunAd"].Value.ToString(),
                    dBirim = dgv.Rows[i].Cells["dBirim"].Value.ToString(),
                    //dSatisFiyat = islemler.DoubleYap(dgv.Rows[i].Cells["dSatisFiyat"].Value.ToString()),
                    dMiktar = islemler.DoubleYap(dgv.Rows[i].Cells["dMiktar"].Value.ToString()),
                    dAciklama = dgv.Rows[i].Cells["dAciklama"].Value.ToString(),
                }); ;
            }
            ReportDataSource rs = new ReportDataSource();
            rs.Name = "dsStokUrun";
            rs.Value = list;
            fRaporGoster f = new fRaporGoster();
            f.reportViewer1.LocalReport.DataSources.Clear();
            f.reportViewer1.LocalReport.DataSources.Add(rs);
            f.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpStokUrun.rdlc";

            ReportParameter[] prm = new ReportParameter[3];
            prm[0] = new ReportParameter("Baslik", Baslik);
            prm[1] = new ReportParameter("TarihBaslangic", TarihBaslangic);
            prm[2] = new ReportParameter("TarihBitis", TarihBitis);
            
            f.reportViewer1.LocalReport.SetParameters(prm);
            f.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            f.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
        public static void StokIzlemeRaporu(DataGridView dgv)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<StokHareket> list = new List<StokHareket>();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new StokHareket
                {
                    dBarkod = dgv.Rows[i].Cells["dBarkod"].Value.ToString(),
                    dUrunAd = dgv.Rows[i].Cells["dUrunAd"].Value.ToString(),
                    dBirim = dgv.Rows[i].Cells["dBirim"].Value.ToString(),
                    dMiktar = islemler.DoubleYap(dgv.Rows[i].Cells["dMiktar"].Value.ToString()),
                    dUrunGrup = dgv.Rows[i].Cells["dUrunGrup"].Value.ToString(),
                    dKullanici = dgv.Rows[i].Cells["dKullanici"].Value.ToString(),
                    dTarih = Convert.ToDateTime(dgv.Rows[i].Cells["dTarih"].Value.ToString())
                }) ; 
            }
            ReportDataSource rs = new ReportDataSource();
            rs.Name = "dsStokIzleme";
            rs.Value = list;
            fRaporGoster f = new fRaporGoster();
            f.reportViewer1.LocalReport.DataSources.Clear();
            f.reportViewer1.LocalReport.DataSources.Add(rs);
            f.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpStokIzleme.rdlc";

            ReportParameter[] prm = new ReportParameter[3];
            prm[0] = new ReportParameter("Baslik", Baslik);
            prm[1] = new ReportParameter("TarihBaslangic", TarihBaslangic);
            prm[2] = new ReportParameter("TarihBitis", TarihBitis);

            f.reportViewer1.LocalReport.SetParameters(prm);
            f.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            f.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
    }
}
