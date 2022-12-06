// See https://aka.ms/new-console-template for more information
using Metotlar;

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 10;
urun1.Aciklama = "cok iyi elma";
urun1.Kalan = 2;

Urun urun2 = new Urun();
urun2.Adi = "kerem";
urun2.Fiyati = 23;
urun2.Aciklama = "gusel";

Urun[] urunler = new Urun[] { urun1, urun2 };
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine("************************");
}
Console.WriteLine("----------Metotlar-----------");
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("elma", "gusel", 14);
