
//tring kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";          //tek tek yazmak yerine array dizilerimi kullan 
//string kurs2 = "Proglamaya başlangıç için temel kurs";
//string kurs3 = "java";
//string kurs4 = "python";
//string kurs5 = "c++";

//Console.WriteLine(kurs1);
//Console.WriteLine(kurs2);
//Console.WriteLine(kurs3);
//Console.WriteLine(kurs4);
//Console.WriteLine(kurs5);


//array -dizi 

string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Proglamaya başlangıç için temel kurs", "java","pyhon","c++" };


for (int i = 0; i <kurslar.Length; i++)      //dizileri dolaşma
{

    Console.WriteLine(kurslar[i]);

}

Console.WriteLine("For bitti");

foreach (string kurs in kurslar)       //dizlieri dolaşma
{
 Console.WriteLine(kurs);
}


Console.WriteLine("sayfa sonu - footer");