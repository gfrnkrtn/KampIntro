using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategoriler";
            int ögrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemGirisYapmismi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemGirisYapmismi == true)
            {
                Console.WriteLine("kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }



            Console.WriteLine(kategoriEtiketi);
        }
    }
}
