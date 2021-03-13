using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adi = "gufran";
            int yas = 23;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Gufran";
            kurs1.İzlenmeOrani = 100;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "python";
            kurs2.Egitmen = "mehmet";
            kurs2.İzlenmeOrani = 151;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "ahmet";
            kurs3.İzlenmeOrani = 120;
            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen);
            }


            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int İzlenmeOrani { get; set; }
    }
}
