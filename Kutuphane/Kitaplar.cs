using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    class Kitaplar
    {
        public string kitapAdi;
        public string yazarAdi;
        public int fiyat;
        private string ISBN;

        public string Isbn 
        { 
            get
            {
                return ISBN;
            }
            set
            {
                ISBN = value;
            }
        }

        public virtual void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine($"Kitap Adı = {kitapAdi}");
            Console.WriteLine($"Yazar Adı = {yazarAdi}");
            Console.WriteLine($"ISBN = {ISBN}");
            Console.WriteLine($"Fiyat = {fiyat} TL");
        }

    }
}
