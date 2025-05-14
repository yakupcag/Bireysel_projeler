using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musteri_Yonetim_Sistemi
{
    class VipMusteri : Musteri
    {
        public int Indirim { get; private set; }
        public VipMusteri(int id,string ad,string eposta,int indirim) : base( id, ad, eposta)
        {
            Indirim = indirim;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"İndirim Oranı = %{Indirim}");
        }

    }
}
