using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOtomation
{
    class Account : Customers
    {
        public string AccountType { get; set; }
        public int Money { get; set; }

        public Account(int id, string password, string name, string surname, int birthday, string adress, string accounttype) : base(id, password, name, surname, birthday, adress)
        {
            AccountType = accounttype;
        }

        public void GetAccountInfo()
        {
            Console.WriteLine($"Sayın {Name} {Surname} {AccountType} hesabınızda {Money} TL vardır.");
        }

        public void MoneyEnter(int money)
        {
            if (money >= 0)
            {
                Money = Money + money;
                Console.WriteLine($"Sayın {Name} {Surname}:\n{AccountType} hesabınızdaki bakiyeniz {Money} TL olarak güncellenmiştir.");
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı girin");
            }
        }
        public void MoneyExit(int money)
        {
            if (money <= Money)
            {
                Money = Money - money;
                Console.WriteLine($"Sayın {Name} {Surname}:\n{AccountType} hesabınızdaki bakiyeniz {Money} TL olarak güncellenmiştir.");
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı girin");
            }
        }

        public void MoneyTransfer(Customers customer)
        {
            Console.Write("Transfer edilecek para miktarını girin");
            int mtransfer = int.Parse(Console.ReadLine());
            if (Money >= mtransfer)
            {
                int temp = Money;
                Money = Money - mtransfer;
                Money = temp;
                Console.WriteLine($"Sayın {Name} {Surname}:\n{AccountType} hesabınızdaki bakiyeniz {Money} TL olarak güncellenmiştir.");
            }
            else
            {
                Console.WriteLine("Göndereceğiniz ücret bakiyenizden fazla olamaz!");
            }
        }
    }
}
