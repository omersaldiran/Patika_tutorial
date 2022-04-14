// Metodların kullanımı ile ilgli alıştırmalar

string veri = "Method kullanımı :)";
Method method = new Method();
method.ekranaYazdir(veri);
method.ekranaYazdir(999);

System.Console.WriteLine("İki sayı girin, birer adet arttırılıp toplanacaktır");
int sayi1;
int sayi2;
sayi1 = int.Parse(Console.ReadLine());
sayi2 = int.Parse(Console.ReadLine());
Console.WriteLine(method.ArttirVeTopla(sayi1,sayi2));

// Alt parametre örnekleri
System.Console.WriteLine("*****Alt parametre örnekleri***** ");
string sayi = "1999";
int outsayi;
bool sonuc = int.TryParse(sayi,out outsayi);
if(sonuc)
    System.Console.WriteLine("Çevrim başarılı");
else
    System.Console.WriteLine("Çevrim başarısız");


method.Topla(4,5,out int toplamSonuc);
System.Console.WriteLine(toplamSonuc);


// Recursive metodlar
System.Console.WriteLine("*****Recursive metodlar*****");
System.Console.WriteLine(method.Ustel(2,3));


//Extention metodlar
System.Console.WriteLine("*****Extention metodlar****");
string ifade = "Ömer Saldiran";
Console.WriteLine(ifade.CheckSpaces());

System.Console.WriteLine("String içindeki boşlukların silinmesi");
Console.WriteLine(ifade.RemoveWhiteSpaces());
System.Console.WriteLine("String ifadenin büyük harfe dönüştürülmesi");
Console.WriteLine(ifade.MakeUpperCase());
System.Console.WriteLine("String ifadenin küçük harfe dönüştürülmesi");
Console.WriteLine(ifade.MakeLowerCase());
int[] dizi1 = {4,7,12,66,32,2,98,3,1};

System.Console.WriteLine("İnt dizinin sıralanması");
dizi1.SortArray();
foreach (var item in dizi1)
{
    System.Console.WriteLine(item);
}

class Method{
    public void ekranaYazdir(string yazi){
        System.Console.WriteLine(yazi);
    }

    public void ekranaYazdir(int yazi){
        System.Console.WriteLine(yazi);
    }

    public int ArttirVeTopla(int deger1, int deger2){
            deger1 += 1;
            deger2 += 1;

            return deger1+deger2;
    }

    public void Topla(int a, int b, out int toplam){
        toplam = a+b;
    }

    public int Ustel(int sayi, int üs){
        if(üs<2)
            return sayi;
        return Ustel(sayi,üs-1)*sayi;
    }
}

public static class Extention{
    public static bool CheckSpaces(this string param){
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param){
        string[] dizi = param.Split();
        return string.Join("",dizi);
       
    }

    public static string MakeUpperCase(this string param){
        return param.ToUpper();
    }

    public static string MakeLowerCase(this string param){
        return param.ToLower();
    }

    public static int[] SortArray(this int[] param){
        Array.Sort(param);
        return param;
    }
}
