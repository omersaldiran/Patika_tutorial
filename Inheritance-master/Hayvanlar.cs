public class Hayvanlar:Canlilar{
    protected void Adaptasyon(){
        System.Console.WriteLine("Hayvanlar adaptasyon yapabilir.");
    }

    public override void UyaranlaraTepki()
    {
        base.UyaranlaraTepki();
        System.Console.WriteLine("Hayvanlar temasa tepki verir.");
    }
}

    public class Surungenler:Hayvanlar{
        public Surungenler(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void SurungenlerHareket(){
            System.Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
        }
    }

    public class Kuslar:Hayvanlar{
        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void KuslarHareket(){
            System.Console.WriteLine("Kuşlar uçarak hareket ederler.");
        }
    }
