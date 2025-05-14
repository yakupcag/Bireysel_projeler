using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutuphane kutuphane = new Kutuphane();
            Kullanicilar kullanicilar = kutuphane.UyeGirisi();

            bool cikis = false;

            while (!cikis)
            {
                if (kullanicilar is Uye)
                {
                    Console.WriteLine($"Hoşgeldiniz sayın {kullanicilar.AdSoyad}\n");
                    Console.WriteLine("1- Kitap ödünç al");
                    Console.WriteLine("2- Kitap iade et");
                    Console.WriteLine("3- Kitap Ara");
                    Console.WriteLine("4- Geciken Kitaplar");
                    Console.WriteLine("0- Çıkış");
                    Console.Write("\nLütfen yapmak istediğniz işlemin numarasını girin = ");
                    int secim = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (secim == 1)
                    {
                        Console.Write("Lütfen ISBN girin");
                        int isbn = int.Parse(Console.ReadLine());
                        kutuphane.KitapOduncVer(isbn, kullanicilar);
                    }
                    else if (secim == 2)
                    {
                        Console.Write("Lütfen ISBN girin");
                        int isbn = int.Parse(Console.ReadLine());
                        kutuphane.KitapIadeEt(isbn, kullanicilar);
                    }
                    else if (secim == 3)
                    {
                        Console.Write("Lütfen kitap adı girin");
                        string aranan = Console.ReadLine();
                        kutuphane.KitapAra(aranan);
                    }
                    else if (secim == 4)
                    {
                        kutuphane.GecikenKitaplariListele(kullanicilar.OduncAlınanKitap);
                    }
                    else if (secim == 0)
                    {
                        cikis = true;
                        break;
                    }

                }
                if (kullanicilar is Admin admin)
                {
                    if (admin.AdminDurumu == false)
                    {
                        Console.WriteLine("Admin yetkiniz yok, Yönetinizle iletişime geçin");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Hoşgeldiniz sayın {kullanicilar.AdSoyad}\n");
                        Console.WriteLine("1- Kitap ekle");
                        Console.WriteLine("2- Üye ekle");
                        Console.WriteLine("3- Admin Ekle");
                        Console.WriteLine("4- Müsait Kitaplar");
                        Console.WriteLine("0- Çıkış");
                        Console.Write("\nLütfen yapmak istediğniz işlemin numarasını girin = ");
                        int secim = int.Parse(Console.ReadLine());
                        if (secim == 1)
                        {
                            Console.Write("Kitap ISBN girin = ");
                            int isbn = int.Parse(Console.ReadLine());
                            Console.Write("Kitap adı girin = ");
                            string ad = Console.ReadLine();
                            Console.Write("Kitap yazar girin = ");
                            string yazar = Console.ReadLine();
                            Console.Write("Kitap mevcutluk durumu girin = ");
                            bool mevcutmu = bool.Parse(Console.ReadLine());
                            kutuphane.KitapEkle( isbn,  ad,  yazar);
                        }
                        else if (secim == 2)
                        {
                            Console.Write("Üye ID girin = ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Üye Ad Soyad girin = ");
                            string adsoyad = Console.ReadLine();
                            Console.Write("Üye Şİfre girin = ");
                            string sifre = Console.ReadLine();
                            kutuphane.UyeEkle(id, adsoyad, sifre);


                        }
                        else if (secim == 3)
                        {
                            Console.Write("Admin ID girin = ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Admin Ad Soyad girin = ");
                            string adsoyad = Console.ReadLine();
                            Console.Write("Admin Şİfre girin = ");
                            string sifre = Console.ReadLine();
                            Console.Write("Adminlik durumu girin = ");
                            bool admindurumu = bool.Parse(Console.ReadLine());
                            kutuphane.AdminEkle(id, adsoyad, sifre, admindurumu);
                        }
                        else if (secim == 4)
                        {
                            kutuphane.MusaitKitaplar();
                        }
                        else if (secim == 0)
                        {
                            cikis = true;
                            break;
                        }
                    }

                }

            }
        }
    }
}
