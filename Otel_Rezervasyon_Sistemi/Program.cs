using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>
            {
                new NormalRoom(101,4,500,false),
                new NormalRoom(102,5,500,false),
                new NormalRoom(103,4,500,false),
                new VipRoom(201,2,1500,false,true),
                new VipRoom(202,1,3000,true,true),
                new VipRoom(203,3,1500,false,false)
            };
            List<Customers> customers = new List<Customers>();

            Console.WriteLine("Müşteri Bilgilerini girin");
            Console.Write("ID= ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Ad-Soyad= ");
            string ad = Console.ReadLine();
            Console.Write("Telefon Numarası= ");
            long number = long.Parse(Console.ReadLine());
            customers.Add(new Customers(id, ad, number));
            
            Console.WriteLine("\n----Boş Odalar----\n");
            foreach(var room in rooms)
            {
                if (room.IsAvailable)
                {
                    room.GetRoomInfo();
                }
            }

            Console.Write("Lütfen kiralamak istediğiniz odayı girin = ");
            int roomselected = int.Parse(Console.ReadLine());

            Room selectedroom = rooms.Find(r => r.RoomNumber == roomselected && r.IsAvailable);

            if (selectedroom != null)
            {
                
                foreach(var customer in customers)
                {
                    customer.MakeReservation(selectedroom);
                }


                Console.WriteLine("\nGüncellenmiş Oda Listesi:\n");
                foreach (var room in rooms)
                {
                    room.GetRoomInfo();
                }
            }
            else
            {
                Console.WriteLine("Seçtiğiniz oda mevcut değil veya dolu!");
            }
            
            
            Console.ReadKey();
        }
    }
}
