// Implicit Conversion
System.Console.WriteLine("****Implicit Covertion****");

byte a = 3;
sbyte b = 30;
short c = 10;

int d = a + b + c;
Console.WriteLine("d: " + d);

long h = d;
Console.WriteLine("h : "+ h);

float i = h;
Console.WriteLine("i : " + i);

string e = "Ömer";
char f = 's';
object g = e + f + d;
Console.WriteLine("g : " + g);



// Explicit Conversion

System.Console.WriteLine("****Explicit Convertion****");
int x = 4;
byte y = (byte)x;
System.Console.WriteLine("y  " + y);

int z = 100;
byte t = (byte)z;
System.Console.WriteLine("t " + t);

float w = 10.3f;
byte v = (byte)w;
System.Console.WriteLine("v " + v);

// **** To String Methodu *****

System.Console.WriteLine("****To String Methodu******");

int xx = 6;
string yy = xx.ToString();
System.Console.WriteLine("yy :" + yy);

string zz = 12.5f.ToString();
System.Console.WriteLine("zz : " + zz);

// System.Convert
System.Console.WriteLine("****System.Convert*****");
string s1 = "10", s2="20";
int sayi1,sayi2;
int Toplam;

sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);
Toplam = sayi1+sayi2;
System.Console.WriteLine("Toplam : "+Toplam);