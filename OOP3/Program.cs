// See https://aka.ms/new-console-template for more information
using OOP3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager taksitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
ILoggerService fileLogerService = new FileLoggerService();

BasvuruManager basvuruManager  = new BasvuruManager();
basvuruManager.BasvuruYap(konutKrediManager, fileLogerService);

List<IKrediManager> krediler = new List<IKrediManager>() { };

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);



