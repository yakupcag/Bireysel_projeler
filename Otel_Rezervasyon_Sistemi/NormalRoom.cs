using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi
{
    class NormalRoom:Room
    {
        public NormalRoom(int room,int capacity,int price,bool available) : base(room, capacity, price, available)
        {
            
        }
        public override void GetRoomInfo()
        {
            base.GetRoomInfo();
            Console.WriteLine($"----------------------------------\n");
        }
    }
}
