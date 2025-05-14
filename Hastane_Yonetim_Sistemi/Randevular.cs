using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hastane_Yonetim_Sistemi
{
    class Randevular
    {
        List<Hastalar> Lhastalar = new List<Hastalar>
        {
            new Hastalar(101,"Emre Demir","KBB","Ahmet Orak"),
            new Hastalar(102,"Eyüp Atlı","Psikolji", "Gülsüm Balık"),
            new Hastalar(103,"Havva Bilir","Çocuk", "Emir Kanık")
        };

        List<Doktorlar> Ldoktorlar = new List<Doktorlar>
        {
            new Doktorlar(201,"Ahmet Orak","KBB",true),
            new Doktorlar(202,"Gülsüm Balık","Psikoloji", false),
            new Doktorlar(203,"Emir Kanık","Çocuk", true)
        };

        public void Hastaekle()
        {
            bool hastavarmi = false;
            Console.WriteLine("Hasta TC, AD-Soyad, Hastalık sırayla girin");
            int id = int.Parse(Console.ReadLine());
            string adsoyad = Console.ReadLine();
            string hastalik = Console.ReadLine();
            foreach (var item in Lhastalar)
            {
                if (item.TC==id)
                {
                    Console.WriteLine($"Sayın {item.AdSoyad} kayıtlı olduğunuz doktor {item.Doktor}");
                    hastavarmi = true;
                    break;
                }
                
            }
            if (!hastavarmi)
            {
                MusaitDoktorlistele();
                Console.Write("Doktorun adını girin: ");
                string doktorAdi = Console.ReadLine();
                bool doktorfind = false;
                foreach (var item in Ldoktorlar)
                {
                    if (item.AdSoyad == doktorAdi && item.MusaitMi == true)
                    {
                        doktorfind = true;
                        Lhastalar.Add(new Hastalar(id, adsoyad, hastalik, doktorAdi));
                        Console.WriteLine($"{adsoyad} kaydı başarıyla oluşturulmuştur.");
                    }
                    

                }
                if(doktorfind==false)
                {
                    Console.WriteLine("Doktor bulunamadı");
                }
            }
        }

        public void RandevuEkle()
        {
            Console.WriteLine("Hasta ID girin");
            int id = int.Parse(Console.ReadLine());
            bool hastaara = false;
            string doktoradi=null;
            foreach (var hasta in Lhastalar)
            {
                if (hasta.TC == id)
                {
                    hastaara = true;
                    doktoradi = hasta.Doktor;
                }
            }
            bool doktorara = false;
            if (hastaara)
            {
                foreach (var doktor in Ldoktorlar)
                {
                    if (doktoradi==doktor.AdSoyad)
                    {
                        doktor.MusaitMi = false;
                        doktorara = true;
                    }
                }
                if (!doktorara)
                {
                    Console.WriteLine("Doktor bulunamadı!!..");
                }
            }
            else
            {
                Console.WriteLine("Hasta ID bulunmadı!!..");
            }
            if (doktorara)
            {
                Console.WriteLine("Randevu başarıyla oluşturulmuştur");
            }
        }

        public void RandevuIptal()
        {
            Console.Write("Doktor ID girin= ");
            int id = int.Parse(Console.ReadLine());
            bool doktorara= false;
            foreach (var item in Ldoktorlar)
            {
                if (item.TC==id)
                {
                    Console.WriteLine($"{item.AdSoyad}'ın Randevusu iptal edilmiştir.");
                    item.MusaitMi = true;
                    doktorara = true;
                }
            }
            if (doktorara==false)
            {
                Console.WriteLine("Doktor bulunmadı");
            }
            MusaitDoktorlistele();
        }

        public void Doktorekle()
        {
            Console.WriteLine("Doktor TC, AD-Soyad, Departman ve Musaitlik durumunu sırayla girin");
            int id = int.Parse(Console.ReadLine());
            string adsoyad = Console.ReadLine();
            string department = Console.ReadLine();
            bool musaitmi = bool.Parse(Console.ReadLine());
            Ldoktorlar.Add(new Doktorlar(id, adsoyad, department,musaitmi));
            Console.WriteLine($"Doktor {adsoyad} başarıyla eklenmiştir....");
        }

        public void MusaitDoktorlistele()
        {
            Console.WriteLine("\nMüsait Doktorlar Listesi:");
            foreach (var item in Ldoktorlar)
            {
                if (item.MusaitMi == true)
                {
                    Console.WriteLine($"{item.AdSoyad} Departman= {item.Department}");
                }
            }
        }

        public void TumDoktorlar()
        {
            Console.WriteLine("\nTüm Doktorlar:");
            foreach (var item in Ldoktorlar)
            {
                Console.WriteLine($"{item.AdSoyad}, Departman= {item.Department}, Müsait mi= {item.MusaitMi}");
            }
            Console.WriteLine();
        }

        public void Hastalar()
        {
            Console.WriteLine("\nTüm Hastalar:");
            foreach (var item in Lhastalar)
            {
                Console.WriteLine($"{item.AdSoyad}, Hastalık= {item.Hastalik},Doktor= {item.Doktor}");
            }
            Console.WriteLine();
        }

        public void ekrantemizleme()
        {
            Console.WriteLine("Ana menüye yönlendiriliyorsunuz lütfen bekleyin......");
            Thread.Sleep(3000);
            Console.Clear();
        }

    }


}
