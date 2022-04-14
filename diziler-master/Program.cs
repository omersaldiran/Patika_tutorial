// Döngülerle dizi kullanımı

Console.WriteLine("Lütfen dizi uzunluğunu giriniz :");
int diziUzunlugu = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[diziUzunlugu];

for (int i = 0; i < diziUzunlugu; i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz :", i+1);
    sayiDizisi[i]=int.Parse(Console.ReadLine());
}

double toplam = 0;
foreach (var item in sayiDizisi)
{
    toplam+=item;
}

Console.WriteLine("Ortalama " + toplam/diziUzunlugu);

