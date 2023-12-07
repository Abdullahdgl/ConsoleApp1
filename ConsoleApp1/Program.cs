// See https://aka.ms/new-console-template for more information

using DictonaryMyList;

Urunler urun1 = new Urunler();
urun1.UrunAdi = "A URUN";
urun1.UrunId = 1;
urun1.UrunBilgileri = "çinden geldi";
urun1.SiparisTarihi = DateTime.UtcNow;

Urunler urun2 = new Urunler();
urun2.UrunAdi = "B URUN";
urun2.UrunId = 2;
urun2.UrunBilgileri = "izmir geldi";
urun2.SiparisTarihi = DateTime.UtcNow;

Urunler urun3 = new Urunler();
urun3.UrunAdi = "C URUN";
urun3.UrunId = 3;
urun3.UrunBilgileri = "Malatyadan geldi";
urun3.SiparisTarihi = DateTime.UtcNow;


Urunler urun4 = new Urunler();
urun4.UrunAdi = "D URUN";
urun4.UrunId = 4;
urun4.UrunBilgileri = "Ardahan geldi";
urun4.SiparisTarihi = DateTime.UtcNow;

Urunler[] urunListesi = new Urunler[] { urun1, urun2,urun3,urun4 };





foreachMethodu(urunListesi);
Console.WriteLine("Burdan sonra for döngüsü mevcuttur.");


ForDongusuile(urunListesi);

Console.WriteLine("------------------------------------------------------------------");

foreach (Urunler urun in urunListesi)
{
    Console.WriteLine(urun.UrunId + " " + urun.UrunAdi);
  
    
}

Console.WriteLine( "******Metotlar");
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle(urun3);
sepetManager.Ekle(urun4);

DortiSlem dortiSlem = new DortiSlem();
int tekrartopla = dortiSlem.topla(3, 5);
Console.WriteLine(tekrartopla*5*10);
dortiSlem.topla2(1, 3);

Console.WriteLine("******Generic Classlar*****");

Generics<string> generics = new Generics<string>();
generics.Add("abdullah");

Console.WriteLine("DistonaryMyLİSTEMMMMM");


DictonaryMyList<int, string> dictonaryMyList = new DictonaryMyList<int, string>();
dictonaryMyList.Add(1, "Abdullah");
dictonaryMyList.Add(2, "Mehmet");
dictonaryMyList.Add(3, "Elif");






static void foreachMethodu(Urunler[] urunListesi)
{
    foreach (var urun in urunListesi)
    {
        Console.WriteLine(urun.UrunId + " " + urun.UrunBilgileri + " " + urun.SiparisTarihi);
    }
}




static void ForDongusuile(Urunler[] urunListesi)
{
    for (int i = 0; i < urunListesi.Length; i++)
    {
        Console.WriteLine(urunListesi[i].UrunId + " : " + urunListesi[i].UrunAdi);
    }
}