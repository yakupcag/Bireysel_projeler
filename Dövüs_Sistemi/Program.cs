using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dövüs_Sistemi
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }

        protected Character(string name)
        {
            Name = name;
            Health = 100;
            Level = 1;
        }

        public abstract void Attack(Character target);

        public virtual void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health < 0)
            {
                Health = 0;
            }
            Console.WriteLine($"[{Name}, {amount} hasar aldı. Kalan sağlık= {Health}");
        }

        public void LevelUp()
        {
            Level++;
            Health += 20;
            Console.WriteLine($"{Name}, {Level}. Level oldu mevcut sağlık seviyesine +20 eklendi. Yeni sağlık durumu={Health} ");
        }

    }

    public class Warrior : Character
    {
        public Warrior(string name):base(name)
        {
        }

        public override void Attack(Character target)
        {
            Console.WriteLine($"{Name} kılıçla saldırdı");
            target.TakeDamage(15);
        }

    }

    public class Mage : Character
    {
        public Mage(string name) : base(name)
        {

        }

        public override void Attack(Character target)
        {
            Console.WriteLine($"{Name} ateş topu ile saldırdı");
            target.TakeDamage(20);
        }
    }

    public class Archer : Character
    {
            public Archer(string name) : base(name)
            {

            }

            public override void Attack(Character target)
            {
                Console.WriteLine($"{Name} OK attı");
                target.TakeDamage(12);
            }
        }

    public interface IUsable
    {
        void Use(Character target);
    }

    public class HealthPotion : IUsable
    {
        public int HealAmount { get; set; } = 25;
        public void Use(Character target)
        {
            target.Health += HealAmount;
            Console.WriteLine($"{target.Name} canı{HealAmount}eklendi. {target.Health} HP oldu");
        }

    }

    public abstract class Weapon : IUsable
    {
        public int Damage { get; set; }
        protected Weapon(int damage)
        {
            Damage = damage;
        }
        public abstract void Use(Character target);
    }

    public class Sword : Weapon
    {
        public Sword():base(15)
        {
            
        }

        public override void Use(Character target)
        {
            Console.WriteLine($"Kılıç {target.Name}'i kesiyor");
            target.TakeDamage(Damage);
        }

    }

    public class Bow : Weapon
    {
        public Bow() : base(20)
        {

        }

        public override void Use(Character target)
        {
            Console.WriteLine($" {target.Name}'a ok atıldı");
            target.TakeDamage(Damage);
        }

    }

    public class Staff : Weapon
    {
        public Staff() : base(12)
        {

        }

        public override void Use(Character target)
        {
            Console.WriteLine($"Sihirli cıvata {target.Name} hedefine saldırdı");
            target.TakeDamage(Damage);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            // Karakterleri oluştur
            Character warrior = new Warrior("Yakup");
            Character mage = new Mage("Gandalf");
            Character archer = new Archer("Legolas");

            // Item'ları oluştur
            IUsable potion = new HealthPotion();
            IUsable sword = new Sword();
            IUsable bow = new Bow();

            Console.WriteLine("--- Savaş Başlıyor! ---\n");

            // Saldırı örnekleri (Polimorfizm)
            warrior.Attack(mage);
            mage.Attack(warrior);
            archer.Attack(warrior);

            Console.WriteLine();

            // Item kullanma örnekleri (Interface kullanımı)
            potion.Use(warrior);
            sword.Use(mage);
            bow.Use(archer);

            Console.WriteLine();

            // Level up
            warrior.LevelUp();
            mage.LevelUp();


        }
    }
}
