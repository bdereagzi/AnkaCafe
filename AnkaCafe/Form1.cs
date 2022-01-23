using AnkaCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnkaCafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MasaOlustur();
        }

        public void MasaOlustur()
        {
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                ListViewItem lv = new ListViewItem($"Masa {i}");
                lv.Tag = i;
                lv.ImageKey = db.AktifSiparisler.Any(a => a.MasaNo == i) ? "dolu2.png" : "bos2.png";
                //linq kodu = Any herhangi biri var mı diye konttol ediyor ve bool değer döndürüyor, sonrasında ternary if yazdık.
                listView1.Items.Add(lv);
            }
        }

        KafeVeri db=new KafeVeri();
        private void Form1_Load(object sender, EventArgs e)
        {
            //KafeVeri db=new KafeVeri();
            ////db.GecmisSiparisler = new List<Siparis>();  KafeVeri içerisinde zaten bunu oluşturduk. O yüzden bu şekilde gerek yok.


            

        }

       

        private void urunlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler formUrn = new Urunler(db);
            formUrn.ShowDialog();

        }

        private void gecmisSiparislerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GecmisSiparisler formGecmis = new GecmisSiparisler(db);
            formGecmis.ShowDialog();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
            ListViewItem item= listView1.SelectedItems[0];
            int masaNo = (int)item.Tag;

            Siparis siparis = db.AktifSiparisler.Where(x => x.MasaNo == masaNo).FirstOrDefault();

            if(siparis==null)
            {
                siparis = new Siparis();
                siparis.MasaNo = masaNo;
            }

            SiparisForm formSiparis = new SiparisForm(db,siparis);

            formSiparis.ShowDialog();
        }
    }
}
