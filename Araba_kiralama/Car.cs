using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba_kiralama
{
    class Car
    {
        Account Own { get; set; }
        public int ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Fiyat { get; set; }
        public bool MusaitMi { get; set; }

        public Car(int id,string marka, string model,int fiyat,bool musaitmi)
        {
            ID = id;
            Marka = marka;
            Model = model;
            Fiyat = fiyat;
            MusaitMi = musaitmi;
        }
    }
}
