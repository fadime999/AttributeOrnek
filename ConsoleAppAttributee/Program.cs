using DefinexAttributeOrnek; // Class Library


Ogrenci ogrenci = new Ogrenci();
ogrenci.Adi = "Ali";
ogrenci.Soyadi = ""; // Boş bıraktık, hata verecek
ogrenci.Bolum = "Bilgisayar Mühendisliği";

bool sonuc = ZorunluAlanAttribute.Dogrula(ogrenci);

if (!sonuc)
{
    Console.WriteLine("Doğrulama Hatası: Zorunlu alanlar boş bırakılamaz!");
}
else
{
    Console.WriteLine("Form başarılı!");
}