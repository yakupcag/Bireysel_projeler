using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Yonetim_Sistemi
{
    class Insanlar
    {
        public int TC { get; set; }
        public string AdSoyad { get; set; }

        public Insanlar(int id,string adsoyad)
        {
            TC = id;
            AdSoyad = adsoyad;
        }

    }
}
