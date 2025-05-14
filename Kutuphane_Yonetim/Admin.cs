using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    class Admin:Kullanicilar
    {
        public bool AdminDurumu { get; set; }
        public Admin(int id, string adsoyad,string sifre,bool admindurumu) : base(id, adsoyad, sifre)
        {
            AdminDurumu = admindurumu;
        }
    }
}
