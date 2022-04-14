// See https://aka.ms/new-console-template for more information
int month = DateTime.Now.Month;

switch(month){
    case 1:
    System.Console.WriteLine("Ocak ayındayız.");
    break;
    case 2:
    System.Console.WriteLine("Şubat ayındayız.");
    break;
    case 3:
    System.Console.WriteLine("Mart ayındayız.");
    break;
    case 4:
    System.Console.WriteLine("Nisan ayındayız.");
    break;
    case 5:
    System.Console.WriteLine("Mayıs ayındayız.");
    break;
}

for(int i =0;i<10;i++){
    if(i%2==0)
        continue;
    System.Console.WriteLine("Tek sayılar : " + i);
}

System.Console.WriteLine("Toplanacak sayıları girin");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;
while(sayac<=sayi){
    toplam +=sayac;
    sayac++;

}

System.Console.WriteLine(toplam/sayi);


char character = 'a';
while(character<='z'){
    Console.Write(character);
    character++;
}

string[] arabalar = {"BMW","MB","Ford","Seat","Vw"};
foreach (var item in arabalar)
{
    System.Console.WriteLine(item);
} 