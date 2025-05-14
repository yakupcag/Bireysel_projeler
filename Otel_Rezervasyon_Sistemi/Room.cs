using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    abstract class Room
    {
        public Room(int room, int capacity, int price, bool available)
        {
            RoomNumber = room;
            Capacity = capacity;
            PricePerNight = price;
            IsAvailable = available;

        }
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public int PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        public virtual void GetRoomInfo()
        {
            Console.WriteLine($"Oda Numarası= {RoomNumber}");
            Console.WriteLine($"Kapasite= {Capacity}");
            Console.WriteLine($"Gecelik Oda Ücreti= {PricePerNight}");
            Console.WriteLine($"Müsait Mi= {IsAvailable}");
        }

        public void MakeBooking()
        {
            IsAvailable = false;
        }
        public void CancelingBooking()
        {
            IsAvailable = true;
        }
    }
}
