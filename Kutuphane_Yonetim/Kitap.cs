using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    class Kitap
    {
        public int ISBN { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public bool MevcutMu { get; set; }
        public DateTime? AlinmaTarihi { get; set; }
        public Kullanicilar kullanici { get; set; }

        public Kitap(int isbn,string ad, string yazar)
        {
            ISBN = isbn;
            Ad = ad;
            Yazar = yazar;
            MevcutMu = true;
            AlinmaTarihi = null;
        }
    }
}
