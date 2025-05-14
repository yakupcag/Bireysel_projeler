using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankOtomation
{
    class Customers
    {
        private int ID { get; set; }
        private string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Birthday { get; set; }
        public string Adress { get; set; }

        public Customers(int id,string password, string name,string surname,int birthday,string adress)
        {
            ID = id;
            Password = password;
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Adress = adress;
        }

        public bool identer=false,passwordenter=false;
        public void CustomerLogIn(int id,string password)
        {
            if (ID == id && Password==password)
            {
                identer = true;
                passwordenter = true;
            }
            else
            {
                
            }
            
            
        }
    }
}
