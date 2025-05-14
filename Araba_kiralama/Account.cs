using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba_kiralama
{
    class Account:Customer
    {
        public string HesapTuru { get; set; }
        public  Customer Owner { get; set; }

        public Account(int id,string name,string sifre,string hesapturu):base(id,name,sifre)
        {
            HesapTuru = hesapturu;
        }
        
    }
}
