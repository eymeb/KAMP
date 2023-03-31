//type safety - tiğ güvenliği
//Do not repeat yourself - kendini tekrarlama
//değer tutucu, alias

string kategoriEtiketi = "Kategoriler";
int ogreciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirişYapmisMi = true;
double dolarDun = 7.55;
double dolarBugun = 7.55;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış butonu");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artış Butonu");
}
else
{
    Console.WriteLine("değişmedi butonu");
}



if (sistemeGirişYapmisMi == true)
{
  Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giriş yap butonu");
}


Console.WriteLine(kategoriEtiketi);

