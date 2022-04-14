// Konsola çift sayıları yazdır.
Console.WriteLine("Bir adet pozitif sayı girin :");
int sayi = int.Parse(Console.ReadLine());
System.Console.WriteLine(sayi + " adet sayı giriniz.");
int[] dizi = new int[sayi];
for (int i = 0; i < dizi.Length; i++)
{
    dizi[i]=int.Parse(Console.ReadLine());
}

foreach (var item in dizi)
{
    if(item%2==0)
        System.Console.WriteLine("Çift sayılar : " +item);
}

//İki sayı al, ikinciye bölünebilmeyi sorgula
System.Console.WriteLine("*******İki sayı al, ikinciye bölünebilmeyi sorgula*******");
System.Console.WriteLine("İki adet pozitif sayı giriniz : ");
int sayi1 = int.Parse(Console.ReadLine());
int sayi2 = int.Parse(Console.ReadLine());
System.Console.WriteLine(sayi1 + " tane pozitif sayı giriniz:");
int[] dizi2 = new int[sayi1];
for (int i = 0; i < dizi2.Length; i++)
{
    dizi2[i]=int.Parse(Console.ReadLine());
}
foreach (var item in dizi2)
{
    if(item%sayi2==0)
        System.Console.WriteLine("Tam bölünen sayı : " + item);
}

//String ifade alan dizi
System.Console.WriteLine("********String ifade alan dizi********");
System.Console.WriteLine("Bir pozitif sayı girin:");
int sayi3 = int.Parse(Console.ReadLine());
System.Console.WriteLine(sayi3 + " tane kelime girin:");
string[] dizi3 = new string[sayi3];
for (int i = 0; i < sayi3; i++)
{
    dizi3[i] = Console.ReadLine();
}
Array.Reverse(dizi3);
foreach (var item in dizi3)
{
    System.Console.WriteLine(item);
}

//Kelima ayırma
System.Console.WriteLine("Kelime ayırma alıştırması");
System.Console.WriteLine("Bir adet cümle yazın:");
string cumle = Console.ReadLine();
string[] dizi4 = cumle.Split(" ");
System.Console.WriteLine("Cümledeki kelime sayısı : " + dizi4.Length);
string cumle2 = cumle.Replace(" ","");
System.Console.WriteLine("Cümledeki harf sayısı : " + cumle2.Length);