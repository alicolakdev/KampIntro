using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya";
            urun1.Fiyati = 15;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakır";
            urun2.Fiyati = 80;

            Urun[] urunler = new Urun[] {urun1, urun2 };


            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("--------Metotlar--------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("kavun", 10, "Taze", 10);
        }
    }
}
