using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hastane_Yonetim_Sistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Randevular randevu = new Randevular();

            while (true)
            {
                Console.WriteLine("1- Hasta Ekle");
                Console.WriteLine("2- Doktor Ekle");
                Console.WriteLine("3- Randevu Ekle");
                Console.WriteLine("4- Randevu İptal");
                Console.WriteLine("5- Hasta Listesi");
                Console.WriteLine("6- Doktor Listesi");
                Console.WriteLine("7- Çıkış");
                Console.Write("Lüten yapmak istedğinizi seçin= ");
                int secimAna = int.Parse(Console.ReadLine());

                if (secimAna == 1)
                {
                    Console.Clear();
                    randevu.Hastaekle();
                    randevu.ekrantemizleme();
                    continue;

                }
                if (secimAna == 2)
                {
                    Console.Clear();
                    randevu.Doktorekle();
                    randevu.ekrantemizleme();
                    continue;
                }
                if (secimAna == 3)
                {
                    Console.Clear();
                    randevu.RandevuEkle();
                    randevu.ekrantemizleme();
                    continue;
                }
                if (secimAna == 4)
                {
                    Console.Clear();
                    randevu.RandevuIptal();
                    randevu.ekrantemizleme();
                    continue;
                }
                if (secimAna == 5)
                {
                    Console.Clear();
                    randevu.Hastalar();
                    Console.ReadLine();
                    randevu.ekrantemizleme();
                    continue;

                }
                if (secimAna == 6)
                {
                    Console.Clear();
                    randevu.TumDoktorlar();
                    Console.ReadLine();
                    randevu.ekrantemizleme();
                    continue;
                }
                if (secimAna == 7)
                {
                    Console.Clear();
                    Console.Write("!!Çıkışınız yapılıyor lütfen bekleyin!!...");
                    Thread.Sleep(3000);
                    break;
                }
            }

            

        }


    }
}
