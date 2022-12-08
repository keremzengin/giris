// See https://aka.ms/new-console-template for more information
using Oop2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.MusteriNo = "1123123";

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.MusteriNo = "123123124";

Customer musteri3 = new GercekMusteri();
Customer musteri4 = new TuzelMusteri();
CustomerManager musteriManager = new CustomerManager();
musteriManager.Add(musteri1);

