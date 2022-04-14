// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Dikdortgen dortgen = new Dikdortgen();
dortgen.kisaKenar = 4;
dortgen.uzunKenar = 2;
System.Console.WriteLine("Alan : " + dortgen.AlanHesapla());

DikdortgenStruct yeni = new DikdortgenStruct();

yeni.kisaKenar = 3;
yeni.uzunKenar = 5;
System.Console.WriteLine("Alan Struct : "+yeni.AlanHesapla());

System.Console.WriteLine(Gunler.Cumartesi);

int sicaklik = 42;
if(sicaklik <= (int)HavaDurumu.Normal){
    System.Console.WriteLine("Dışarı çıkma, hava soğuk");
}
else if (sicaklik <= (int)HavaDurumu.Sicak){
    System.Console.WriteLine("Hadi dışarı");
}
else if (sicaklik >= (int)HavaDurumu.CokSicak){
    System.Console.WriteLine("Çok sıcak, otur evinde bea!");
}


class Dikdortgen{
    public int kisaKenar;
    public int uzunKenar;

    public long AlanHesapla(){
        return this.kisaKenar * this.uzunKenar;
    }
}

struct DikdortgenStruct
{
    public int kisaKenar;
    public int uzunKenar;

    public long AlanHesapla(){
        return this.kisaKenar * this.uzunKenar;
    }
}

enum Gunler{
    Pazartesi = 1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}

enum HavaDurumu{
    Soguk = 5,
    Normal = 20,
    Sicak = 25,
    CokSicak=40
}