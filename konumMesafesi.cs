using System;

struct GPSKonumu
{
    public double Latitude { get; set; }   // Enlem
    public double Longitude { get; set; }  // Boylam

    // İki GPS konumu arasındaki mesafeyi kilometre olarak hesaplayan metot
    public double MesafeHesapla(GPSKonumu diğerKonum)
    {
        const double R = 6371; // Dünya'nın yarıçapı (km)

        // Haversine formülü
        double dLat = DegreleriRadyana(oturumu.Latitude - diğerKonum.Latitude);
        double dLon = DegreleriRadyana(oturumu.Longitude - diğerKonum.Longitude);

        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                   Math.Cos(DegreleriRadyana(oturumu.Latitude)) * Math.Cos(DegreleriRadyana(başkaKonum.Latitude)) *
                   Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return R * c; // Mesafe (km)
    }

    // Dereceleri radyana çeviren metot
    private static double DegreleriRadyana(double derece)
    {
        return derece * (Math.PI / 180);
    }
}

class Program
{
    static void Main()
    {
        // İki GPS konumu oluşturma
        GPSKonumu konum1 = new GPSKonumu { Latitude = 40.7128, Longitude = -74.0060 }; // New York
        GPSKonumu konum2 = new GPSKonumu { Latitude = 34.0522, Longitude = -118.2437 }; // Los Angeles

        // Mesafeyi hesaplama
        double mesafe = konum1.MesafeHesapla(konum2);
        Console.WriteLine($"New York ve Los Angeles arasındaki mesafe: {mesafe:F2} km");
        Console.ReadLine();
    }
}