using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Araba_kiralama
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalService rental = new RentalService();


            while (true)
            {
                Console.Write("Müşteri ID girin: ");
                int id;
                while (!int.TryParse(Console.ReadLine(), out id))  // Sayı girilmezse hata vermesin diye kontrol
                {
                    Console.WriteLine("Geçerli bir ID girin!");
                }

                Console.Write("Şifre girin: ");
                string password = Console.ReadLine();

                Account account = rental.MusteriGiris(id, password);
                if (rental != null)
                {
                    rental.AracListele();
                    break;
                }
            }



            Console.ReadLine();
        }
    }
}
