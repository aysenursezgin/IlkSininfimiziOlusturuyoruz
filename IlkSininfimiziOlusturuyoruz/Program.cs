
using IlkSininfimiziOlusturuyoruz;


// egitmen ve ogrencileri tanimliyoruz

Person egitmen1 = new Person()
{
    Ad = "Hatice",
    Soyad = "Ekşi",
    DogumTarihi = "06,06,1996"
};

Person egitmen2 = new Person()
{
    Ad = "Kübra",
    Soyad = "Ocaktar",
    DogumTarihi = "24,04,1995"
};

Person ogrenci1 = new Person()
{
    Ad = "Ayşenur",
    Soyad = "Sezgin",
    DogumTarihi = "01,04,1994"
};

Person ogrenci2 = new Person()
{
    Ad = "Fatih",
    Soyad = "Sezgin",
    DogumTarihi = "03,04,1996"
};

// Konsol ekranına yazdırıyoruz

Console.WriteLine(egitmen1.Ad);
Console.WriteLine(egitmen1.Soyad);
Console.WriteLine(egitmen1.DogumTarihi);
Console.WriteLine("---------------------------------------------");

Console.WriteLine(egitmen2.Ad);
Console.WriteLine(egitmen2.Soyad);
Console.WriteLine(egitmen2.DogumTarihi);
Console.WriteLine("---------------------------------------------");

Console.WriteLine(ogrenci1.Ad);
Console.WriteLine(ogrenci1.Soyad);
Console.WriteLine(ogrenci1.DogumTarihi);
Console.WriteLine("---------------------------------------------");

Console.WriteLine(ogrenci2.Ad);
Console.WriteLine(ogrenci2.Soyad);
Console.WriteLine(ogrenci2.DogumTarihi);
Console.WriteLine("---------------------------------------------");