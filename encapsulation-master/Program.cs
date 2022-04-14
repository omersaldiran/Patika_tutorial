Ogrenci ogrenci1 = new Ogrenci();
ogrenci1.Isim = "Ömer";
ogrenci1.Soyisim = "Saldıran";
ogrenci1.Sinif = 1;
ogrenci1.OgrenciNo = 34; 
ogrenci1.OgrenciBilgileri();

Ogrenci ogrenci2 = new Ogrenci("Kadir","Saldıran",44,5);
ogrenci2.OgrenciBilgileri();
ogrenci2.SinifDusur();
ogrenci2.SinifDusur();
ogrenci2.SinifDusur();
ogrenci2.SinifDusur();
ogrenci2.SinifDusur();
ogrenci2.OgrenciBilgileri();
class Ogrenci{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;
    private static string okulAdi;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif { 
        get => sinif; 
        set{
            if(value < 1){
                System.Console.WriteLine("Sınıf en az 1 olabilir !");
            }
            else
                sinif = value;
            } 
        }

    public static string OkulAdi { get => okulAdi; }

    public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = ısim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public Ogrenci(){}

    static Ogrenci(){
        okulAdi = "İstanbul Lisesi";
    }

    public void OgrenciBilgileri(){
        System.Console.WriteLine("****** Öğrenci Bilgileri ******");
        System.Console.WriteLine("Öğrenci İsmi     : {0}",this.Isim);
        System.Console.WriteLine("Öğrenci Soyismi  : {0}",this.Soyisim);
        System.Console.WriteLine("Öğrenci Numarası : {0}",this.OgrenciNo);
        System.Console.WriteLine("Öğrenci Sınıfı   : {0}",this.Sinif );
    }

    public void SinifAtlat(){
        this.Sinif += 1;
    }

    public void SinifDusur(){
            this.Sinif-=1;
    }
}