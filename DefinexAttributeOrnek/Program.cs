// See https://aka.ms/new-console-template for more information
using DefinexAttributeOrnek;

Console.WriteLine("Hello, World!");

Ogrenci ogrenci = new Ogrenci();
ogrenci.Adi = "ibrahim";
ogrenci.Soyadi = "gökyar";
ogrenci.Bolum = "yazılım";

if (!ZorunluAlanAttribute.Dogrula(ogrenci))
{
    Console.WriteLine("Öğrenci bilgileri doğrulamadan geçemedi!");
}
else
{
    Console.WriteLine("form başarılı");
}

