using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bank_otomation
{
    class Program
    {
        static List<Customers> customers = new List<Customers>();
        static void Main(string[] args)
        {
            customers.Add(new Customers(1, "Yakup Cağ", 101, 1500));
            customers.Add(new Customers(2, "Eyüp Cağ", 102, 500));
            customers.Add(new Customers(3, "Ahmet Cağ", 103, 3000));

            Console.WriteLine("YYÜ Bankasına hoşgeldiniz\n");

            Customers aktifKullanici = null;

            while (aktifKullanici == null)
            {
                Console.Write("TC kimlik numaranızı girin= ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Hesap numaranızı girin= ");
                int hesapno = int.Parse(Console.ReadLine());
                aktifKullanici = customers.FirstOrDefault(a => a.ID == id && a.HesapNo == hesapno);
                if (aktifKullanici == null)
                {
                    Console.Write("Bilgiler hatalı, Lütfen Tekrar Deneyin!!!");
                    Thread.Sleep(1500);
                }
                Console.Clear();
            }

            int secim = -1;
            while (secim != 0)
            {
                Console.WriteLine($"Hoşgeldiniz sayın {aktifKullanici.Name_Surname}\n");
                Console.WriteLine("1- Bakiye görüntüle");
                Console.WriteLine("2- Para yatırma");
                Console.WriteLine("3- Para çekme");
                Console.WriteLine("4- EFT Yapma");
                Console.WriteLine("0- ÇIKIŞ");
                Console.Write("\nLütfen yapmak istedğiniz işlemin numarasını girin = ");
                secim = int.Parse(Console.ReadLine());

                if (secim == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"Bakiyeniz {aktifKullanici.Hesap.Bakiye} TL");
                    AnaMenu();
                }
                if (secim == 2)
                {
                    Console.Clear();
                    Console.Write("Yatırılacak tutarı girin= ");
                    decimal yatir = decimal.Parse(Console.ReadLine());
                    aktifKullanici.Hesap.ParaYatir(yatir);
                    Console.WriteLine($"Sayın {aktifKullanici.Name_Surname} yeni bakiyeniz {aktifKullanici.Hesap.Bakiye} TL");
                    AnaMenu();
                }
                if (secim == 3)
                {
                    Console.Clear();
                    Console.Write("Çekilecek Tutarı Girin= ");
                    decimal cek = decimal.Parse(Console.ReadLine());
                    aktifKullanici.Hesap.ParaCek(cek);
                    AnaMenu();
                }
                if (secim == 4)
                {
                    Console.Clear();
                    Console.Write("EFT yapılacak hesabı girin= ");
                    int hesapno = int.Parse(Console.ReadLine());

                    Customers hedef = customers.FirstOrDefault(a => a.HesapNo == hesapno);

                    if (hedef != null && hedef != aktifKullanici)
                    {
                        Console.Write("EFT yapılacak tutarı girin= ");
                        int bakiye = int.Parse(Console.ReadLine());
                        aktifKullanici.Hesap.EFTYap(hedef.Hesap, bakiye);
                        Console.WriteLine($"{hedef.Name_Surname} kişisine {bakiye} TL gönderilmiştir");
                        Console.WriteLine($"Güncel bakiyeniz {aktifKullanici.Hesap.Bakiye} TL'dir");
                    }
                    if (hedef == aktifKullanici)
                    {
                        Console.WriteLine("Kendi hesabınıza EFT yapamazsınız");
                    }
                    if (hedef == null)
                    {
                        Console.WriteLine("EFT yapılacak hesap bulunamadı");
                    }
                    AnaMenu();

                }
                if (secim == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Çıkışınız yapılıyor lütfen bekleyiniz...");
                    Thread.Sleep(2000);
                    break;
                }
                if (secim < 0 && secim > 4)
                {
                    Console.WriteLine("Yanlış seçim lütfen tekrar deneyin!!!");
                    Thread.Sleep(5000);
                    Console.Clear();
                }
            }

            void AnaMenu()
            {
                Console.Write("\nAna menüye gitmek için enter tuşuna basın");
                Console.ReadLine();
                Console.Write("\nAna menüye yönlendiriliyorsunuz lütfen bekleyin...");
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
    }
}
