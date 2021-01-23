using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfaceleri birbirinin alternatifi olan ama kod içeriği farklı olan durumlar için kullanırız.

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new TasitKrediManager(), new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService()}); 

            List<IKrediManager> krediler = new List<IKrediManager>()
            {
                ihtiyacKrediManager,
                tasitKrediManager
            };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            Console.ReadLine();
        }
    }
}
