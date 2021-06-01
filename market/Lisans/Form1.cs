using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lisans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lic lic = new Lic();
            label1.Text = lic.CpuNo() + "\n" + lic.CpuKarakterToplam().ToString();
            
            var getir0 = lic.yillar();
             var getir = lic.gunler();
            var getir1 = lic.aylar();
            var getirsifreli = lic.TarihSifrele(DateTime.Now);
            DateTime tarih = lic.TarihCoz(getirsifreli);
            var kontolno = lic.EkrandaGoster();
        }
    }
}
