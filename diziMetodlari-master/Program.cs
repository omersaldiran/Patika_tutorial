// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("*****Diziler*****");

string[] renkler = new string[5];

string[] hayvanlar = {"Kedi","Köpek","Muhabbet kuşu","Balık"};

int[] dizi;
dizi = new int[2];

renkler[0] = "Siyah";

System.Console.WriteLine("****Sayı dizisi metodları****");
int[] sayilar = {3,55,34,2,9,10};

System.Console.WriteLine("Sırasız sayı dizisi");
foreach (var item in sayilar)
{
    System.Console.WriteLine(item);
}

Array.Sort(sayilar);

System.Console.WriteLine("Sıralı sayı dizisi");
foreach (var item in sayilar)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("Array Clear özelliği");
Array.Clear(sayilar,2,2);
foreach (var item in sayilar)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("Reverse özelliği");
Array.Reverse(sayilar);
foreach (var item in sayilar)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("Index of özelliği");
System.Console.WriteLine(Array.IndexOf(sayilar,55));

System.Console.WriteLine("resize özelliği");
Array.Resize<int>(ref sayilar,10);
foreach (var item in sayilar)
{
    System.Console.WriteLine(item);
}


