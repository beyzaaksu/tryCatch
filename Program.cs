// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine("Bir sayi giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girdiğiniz sayi:" + sayi);
}
catch (Exception ex)
{
    Console.WriteLine("Hata:" + ex.Message.ToString());
}
finally
{
    Console.WriteLine("İşlem Tamamlandı!");
}

try
{
    int a = int.Parse("-200000000000000");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex);
    Console.WriteLine("Null değer girdiniz");

}
catch (FormatException ex)
{
    Console.WriteLine(ex);
    Console.WriteLine("Veri tipi uyuşmuyor!");
}
catch (OverflowException ex)
{
    Console.WriteLine(ex);
    Console.WriteLine("Çok büyük ya da çok küçük değer girdiniz!");
}

finally
{
    Console.WriteLine("İşlem başarıyla tamamlandı!");
}