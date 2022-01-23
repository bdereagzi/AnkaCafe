using AnkaCafe.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnkaCafe
{
    public partial class Urunler : Form
    {

        public Urunler(KafeVeri dbGelen)
        {
            InitializeComponent();
            //try
            //{
            //    string jsonOkunan = File.ReadAllText("veri.txt");
            //    urunListesi = new BindingList<Urun>(JsonConvert.DeserializeObject<List<Urun>>(jsonOkunan));

            //}
            //catch (Exception)
            //{
                
            //    urunListesi = new BindingList<Urun>();//Binding Listeyi urunListesi normal liste olarak gösteriyoruz.

                
            //}
            dbTemp = dbGelen;
            
            urunListesi = new BindingList<Urun>(dbGelen.Urunler);
            dgvEklenenUrunler.DataSource = urunListesi;
        }

        KafeVeri dbTemp=new KafeVeri();

        public BindingList<Urun> urunListesi;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrunAdi.Text))
                MessageBox.Show("Ürün adı boş olamaz");
            else
            {
                Urun yeniUrun = new Urun();
                yeniUrun.UrunAdi = txtUrunAdi.Text;
                yeniUrun.BirimFiyat = (int)nudUrunFiyati.Value;
                urunListesi.Add(yeniUrun);
                dgvEklenenUrunler.DataSource = urunListesi;
            }
        }

        private void dgwEklenenUrunler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                
               
                Urun secilenUrun = (Urun)dgvEklenenUrunler.SelectedRows[0].DataBoundItem;

                urunListesi.Remove(secilenUrun);
            }
        }

        private void Urunler_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(urunListesi);
            File.WriteAllText("veri.txt", json);
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
           
        }
    }
}
