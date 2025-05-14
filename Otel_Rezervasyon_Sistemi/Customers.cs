using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    class Customers
    {
        public int CustomerID { get; private set; }
        public string Fullname { get; set; }
        public long TelNumber { get; set; }
        public Room BookedRoom { get; private set; }

        public Customers(int id,string name, long number )
        {
            CustomerID = id;
            Fullname = name;
            TelNumber = number;
        }
        

        public void MakeReservation(Room room)
        {
            if (room.IsAvailable)
            {
                BookedRoom = room;
                room.MakeBooking();
                Console.WriteLine($"Sayın {Fullname} {room.RoomNumber} odanız rezerve edilmiştir ücret gecelik {room.PricePerNight} TL dir.");
            }
            else
            {
                Console.WriteLine("Oda dolu ya da bulunamıyor");
            }
        }
        public void CancelingReservation()
        {
            if (BookedRoom != null)
            {
                Console.WriteLine($"Sayın {Fullname} Rezervasyonunuz iptal edilmiştir.\nBizi tercih ettiğiniz için teşekkür ederiz.");
                BookedRoom.CancelingBooking();
                BookedRoom = null;
            }
            else
            {
                Console.WriteLine("Herhangi bir rezervasyonunuz bulunmamaktadır.");
            }

        }
    }
}
