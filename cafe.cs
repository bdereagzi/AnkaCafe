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
    public partial class SiparisForm : Form
    {
        public SiparisForm(KafeVeri dbGelen, Siparisler gelenSiparis)
        {
            InitializeComponent();
            dbTemp = dbGelen;
            siparisTemp = gelenSiparis;
            sipDetayTemp = new BindingList<SiparisDetay>(siparisTemp.SiparisDetaylari);
        }
        KafeVeri dbTemp;
        Siparisler siparisTemp;
        BindingList<SiparisDetay> sipDetayTemp;
        private bool varMi;

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            cmbUrunler.DataSource = dbTemp.Urunler;
            lblMasaNo.Text = siparisTemp.MasaNo.ToString();
            this.Text = "Masa:" + siparisTemp.MasaNo.ToString() + "Açılış Tarihi:" + siparisTemp.AcilisZamani;
            dataGridView1.DataSource = siparisTemp.SiparisDetaylari;
            
            ComboMasa();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SiparisDetay d = new SiparisDetay();
            d.Adet = (int)numericUpDown1.Value;
            Urun u = (Urun)cmbUrunler.SelectedItem;
            d.UrunAdi = u.UrunAdi;
            d.BirimFiyat = u.BirimFiyat;

            sipDetayTemp.Add(d);
            dataGridView1.DataSource = sipDetayTemp;

            if (!dbTemp.AktifSiparisler.Any(a => a.MasaNo == siparisTemp.MasaNo))
                dbTemp.AktifSiparisler.Add(siparisTemp);
            lblOdemeTutari.Text = siparisTemp.ToplamTutarTl;
        }

        private void btnSiparisiptal_Click(object sender, EventArgs e)
        {
            siparisiKapat(SiparisDurum.İptal,0);
            
        }

        private void btnÖdemeAl_Click(object sender, EventArgs e)
        {
            siparisiKapat(SiparisDurum.Ödendi,siparisTemp.ToplamTutar());
            
        }
        void siparisiKapat (SiparisDurum durum, decimal odenenTutar)
        {
            siparisTemp.Durum =durum;
            siparisTemp.KapanisZamani = DateTime.Now;
            siparisTemp.OdenenTutar = odenenTutar;
            dbTemp.AktifSiparisler.Remove(siparisTemp);
            Close();
        }
        public void ComboMasa()
        {
            for (int i = 1; i <= dbTemp.MasaAdet; i++)
            {

                bool varMi = dbTemp.AktifSiparisler.Any(x => x.MasaNo == i);
                if (!varMi)
                {

                  cmbMasalar.Items.Add(i);

                }

            }
            cmbMasalar.SelectedIndex = 0;
        }
        private void cmbMasalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTasi_Click(object sender, EventArgs e)
        {

            List<SiparisDetay> tasinanList = sipDetayTemp.ToList();

            Siparisler tasinanSiparis = new Siparisler()
            {
                MasaNo = (int)cmbMasalar.SelectedItem,
                SiparisDetaylari = tasinanList,

            };

            dbTemp.AktifSiparisler.Add(tasinanSiparis);

            siparisiKapat(SiparisDurum.İptal, 0);
        }
    }
}
