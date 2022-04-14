
Calisan calisan2 = new Calisan("ahmet","veli",34,"Teknik Servis");
Calisan calisan3 = new Calisan("Sefa","veli");
Calisan calisan1 = new Calisan();
calisan1.adi="Ömer";
calisan1.soyadi="Saldıran";
calisan1.no=1;
calisan1.departman="IT";
calisan1.EkranaYazdir();
calisan2.EkranaYazdir();
calisan3.EkranaYazdir();



class Calisan
{
    public string adi;
    public string soyadi;
    public int no;
    public string departman;

    public Calisan(string adi, string soyadi, int no, string departman){
        this.adi = adi;
        this.soyadi = soyadi;
        this.no = no;
        this.departman = departman;
    }
    public Calisan(string adi, string soyadi){
        this.adi = adi;
        this.soyadi = soyadi; 
    }
    public Calisan(){}

    public void EkranaYazdir(){
        System.Console.WriteLine("Çalışanın Adı : {0}",adi);
        System.Console.WriteLine("Çalışanın Soyadı : {0}",soyadi);
        System.Console.WriteLine("Çalışanın Numarası : {0}",no);
        System.Console.WriteLine("Çalışanın Departmanı : {0}",departman);
        System.Console.WriteLine("***********");
    }
}
