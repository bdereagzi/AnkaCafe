using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkaCafe.Data
{
    public class SiparisDetay : Urun
    {
        public int Adet { get; set; }

        public string TutarTL
        {
           
            get
            {
                    return $"{Tutar():n2}₺";
                
            }
        }

        public decimal Tutar()
        {
            return BirimFiyat * Adet;
        }
    }
}
