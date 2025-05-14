using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Musteri_Yonetim_Sistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> musteri = new List<Musteri>();
            //musteri.Add(new Musteri(101, "Yakup Cağ", "101ogrenci@yyu.edu.tr"));
            //musteri.Add(new Musteri(102, "Eyup Cağ", "102ogrenci@yyu.edu.tr"));
            //musteri.Add(new VipMusteri(103, "Muharrem Cağ", "103ogrenci@yyu.edu.tr",15));
            //musteri.Add(new VipMusteri(104, "Emir Cağ", "104ogrenci@yyu.edu.tr",10));
            //musteri.Add(new VipMusteri(105, "Ahmet Cağ", "105ogrenci@yyu.edu.tr",20));

            bool kontrol = true;

            while (true)
            {
                if (!kontrol)
                {
                    break;
                }
                Console.WriteLine("Lütfen eklenecek müşteri tipini seçin");
                Console.WriteLine("1- Normal Müşteri");
                Console.WriteLine("2- Vip Müşteri");
                int durum = int.Parse(Console.ReadLine());

                if (durum == 1)
                {
                    Console.Write("Müşteri ID girin = ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Müşteri Adı girin = ");
                    string isim = Console.ReadLine();
                    Console.Write("Müşteri E-posta adresi girin = ");
                    string posta = Console.ReadLine();

                    musteri.Add(new Musteri(id, isim, posta));
                }
                else if (durum == 2)
                {
                    Console.Write("Müşteri ID girin = ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Müşteri Adı girin = ");
                    string isim = Console.ReadLine();
                    Console.Write("Müşteri E-posta adresi girin = ");
                    string posta = Console.ReadLine();
                    Console.Write("Müşteri indirim tutarı girin = ");
                    int indirim = int.Parse(Console.ReadLine());


                    musteri.Add(new VipMusteri(id, isim, posta, indirim));
                }
                else
                {
                    Console.WriteLine("!Yanlış değer girdiniz tekrar deneyin!\n");
                }

                Console.Write("Devam etmek istiyor musunuz 1 veya 0 girin = ");
                int devam = int.Parse(Console.ReadLine());

                if (devam == 0)
                {
                    kontrol = false;
                }
            }

            Console.WriteLine("Müşteri Listesi");
            foreach (var item in musteri)
            {
                item.GetInfo();
                Console.WriteLine("-------------------------------");
            }


            Console.ReadLine();
        }
    }
}
