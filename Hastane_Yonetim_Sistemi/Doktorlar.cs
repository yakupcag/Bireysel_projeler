using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Yonetim_Sistemi
{
    class Doktorlar : Insanlar
    {
        public string Department { get; set; }
        public bool MusaitMi { get; set; }

        public Doktorlar(int id,string adsoyad,string department,bool musaitmi):base(id,adsoyad)
        {
            Department = department;
            MusaitMi = musaitmi;
        }
    }
}
