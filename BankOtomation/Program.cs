using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankOtomation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customers> customers = new List<Customers>();

            List<Account> accounts = new List<Account>
            {
                new Account(101, "ykp12", "Yakup", "Cağ", 2003, "Bingöl/Karlıova","Vadesiz"),
                new Account(102, "eyp12", "Eyüp", "Cağ", 2001, "Bingöl/Karlıova", "Vadesiz"),
                new Account(103, "ysf12", "Yusuf", "Cağ", 2008, "Bingöl/Karlıova", "Vadesiz")
            };
            bool girisBasarili = false;
            int id = 105;
            string password = "105";
            string name = "105";
            string surname = "105";
            int birthday = 105;
            string adress = "105";

            Customers customersdetay = new Customers(id, password, name, surname, birthday, adress);


            while (true)
            {
                Console.Write("ID girin: ");
                int identered = int.Parse(Console.ReadLine());
                Console.Write("Şifre girin: ");
                string passwordentered = Console.ReadLine();
                foreach (var item in accounts)
                {
                    item.CustomerLogIn(identered, passwordentered);

                    if (item.identer && item.passwordenter)
                    {
                        girisBasarili = true;
                        break;
                    }

                }
                if (girisBasarili)
                {
                    Console.WriteLine("Giris başarılı");
                    break;
                }
                else
                {
                    Console.WriteLine("Giriş Başarısız");
                }
            }




        }
    }
}
