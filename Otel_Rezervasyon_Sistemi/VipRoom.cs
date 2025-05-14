using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    class VipRoom : Room
    {
        public VipRoom(int room, int capacity, int price, bool available, bool breakfast) :base(room,capacity,price,available)
        {
            Breakfast = breakfast;
        }
        public bool Breakfast { get; set; }
        public override void GetRoomInfo()
        {
            base.GetRoomInfo();
            Console.WriteLine($"Kahvaltı Dahil Mi= {Breakfast}");
            Console.WriteLine($"----------------------------------\n");


        }
    }
}
