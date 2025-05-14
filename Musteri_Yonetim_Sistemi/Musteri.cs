using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Musteri_Yonetim_Sistemi
{
    class Musteri
    {
        public int MusteriID { get; private set; }
        public string IsimSoyisim { get; set; }
        public string Email { get; set; }

        public Musteri(int id, string ad, string eposta)
        {
            MusteriID = id;
            IsimSoyisim = ad;
            Email = eposta;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine($"Müşteri ID = {MusteriID}");
            Console.WriteLine($"Müşteri Ad Soyad = {IsimSoyisim}");
            Console.WriteLine($"Müşteri Eposta = {Email}");
        }
    }
}
