using System;

class Program
{
    static void Main()
    {
        // İki tarih tanımlama
        DateTime tarih1 = new DateTime(2023, 1, 1);
        DateTime tarih2 = new DateTime(2024, 11, 26);

        // Gün cinsinden fark
        int gunFarki = Fark(tarih1, tarih2);
        Console.WriteLine("Gün cinsinden fark: " + gunFarki + " gün");

        // Saat cinsinden fark
        double saatFarki = Fark(tarih1, tarih2, true);
        Console.WriteLine("Saat cinsinden fark: " + saatFarki + " saat");

        // Yıl, ay ve gün cinsinden fark
        (object yilFarki, object ayFarki, object gunFarkiAy) = Fark(tarih1, tarih2, false);
        Console.WriteLine($"Yıl: {yilFarki}, Ay: {ayFarki}, Gün: {gunFarkiAy}");
        Console.ReadLine();
    }

    // İki tarih arasındaki farkı gün cinsinden döndürme
    static int Fark(DateTime tarih1, DateTime tarih2)
    {
        return (tarih2 - tarih1).Days;
    }

    // İki tarih arasındaki farkı saat cinsinden döndürme
    static double Fark(DateTime tarih1, DateTime tarih2, bool saat)
    {
        return (tarih2 - tarih1).TotalHours;
    }

    // İki tarih arasındaki farkı yıl, ay ve gün cinsinden döndürme
    static (int, int, int) Fark(DateTime tarih1, DateTime tarih2, bool ay)
    {
        int yilFarki = tarih2.Year - tarih1.Year;
        int ayFarki = tarih2.Month - tarih1.Month;
        int gunFarki = tarih2.Day - tarih1.Day;

        // Eğer gün negatifse, bir ay çıkart ve günleri düzelt
        if (gunFarki < 0)
        {
            ayFarki--;
            gunFarki += DateTime.DaysInMonth(tarih2.Year, tarih2.Month - 1);
        }

        // Eğer ay negatifse, bir yıl çıkart ve ayları düzelt
        if (ayFarki < 0)
        {
            yilFarki--;
            ayFarki += 12;
        }

        return (yilFarki, ayFarki, gunFarki);
    }
}