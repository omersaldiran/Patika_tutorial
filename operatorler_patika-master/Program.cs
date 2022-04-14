// See https://aka.ms/new-console-template for more information

// Atama ve işlemli atama

int x=3;

x+=5;
System.Console.WriteLine(x);
x*=2;
System.Console.WriteLine(x);

// Mantıksal operatörler

bool isSuccess = true;
bool isCompleted = false;

if(isSuccess && isCompleted){
    System.Console.WriteLine("Perfect");
}

if(isSuccess || isCompleted){
    System.Console.WriteLine("Great");
}

if(isSuccess && !isCompleted){
    System.Console.WriteLine("Fine");
}

// İlişkisel operatörler

int a = 3;
int b = 4;
bool sonuc = a<b;
System.Console.WriteLine(sonuc);
sonuc = a>b;
System.Console.WriteLine(sonuc);
sonuc = a<=b;
System.Console.WriteLine(sonuc);
sonuc = a>=b;
System.Console.WriteLine(sonuc);
sonuc = a==b;
System.Console.WriteLine(sonuc);
sonuc = a!=b;
System.Console.WriteLine(sonuc);