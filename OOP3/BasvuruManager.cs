using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }


        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> Krediler)
        {
            foreach (var kredi in Krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}
