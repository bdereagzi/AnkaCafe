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
    public partial class GecmisSiparisler : Form
    {
        public GecmisSiparisler(KafeVeri db)
        {
            InitializeComponent();
            gelenVeri = db;
        }
        KafeVeri gelenVeri;
        private void GecmisSiparisler_Load(object sender, EventArgs e)
        {

            dgvSiparisler.DataSource = gelenVeri.GecmisSiparisler;


        }
         
        private void dgvSiparisler_Click(object sender, EventArgs e)
        {
           
            Siparis secilenSiparis = (Siparis)dgvSiparisler.SelectedRows[0].DataBoundItem;
            //dgvSiparisDetaylari.DataSource =secilenSiparis;
            dgvSiparisDetaylari.DataSource=secilenSiparis.SiparisDetaylari;
        }

        public void SiparisDetayGuncelle()
        {
            dgvSiparisDetaylari.DataSource = null;
          
        }
    }
}
