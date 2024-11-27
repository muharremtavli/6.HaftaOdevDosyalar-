using System;

class Program
{
    static void Main()
    {
        // Karenin alanını hesaplama
        double kareAlani = Alan(5);
        Console.WriteLine("Karenin alanı: " + kareAlani);

        // Dikdörtgenin alanını hesaplama
        double dikdortgenAlani = Alan(4, 6);
        Console.WriteLine("Dikdörtgenin alanı: " + dikdortgenAlani);

        // Dairenin alanını hesaplama
        double daireAlani = Alan(3);
        Console.WriteLine("Dairenin alanı: " + daireAlani);
        Console.ReadLine();
    }

    // Karenin alanını hesaplama
    static double Alan(double kenar)
    {
        return kenar * kenar; // Alan = kenar²
    }

    // Dikdörtgenin alanını hesaplama
    static double Alan(double uzunKenar, double kisaKenar)
    {
        return uzunKenar * kisaKenar; // Alan = uzunKenar * kisaKenar
    }

    // Dairenin alanını hesaplama
    static double Alan(int yaricap)
    {
        return Math.PI * yaricap * yaricap; // Alan = π * yarıçap²
    }
}