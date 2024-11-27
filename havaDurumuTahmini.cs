using System;

enum HavaDurumu
{
    Sunny,  // Güneşli
    Rainy,  // Yağmurlu
    Cloudy, // Bulutlu
    Stormy  // Fırtınalı
}

class HavaDurumuTahmini
{
    public HavaDurumu Durum { get; set; }

    public string TavsiyeVer()
    {
        switch (Durum)
        {
            case HavaDurumu.Sunny:
                return "Güneşli bir gün! Dışarıda vakit geçirin.";
            case HavaDurumu.Rainy:
                return "Yağmurlu! Şemsiye almayı unutmayın.";
            case HavaDurumu.Cloudy:
                return "Bulutlu! Hava bir anda değişebilir, hazırlıklı olun.";
            case HavaDurumu.Stormy:
                return "Fırtınalı! Dışarı çıkmaktan kaçının.";
            default:
                return "Geçersiz hava durumu.";
        }
    }
}

class Program
{
    static void Main()
    {
        // Hava durumu tahmini nesnesi oluşturma
        HavaDurumuTahmini tahmin = new HavaDurumuTahmini();

        // Durumu güneşli olarak ayarlama
        tahmin.Durum = HavaDurumu.Sunny;
        Console.WriteLine($"Durum: {tahmin.Durum}, Tavsiye: {tahmin.TavsiyeVer()}");

        // Durumu yağmurlu olarak ayarlama
        tahmin.Durum = HavaDurumu.Rainy;
        Console.WriteLine($"Durum: {tahmin.Durum}, Tavsiye: {tahmin.TavsiyeVer()}");

        // Durumu bulutlu olarak ayarlama
        tahmin.Durum = HavaDurumu.Cloudy;
        Console.WriteLine($"Durum: {tahmin.Durum}, Tavsiye: {tahmin.TavsiyeVer()}");

        // Durumu fırtınalı olarak ayarlama
        tahmin.Durum = HavaDurumu.Stormy;
        Console.WriteLine($"Durum: {tahmin.Durum}, Tavsiye: {tahmin.TavsiyeVer()}");
        Console.ReadLine();
    }
}