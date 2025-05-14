using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Yonetim_Sistemi
{
    class Hastalar:Insanlar
    {
        public string Hastalik { get; set; }
        public string Doktor { get; set; }

        public Hastalar(int id,string adsoyad,string hastalik, string doktorAdi):base(id,adsoyad)
        {
            Hastalik = hastalik;
            Doktor = doktorAdi;
        }

    }
}
