// See https://aka.ms/new-console-template for more information

using System.Collections;

static int Check_Prime(int number)  {
     if(number == 1)
            return 0;
    for (int i = 2; i <= number; i++) {
            if(number == 1){
                return 0;
            }
            else if(number > 1 && number % i == 0 && i!=number) {
               return 0;
            }
       }
    return 1;
}

ArrayList asalListe = new ArrayList();
ArrayList normalListe = new ArrayList();
for (int i = 0; i<20;i++){
    int girdi = int.Parse(Console.ReadLine());
    if(girdi>= 0){
    if(Check_Prime(girdi)==1){
        asalListe.Add(girdi);
    }
    else if(Check_Prime(girdi)==0){
        normalListe.Add(girdi);
    }
    }
}
asalListe.Sort();
normalListe.Sort();
int toplamAsal=0;
int toplamNormal=0;
foreach (var item in asalListe)
{
    System.Console.WriteLine("Asal : " + item);
    toplamAsal+=(int)item;
}
foreach (var item in normalListe)
{
    System.Console.WriteLine("Normal : "+item);
    toplamNormal+=(int)item;
}

System.Console.WriteLine("Asal sayı listesinde " + asalListe.Count + " eleman bulunur.");
System.Console.WriteLine("Normal sayı listesinde " + normalListe.Count + " eleman bulunur.");
System.Console.WriteLine("Asal sayı listesinin ortalaması : " + toplamAsal/asalListe.Count);
System.Console.WriteLine("Normal sayı listesinin ortalaması : " + toplamNormal/normalListe.Count);