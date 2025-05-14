using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba_kiralama
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Sifre { get; set; }

        public Customer(int id , string name, string sifre)
        {
            ID = id;
            Name = name;
            Sifre = sifre;
        }
    }
}
