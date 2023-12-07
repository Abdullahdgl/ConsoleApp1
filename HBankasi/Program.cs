// See https://aka.ms/new-console-template for more information
using HBankasi;



IKrediManager tasitKrediManager = new TasitKrediManager();
//tasitKrediManager.Hesapla();

IKrediManager konutKrediManager = new KonutKrediManager();
//konutKrediManager.Hesapla();

IKrediManager esnafKrediManager = new EsnafKredisiManager();
//esnafKrediManager.Hesapla();

ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();
ILoggerService smsLoggerService = new SmsLoggerService();

List<ILoggerService> loggers = new List<ILoggerService>() {new FileLoggerService(), new SmsLoggerService()};


//Başvuru Yönetim Paneli kodları.

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(esnafKrediManager,loggers);



List<IKrediManager> krediler = new List<IKrediManager>() {tasitKrediManager};

//basvuruManager.KrediBilgilendirmesiYap(krediler);



