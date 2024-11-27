using System;
struct Zaman
{
    private int hour;
    private int minute;
    public int Hour
    {
        get { return hour; }
        set
        {
            // Geçersiz saat kontrolü
            if (value < 0 || value >= 24)
            {
                hour = 0; // Geçersizse 0 yap
            }
            else
            {
                hour = value;
            }
        }
    }
    public int Minute
    {
        get { return minute; }
        set
        {
            // Geçersiz dakika kontrolü
            if (value < 0 || value >= 60)
            {
                minute = 0; // Geçersizse 0 yap
            }
            else
            {
                minute = value;
            }
        }
    }
    // Toplam dakikayı döndüren metot
    public int ToplamDakika()
    {
        return (Hour * 60) + Minute;
    }
    // İki zaman nesnesi arasındaki farkı dakika olarak hesaplayan metot
    public static int Fark(Zaman zaman1, Zaman zaman2)
    {
        int toplamDakika1 = zaman1.ToplamDakika();
        int toplamDakika2 = zaman2.ToplamDakika();
        return Math.Abs(toplamDakika1 - toplamDakika2);
    }
}
class Program
{
    static void Main()
    {
        // Zaman nesneleri oluşturma
        Zaman zaman1 = new Zaman();
        zaman1.Hour = 14;    // 14:00
        zaman1.Minute = 30;  // 14:30

        Zaman zaman2 = new Zaman();
        zaman2.Hour = 16;    // 16:00
        zaman2.Minute = 45;  // 16:45

        // Toplam dakikaları yazdırma
        Console.WriteLine($"Zaman 1: {zaman1.Hour}:{zaman1.Minute} => Toplam dakika: {zaman1.ToplamDakika()}");
        Console.WriteLine($"Zaman 2: {zaman2.Hour}:{zaman2.Minute} => Toplam dakika: {zaman2.ToplamDakika()}");

        // İki zaman arasındaki farkı hesaplama
        int fark = Zaman.Fark(zaman1, zaman2);
        Console.WriteLine($"Zamanlar arasındaki fark: {fark} dakika");

        // Geçersiz zaman örneği
        Zaman zaman3 = new Zaman();
        zaman3.Hour = 25;    // Geçersiz saat
        zaman3.Minute = 70;  // Geçersiz dakika
        Console.WriteLine($"Zaman 3: {zaman3.Hour}:{zaman3.Minute} => Toplam dakika: {zaman3.ToplamDakika()}");
        Console.ReadLine();
    }
}