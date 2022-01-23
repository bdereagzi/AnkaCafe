using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkaCafe.Data
{
    public class Siparis
    {

        public int MasaNo { get; set; }
        public SiparisDurum Durum { get; set;}
        public decimal OdenenTutar { get; set; }
        public DateTime AcilisZamani { get; set; }=DateTime.Now;
        public DateTime KapanisZamani { get; set; }
        public List<SiparisDetay> SiparisDetaylari { get; set; }=new List<SiparisDetay>();

        public string ToplamTutarTL
        {
            get
            {
                return $"{ToplamTutar():n2}₺";
                
            }
        }

        public decimal ToplamTutar()
        {
           return SiparisDetaylari.Sum(a=>a.Tutar());


            //2.Yol
            //return SiparisDetaylari.Sum(a => a.Adet * a.BirimFiyat);

            //3.Yol
            //decimal toplamT = 0;
            //foreach (var item in SiparisDetaylari)
            //{
            //    toplamT += item.BirimFiyat * item.Adet;
            //}
            //return toplamT;
        }

    }
}
