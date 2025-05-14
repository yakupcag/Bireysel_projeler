using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_otomation
{
    class Account 
    {
        public int HesapNO { get; set; }
        public decimal Bakiye { get; set; }

        public Account(int hesapno,decimal bakiye)
        {
            HesapNO = hesapno;
            Bakiye = bakiye;
        }

        public void ParaYatir(decimal bakiye)
        {
            Bakiye += bakiye;
        }
        public void ParaCek(decimal bakiye)
        {
            if (Bakiye>=bakiye)
            {
                Bakiye -= bakiye;
                Console.WriteLine($"Yeni bakiyeniz {Bakiye} TL'dir");
            }
            else
            {
                Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır!!!");
            }
        }
        public void EFTYap(Account hedefhesap,decimal bakiye)
        {
            if (Bakiye>=bakiye)
            {
                Bakiye -= bakiye;
                hedefhesap.Bakiye += bakiye;
                //Console.WriteLine($"{hedefhesap.HesapNO} hesap numarasına EFT gönderim başarıyla sağlanmıştır");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye ile EFT Yapılamaz!!!");
            }
        }
    }
}
