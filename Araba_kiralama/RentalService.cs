using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba_kiralama
{
    class RentalService
    {
        private List<Account> account = new List<Account> {
            new Account(101,"Bayram","Amo","Standart"),
            new Account(102,"Engin","Goto", "Standart"),
            new Account(103,"Şemdin","Ağır", "Vip"),
        };
        //private List<Customer> customers = new List<Customer>
        //{
        //    new Customer(101,"Bayram","Amo"),
        //    new Customer(102,"Engin","Goto"),
        //    new Customer(103,"Şemdin","Ağır"),
        //};
        private List<Car> cars = new List<Car>
        {
            new Car(101,"VW","Pasaat",1250000,true),
            new Car(102,"Renault","Clio",850000,true),
            new Car(103,"Ford","Transit",3000000,true),
            new Car(104,"Fiat","Fiorino",600000,true),
        };

        public void AracEkle(int id, string marka, string model, int fiyat, bool musaitmi)
        {
            cars.Add(new Car(id, marka, model, fiyat, musaitmi));
            Console.WriteLine($"{marka} arac basarıyla eklendi ");
        }

        public void AracListele()
        {
            foreach (var ara in cars)
            {
                Console.WriteLine($"{ara.Marka} , {ara.Model}, {ara.Fiyat} TL {ara.MusaitMi}");
            }
        }

        

        public void AracKirala(int carId)
        {
            Car car = cars.FirstOrDefault(c => c.ID == carId && c.MusaitMi);
            if (car != null)
            {
                car.MusaitMi = false;
                Console.WriteLine($"{car.Marka} {car.Model} başarıyla kiralandı!");
            }
            else
            {
                Console.WriteLine("Araç mevcut değil veya zaten kiralanmış!");
            }
        }

        public void AracIade(int carId)
        {
            Car car = cars.FirstOrDefault(c => c.ID == carId && c.MusaitMi);
            if (car != null)
            {
                car.MusaitMi = true;
                Console.WriteLine($"{car.Marka} {car.Model} başarıyla kiralandı!");
            }
            else
            {
                Console.WriteLine("Araç iade işleminiz gerçekleşmiştir");
            }
        }
        public Account MusteriGiris(int id,string password)
        {
            Customer customer = account.FirstOrDefault(c => c.ID == id && c.Sifre == password);

            if (customer != null)
            {
                Console.WriteLine("Giriş başarılı!");
                return account.FirstOrDefault(a => a.Owner == customer);
            }
            else
            {
                Console.WriteLine("Hatalı ID veya şifre!");
                return null;
            }
        }

        public void MusteriListele()
        {
            foreach (var item in account)
            {
                Console.WriteLine($"Hoşgeldiniz Sayın {item.Owner}");
            }
        }

    }
}
