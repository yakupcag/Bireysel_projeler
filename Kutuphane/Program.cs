using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    class Program
    {
        static void Main(string[] args)
        {
            EBook kitaplar = new EBook();
            
            Console.Write("Kitap Adını Girin = ");
            kitaplar.kitapAdi = Console.ReadLine();
            Console.Write("Yazar Adını Girin = ");
            kitaplar.yazarAdi = Console.ReadLine();
            Console.Write("ISBN Girin = ");
            kitaplar.Isbn = Console.ReadLine();
            Console.Write("Fiyat Girin (TL) = ");
            kitaplar.fiyat = int.Parse(Console.ReadLine());
            Console.Write("Dosya Boyutunu Girin (MB) = ");
            kitaplar.dosyaBoyutu =float.Parse( Console.ReadLine());
            


            kitaplar.GetInfo();

            Console.Read();
        }
    }
}
