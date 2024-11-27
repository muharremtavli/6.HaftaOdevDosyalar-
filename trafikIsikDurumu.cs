using System;
enum TrafikIsikDurumu
{
    Red,    // Kırmızı
    Yellow, // Sarı
    Green   // Yeşil
}

class TrafikIsigi
{
    public TrafikIsikDurumu Durum { get; set; }

    public string NeYapilmali()
    {
        switch (Durum)
        {
            case TrafikIsikDurumu.Red:
                return "Araçlar durmalı.";
            case TrafikIsikDurumu.Yellow:
                return "Araçlar durmaya hazırlanmalı.";
            case TrafikIsikDurumu.Green:
                return "Araçlar geçebilir.";
            default:
                return "Geçersiz durum.";
        }
    }
}

class Program
{
    static void Main()
    {
        // Trafik ışığı nesnesi oluşturma
        TrafikIsigi isik = new TrafikIsigi();

        // Durumu kırmızı olarak ayarla
        isik.Durum = TrafikIsikDurumu.Red;
        Console.WriteLine($"Durum: {isik.Durum}, Yapılması gereken: {isik.NeYapilmali()}");

        // Durumu sarı olarak ayarla
        isik.Durum = TrafikIsikDurumu.Yellow;
        Console.WriteLine($"Durum: {isik.Durum}, Yapılması gereken: {isik.NeYapilmali()}");

        // Durumu yeşil olarak ayarla
        isik.Durum = TrafikIsikDurumu.Green;
        Console.WriteLine($"Durum: {isik.Durum}, Yapılması gereken: {isik.NeYapilmali()}");
        Console.ReadLine();
    }
}