using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); 
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
           
            BasvuruManager basvuruManager = new BasvuruManager();
           

            List<IKrediManager> krediler = new List<IKrediManager> {ihtiyacKrediManager,tasitKrediManager };
            List<ILoggerService> logs = new List<ILoggerService> {dataBaseLoggerService,smsLoggerService };
           
            basvuruManager.BasvuruYap(new IhtiyacKrediManager(), new List<ILoggerService> { new DataBaseLoggerService(), new SmsLoggerService() });
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler,logs);

        }
    }
}
