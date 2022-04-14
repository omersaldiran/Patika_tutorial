// String sınıfı metodları
string degisken = "Merhaba, deneme örnek stringi";
//Lenght
System.Console.WriteLine("String'in uzunluğu " + degisken.Length);

//ToUpper , ToLower
System.Console.WriteLine(degisken.ToUpper() + " " + degisken.ToLower());

//Concat 
System.Console.WriteLine(String.Concat(degisken," * Bu kısım sonradan eklendi."));

//Compare CompareTo
System.Console.WriteLine(degisken.CompareTo("mesela nasıl?"));

//Contains
System.Console.WriteLine(degisken.Contains("Merhaba"));
System.Console.WriteLine(degisken.StartsWith('M'));
System.Console.WriteLine(degisken.EndsWith('s'));

//Indexof
System.Console.WriteLine(degisken.IndexOf("deneme"));
System.Console.WriteLine(degisken.LastIndexOf('i'));

//Insert
System.Console.WriteLine(degisken.Insert(0,"Hi, "));

//Padleft, Padright
System.Console.WriteLine("Sonradan eklenen "+ degisken.PadLeft(40));

//Substring
System.Console.WriteLine(degisken.Substring(5));