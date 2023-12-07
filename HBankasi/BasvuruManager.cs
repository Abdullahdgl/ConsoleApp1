using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBankasi
{
     class BasvuruManager
    {
       public  void  BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) 
        
        {
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();


            }


        }

        public void KrediBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
