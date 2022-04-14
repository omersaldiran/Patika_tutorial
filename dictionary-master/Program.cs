// System Generic Dictionary
Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

kullanicilar.Add(1,"Ömer");
kullanicilar.Add(5,"Ahmet");
kullanicilar.Add(7,"Veysel");
kullanicilar.Add(12,"Burak");


// Elemanlara erişim
System.Console.WriteLine("Elemenlara erişim");
System.Console.WriteLine(kullanicilar[12]);
System.Console.WriteLine();
foreach (var item in kullanicilar)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine();

//Count
System.Console.WriteLine("Count metodu");
System.Console.WriteLine(kullanicilar.Count());
System.Console.WriteLine();

//Contains
System.Console.WriteLine(kullanicilar.ContainsKey(5));
System.Console.WriteLine(kullanicilar.ContainsValue("Ömer"));
System.Console.WriteLine();

//Remove
kullanicilar.Remove(12);
foreach (var item in kullanicilar)
{
    System.Console.WriteLine(item.Value);
}
System.Console.WriteLine();