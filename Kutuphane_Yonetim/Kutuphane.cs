using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    class Kutuphane
    {
        List<Kullanicilar> kullanicilars = new List<Kullanicilar>
        {
           new Admin(101, "Yakup Cağ","123", true),
           new Admin(102, "Yakup Cağ","123", false),
           new Uye(1, "Engin Şimşek","1"),
           new Uye(2, "Bayram Birer", "2")
        };
        List<Kitap> kitaps = new List<Kitap>()
        {
            new Kitap(101,"Anlatmak için yaşamak","Bayram Birer"),
            new Kitap(102,"Medresenin Dikenleri","Bayram Birer"),
            new Kitap(103,"Sefiller", "Victor Hugo") { MevcutMu = true, AlinmaTarihi = DateTime.Now.AddDays(-10) },
            new Kitap(104, "Kürk Mantolu Madonna", "Sabahattin Ali") { MevcutMu = true, AlinmaTarihi = DateTime.Now.AddDays(-3) },
            new Kitap(105, "1984", "George Orwell")
        };

        public void UyeEkle(int id, string adsoyad, string sifre)
        {
            kullanicilars.Add(new Uye(id, adsoyad, sifre));
            Console.WriteLine($"{adsoyad} kişisi başarıyla eklenmiştir");
        }
        public void AdminEkle(int id, string adsoyad, string sifre, bool admindurumu)
        {
            kullanicilars.Add(new Admin(id, adsoyad, sifre, admindurumu));
            Console.WriteLine($"Sayın {adsoyad} admini başarıyla eklenmiştir. Adminlik durumu={admindurumu}");
        }
        public void KitapEkle(int isbn, string ad, string yazar)
        {
            kitaps.Add(new Kitap(isbn, ad, yazar));
            Console.WriteLine($"{yazar}'a ait {ad} kitap eklenmiştir");
        }
        public Kullanicilar UyeGirisi()
        {
            Kullanicilar aktifuye = null;

            while (aktifuye == null)
            {
                Console.Write("ID numaranızı girin= ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Şifrenizi girin= ");
                string sifre = Console.ReadLine();

                aktifuye = kullanicilars.FirstOrDefault(a => a.ID == id && a.Sifre == sifre);
                if (aktifuye != null)
                {
                    Console.WriteLine($"\nHoşgeldiniz Sayın {aktifuye.AdSoyad} menüye yönlendiriliyorsunuz lütfen bekleyin");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Şifre ya da ID hatalı tekrar deneyin!!!");
                    Thread.Sleep(3000);
                    Console.Clear();

                }
            }
            return aktifuye;
        }
        public void KitapOduncVer(int isbn, Kullanicilar kullanici)
        {
            Kitap odunc = kitaps.FirstOrDefault(a => a.ISBN == isbn);
            if (odunc != null && odunc.MevcutMu == true)
            {
                odunc.MevcutMu = false;
                kullanici.OduncAlınanKitap.Add(odunc);
                odunc.AlinmaTarihi = DateTime.Now;
                Console.WriteLine($"{odunc.Ad} kitabı {kullanici.AdSoyad} kişisine ödünç verilmiştir");
            }
            else
            {
                Console.WriteLine("Bu kitap ödünç alındı ya da bulunamıyor");
            }
        }
        public void KitapIadeEt(int isbn, Kullanicilar kullanici)
        {
            Kitap odunc = kitaps.FirstOrDefault(a => a.ISBN == isbn);
            if (odunc != null && odunc.MevcutMu == false)
            {
                odunc.MevcutMu = true;
                kullanici.OduncAlınanKitap.Remove(odunc);
                Console.WriteLine($"{odunc.Ad} kitabı iade edilmiştir");
            }
            else
            {
                Console.WriteLine("Bu kitap ödünç alındı ya da bulunamıyor");
            }
        }
        public void KitapAra(string aranan)
        {
            var bulunanlar = kitaps.Where(k => k.Ad.ToLower().Contains(aranan)).ToList();

            if (bulunanlar.Count > 0)
            {
                Console.WriteLine(" Arama Sonuçları:");
                foreach (var kitap in bulunanlar)
                {
                    string durum = kitap.MevcutMu ? " Mevcut" : " Ödünçte";
                    Console.WriteLine($"- {kitap.Ad} | Yazar: {kitap.Yazar} | Durum: {durum}");
                }
            }
            else
            {
                Console.WriteLine(" Aradığınız kitap bulunamadı.");
            }
        }
        public void GecikenKitaplariListele(List<Kitap> kitaplar)
        {
            Console.WriteLine("📅 Geciken Kitaplar (7+ gün):");

            DateTime bugun = DateTime.Now;

            var gecikenler = kitaplar
                .Where(k => k.MevcutMu && k.AlinmaTarihi != null && (bugun - k.AlinmaTarihi.Value).TotalDays > 7)
                .ToList();

            if (gecikenler.Count == 0)
            {
                Console.WriteLine("📘 Geciken kitap yok.");
            }
            else
            {
                foreach (var kitap in gecikenler)
                {
                    double gecikmeSuresi = (bugun - kitap.AlinmaTarihi.Value).TotalDays;
                    Console.WriteLine($"- {kitap.Ad} ({kitap.Yazar}) | Alınma Tarihi: {kitap.AlinmaTarihi.Value.ToShortDateString()} | Gecikme: {Math.Floor(gecikmeSuresi)} gün");
                }
            }

            Console.ReadLine();
        }

        public void MusaitKitaplar()
        {
            Console.WriteLine("Müsait kitaplar listesi");
            foreach (var ara in kitaps)
            {
                if (ara.MevcutMu == true)
                {
                    Console.WriteLine($"Ad:{ara.Ad}, Yazar:{ara.Yazar}");
                }
            }
        }
    }
}
