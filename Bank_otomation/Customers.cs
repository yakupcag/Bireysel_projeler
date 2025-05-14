using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_otomation
{
    class Customers
    {
        public int ID { get; set; }
        public string Name_Surname { get; set; }
        public int HesapNo { get; set; }
        public Account Hesap { get; set; }

        public Customers(int id, string name, int hesapNo,decimal bakiye)
        {
            ID = id;
            Name_Surname = name;
            HesapNo = hesapNo;
            Hesap = new Account(hesapNo, bakiye);
        }
    }
}
