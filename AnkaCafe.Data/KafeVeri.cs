using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkaCafe.Data
{
    public class KafeVeri
    {
        public KafeVeri()
        {
            try
            {
                Urunler= JsonConvert.DeserializeObject<List<Urun>>(File.ReadAllText("veri.txt"));
            }
            catch (Exception)
            {
                Urunler = new List<Urun>();
            }
        }


        

        public int MasaAdet { get; set; } = 20;
        public List<Urun> Urunler { get; set; } 
       
        public List<Siparis> AktifSiparisler { get; set; }=new List<Siparis>();
        public List<Siparis> GecmisSiparisler { get; set; }=new List<Siparis>();
        
    }
}
