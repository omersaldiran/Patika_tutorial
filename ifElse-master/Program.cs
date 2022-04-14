// See https://aka.ms/new-console-template for more information
int mat,fizik,kimya,turkce,muzik,toplam,bolum;
        double ortalama;
    
        Console.WriteLine("Matematik Notunuz : ");
        mat = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Fizik Notunuz : ");
        fizik = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Kimya Notunuz : ");
        kimya = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Türkçe Notunuz : ");
        turkce = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Müzik Notunuz : ");
        muzik = Convert.ToInt32(Console.ReadLine());

        toplam = 0;
        bolum=0;

        if(mat<=100 && mat>=0){
            toplam+=mat;
            bolum++;
        }
        if(fizik<=100 && fizik>=0){
            toplam+=fizik;
            bolum++;
        }
        if(kimya<=100 && kimya>=0){
            toplam+=kimya;
            bolum++;
        }
        if(turkce<=100 && turkce>=0){
            toplam+=turkce;
            bolum++;
        }
        if(muzik<=100 && muzik>=0){
            toplam+=muzik;
            bolum++;
        }
        if (bolum>0){
            ortalama = toplam / bolum;
            Console.WriteLine("Ortalama not : " + ortalama);
            if (ortalama>=55){
                Console.WriteLine("Geçtiniz !");
            }
            else {
                Console.WriteLine("Kaldınız !");
            }
        }
