using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    class Kullanicilar
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Sifre { get; set; }
        public List<Kitap> OduncAlınanKitap { get; set; }
        public Admin admin { get; set; }
        public Kullanicilar(int id, string adsoyad, string sifre)
        {
            ID = id;
            AdSoyad = adsoyad;
            Sifre = sifre;
            OduncAlınanKitap = new List<Kitap>();
        }
    }
}
