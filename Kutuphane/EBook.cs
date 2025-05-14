using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    class EBook:Kitaplar
    {
        public float dosyaBoyutu;
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Dosya Boyutu = {dosyaBoyutu} MB");
        }
    }
}
