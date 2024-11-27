using System;

enum CalisanRol
{
    Manager,  // Yönetici
    Developer, // Geliştirici
    Designer,  // Tasarımcı
    Tester     // Testçi
}

class Calisan
{
    public CalisanRol Rol { get; set; }

    // Maaşı hesaplayan metot
    public decimal MaasHesapla()
    {
        switch (Rol)
        {
            case CalisanRol.Manager:
                return 8000m; // Yönetici maaşı
            case CalisanRol.Developer:
                return 6000m; // Geliştirici maaşı
            case CalisanRol.Designer:
                return 5000m; // Tasarımcı maaşı
            case CalisanRol.Tester:
                return 4000m; // Testçi maaşı
            default:
                throw new ArgumentOutOfRangeException("Geçersiz rol.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Çalışan nesneleri oluşturma
        Calisan calisan1 = new Calisan { Rol = CalisanRol.Manager };
        Calisan calisan2 = new Calisan { Rol = CalisanRol.Developer };
        Calisan calisan3 = new Calisan { Rol = CalisanRol.Designer };
        Calisan calisan4 = new Calisan { Rol = CalisanRol.Tester };

        // Maaşları hesaplama ve yazdırma
        Console.WriteLine($"Yönetici maaşı: {calisan1.MaasHesapla()} TL");
        Console.WriteLine($"Geliştirici maaşı: {calisan2.MaasHesapla()} TL");
        Console.WriteLine($"Tasarımcı maaşı: {calisan3.MaasHesapla()} TL");
        Console.WriteLine($"Testçi maaşı: {calisan4.MaasHesapla()} TL");
        Console.ReadLine();
    }
}