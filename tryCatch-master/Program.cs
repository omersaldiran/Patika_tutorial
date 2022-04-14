try
{
    System.Console.WriteLine("Bir sayı giriniz : ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);   
}
catch(Exception ex){
    System.Console.WriteLine("Hata : " + ex.Message.ToString());
}
finally
{
    System.Console.WriteLine("İşlem tamamlandı.");
}


try
{
    //int a = int.Parse(null);
    //int a = int.Parse("text");
    int a = int.Parse("-200000000000");

}
catch (ArgumentNullException ex)
{
    System.Console.WriteLine("Boş değer girdiniz : ");
    System.Console.WriteLine(ex);

}
catch(FormatException ex){
    System.Console.WriteLine("Boş değer girdiniz : ");
    System.Console.WriteLine(ex);
}
catch(OverflowException ex){
    System.Console.WriteLine("Çok küçük veya büyük bir değer girdiniz : ");
    System.Console.WriteLine(ex);
}