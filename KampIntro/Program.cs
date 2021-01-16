using System;
using System.Collections.Generic;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.UrunAdi = "Monster Tulpar";
            urun1.UrunFiyati = 12000;
            urun1.StokAdedi = 100;

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.UrunAdi = "Monster Abra";
            urun2.UrunFiyati = 9000;
            urun2.StokAdedi = 200;

            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.UrunAdi = "Dell";
            urun3.UrunFiyati = 16000;
            urun3.StokAdedi = 80;

            Urun urun4 = new Urun();
            urun4.Id = 4;
            urun4.UrunAdi = "Casper";
            urun4.UrunFiyati = 8000;
            urun4.StokAdedi = 150;


            Urun[] urunler =new Urun[] { urun1, urun2, urun3, urun4 };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].Id.ToString());
                Console.WriteLine(urunler[i].UrunAdi);
                Console.WriteLine(urunler[i].UrunFiyati);
                Console.WriteLine(urunler[i].StokAdedi);
                Console.WriteLine("---------------------");
            }
            Console.WriteLine("for bitti");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Id.ToString());
                Console.WriteLine(urun.UrunAdi);
                Console.WriteLine(urun.UrunFiyati);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("**************");
            }

            int item = 0;
            while (item < urunler.Length)
            {
                Console.WriteLine(urunler[item].Id.ToString());
                Console.WriteLine(urunler[item].UrunAdi);
                Console.WriteLine(urunler[item].UrunFiyati);
                Console.WriteLine(urunler[item].StokAdedi);
                Console.WriteLine("________________");
                item++;
            }
        }
    }

    public class Urun
        {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public float UrunFiyati { get; set; }
        public int StokAdedi { get; set; }
    }
    
}
