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
       
        public SiparisForm(KafeVeri gelenVeri,Siparis gelenSiparis)
        {
            InitializeComponent();
           
            dbTemp = gelenVeri;
            siparisTemp = gelenSiparis;
            sipDetayTemp = new BindingList<SiparisDetay>(siparisTemp.SiparisDetaylari);
            nudAdet.Value = 1;
            
        }

        KafeVeri dbTemp;
        Siparis siparisTemp;
        BindingList<SiparisDetay> sipDetayTemp;
        private void SiparisForm_Load(object sender, EventArgs e)
        {
            UrunleriGuncelle();
            lblMasaNo.Text = siparisTemp.MasaNo.ToString();
            this.Text = "Masa :" + siparisTemp.MasaNo.ToString() + "  Açılış zamanı:" + siparisTemp.AcilisZamani;

            dgvUrunListesi.DataSource = sipDetayTemp;
            
            ComboboxGuncelle();

        }

        public void UrunleriGuncelle()
        {
            cmbUrunler.DataSource = null;
            cmbUrunler.DataSource = dbTemp.Urunler;
        }

        public void ComboboxGuncelle()
        {
            cmbMasalar.Items.Clear();
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
           
            SiparisDetay yeniUrun=new SiparisDetay();
            Urun u = (Urun)cmbUrunler.SelectedItem;
            
            yeniUrun.UrunAdi = u.UrunAdi;
            yeniUrun.Adet =(int)nudAdet.Value;
            yeniUrun.BirimFiyat = u.BirimFiyat;

            sipDetayTemp.Add(yeniUrun);
            dgvUrunListesi.DataSource = sipDetayTemp;
            if(!dbTemp.AktifSiparisler.Any(a=>a.MasaNo==siparisTemp.MasaNo))
                dbTemp.AktifSiparisler.Add(siparisTemp);

            lblOdemeTutari.Text = siparisTemp.ToplamTutarTL;
            ComboboxGuncelle();
            


        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            siparisiKapat(SiparisDurum.İptal,0);
            GecmisSipariseGonder(siparisTemp);
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            siparisiKapat(SiparisDurum.Ödendi, siparisTemp.ToplamTutar());
            GecmisSipariseGonder(siparisTemp);

        }

        void siparisiKapat(SiparisDurum durum,decimal odenenTutar)
        {
            siparisTemp.Durum = durum;
            siparisTemp.KapanisZamani = DateTime.Now;
            siparisTemp.OdenenTutar = odenenTutar;

            dbTemp.AktifSiparisler.Remove(siparisTemp);
            Close();
        }
        
        private void btnTasi_Click(object sender, EventArgs e)
        {
            List<SiparisDetay> tasinacakList = sipDetayTemp.ToList();

            Siparis tasinacakSiparis = new Siparis()
            {
                MasaNo = (int)cmbMasalar.SelectedItem,
                SiparisDetaylari = tasinacakList,

            };

            dbTemp.AktifSiparisler.Add(tasinacakSiparis);                 

            siparisiKapat(SiparisDurum.İptal, 0);
        }

        private void SiparisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
           
           
        }

        private void dgvUrunListesi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {


                SiparisDetay secilenUrun = (SiparisDetay)dgvUrunListesi.SelectedRows[0].DataBoundItem;

                sipDetayTemp.Remove(secilenUrun);
            }

            if(sipDetayTemp.Count==0)
                siparisiKapat(SiparisDurum.İptal, 0);
        }

        public void GecmisSipariseGonder(Siparis gidecekSiparis)
        {
            dbTemp.GecmisSiparisler.Add(gidecekSiparis);
        }
    }
}
