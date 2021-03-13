using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "armut";
            double fiyati = 15;
            string aciklama = "armutun iyisini...";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "armutun iyisini...";

            Urun urun2 = new Urun();
            urun2.Adi = "mandalin";
            urun2.Fiyati = 15;
            urun2.Aciklama = "narenciye";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun  urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------");
    
            }


            Console.WriteLine("-----Metotlar-------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("portakal", "antalya", 10, 7);
            sepetManager.Ekle2("kayısı", "malatya", 7, 25);
            sepetManager.Ekle2("şeftali", "tüylü", 11, 18);




        }
    }
}
