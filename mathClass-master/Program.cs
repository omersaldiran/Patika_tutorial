// See https://aka.ms/new-console-template for more information
// Generic koleksiyonlar

using System.Collections;

List<int> sayiListesi = new List<int>();
sayiListesi.Add(34);
sayiListesi.Add(23);
sayiListesi.Add(3);
sayiListesi.Add(4);
sayiListesi.Add(65);
sayiListesi.Add(8);

List<String> renkListesi = new List<string>();
renkListesi.Add("Kırmızı");
renkListesi.Add("Mavi");
renkListesi.Add("Yeşil");
renkListesi.Add("Lacivert");

// İçeriği ekrana yazdırma Count
System.Console.WriteLine("Kaç eleman var?");
System.Console.WriteLine(sayiListesi.Count);
System.Console.WriteLine(renkListesi.Count);

System.Console.WriteLine();
System.Console.WriteLine("İçerikler");
foreach (var item in sayiListesi)
{
    System.Console.WriteLine(item); 
}

foreach (var item in renkListesi)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine();
System.Console.WriteLine("Yeni tip foreach");
sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
renkListesi.ForEach(renk => System.Console.WriteLine(renk));
System.Console.WriteLine();

//Listeden eleman çıkarma
System.Console.WriteLine("Listeden eleman çıkarma");
sayiListesi.Remove(4);
renkListesi.Remove("Yeşil");
sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
renkListesi.ForEach(renk => System.Console.WriteLine(renk));

System.Console.WriteLine();
sayiListesi.RemoveAt(0);
renkListesi.RemoveAt(0);
sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
renkListesi.ForEach(renk => System.Console.WriteLine(renk));

// Liste içinde arama yapma
System.Console.WriteLine("Liste içinde arama yapmak");
if(sayiListesi.Contains(8)){
    System.Console.WriteLine("Liste içinde 8 değeri bulundu");
}


System.Console.WriteLine("Eleman ile indexe erişmek");
Console.WriteLine(renkListesi.BinarySearch(item: "Mavi"));

//Diziyi List tipine  çevirmek

string[] hayvan = {"Kedi", "Köpek", "At"};
List<string> hayvanlar = new List<string>(hayvan);

//Tüm listesi temizle
hayvanlar.Clear();

// List de class tutmak

List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

Kullanicilar kullanici1 = new Kullanicilar();
kullanici1.Isim = "Ömer";
kullanici1.Soyisim = "Saldıran";
kullanici1.Yas = 30;

Kullanicilar kullanici2 = new Kullanicilar();
kullanici2.Isim = "Kadir";
kullanici2.Soyisim = "Saldıran";
kullanici2.Yas = 28;

kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);

List<Kullanicilar> yeniListe = new List<Kullanicilar>();

yeniListe.Add(new Kullanicilar(){
    Isim = "Zeynep",
    Soyisim = "Blabla",
    Yas = 20
});

foreach (var item in kullaniciListesi)
{
    System.Console.WriteLine("Kullanıcı adı : " + item.Isim);
    System.Console.WriteLine("Kullanıcı soyadı : " + item.Soyisim);
    System.Console.WriteLine("Kullanıcı yaşı : " + item.Yas);  
}

foreach (var item in yeniListe)
{
    System.Console.WriteLine("Kullanıcı adı : " + item.Isim);
    System.Console.WriteLine("Kullanıcı soyadı : " + item.Soyisim);
    System.Console.WriteLine("Kullanıcı yaşı : " + item.Yas);  
}

// ArrayList alıştırmaları
System.Console.WriteLine("******* ArrayList alıştırmaları ********");

ArrayList arrayList = new ArrayList();
arrayList.Add("Merhaba");
arrayList.Add(45);
arrayList.Add("Bu array list ne güzelmiş, her tipten eleman ekleniyor");
System.Console.WriteLine(arrayList[1]);
foreach (var item in arrayList)
{
    System.Console.WriteLine(item);    
}


System.Console.WriteLine("Birden fazla elemanı array liste ekleme AddRange");
arrayList.AddRange(renkListesi);
arrayList.AddRange(sayiListesi);
foreach (var item in arrayList)
{
    System.Console.WriteLine(item);
}

//Sort Array içinde farklı tipte eleman olmamalı sadece int32 olmalı
System.Console.WriteLine("******Sort******");
//arrayList.Sort();

System.Console.WriteLine("****Binary Search*****");
//arrayList.BinarySearch(3);

System.Console.WriteLine("*****Reverse******");
arrayList.Reverse();
foreach (var item in arrayList)
{
    System.Console.WriteLine(item);
}


//Clear
System.Console.WriteLine("Clear metodu");
arrayList.Clear();

foreach(var item in arrayList){
    System.Console.WriteLine(item);
}


public class Kullanicilar{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}