using System;
class Program
{
    static void Main()
    {
        // İki tam sayıyı toplama
        int sum1 = Topla(5, 10);
        Console.WriteLine("İki sayının toplamı: " + sum1);

        // Üç tam sayıyı toplama
        int sum2 = Topla(1, 2, 3);
        Console.WriteLine("Üç sayının toplamı: " + sum2);

        // Dizi (array) tam sayıları toplama
        int[] sayilar = { 4, 5, 6, 7 };
        int sum3 = Topla(sayilar);
        Console.WriteLine("Dizi elemanlarının toplamı: " + sum3);
        Console.ReadLine();
    }

    // İki tam sayıyı toplama
    static int Topla(int a, int b)
    {
        return a + b;
    }

    // Üç tam sayıyı toplama
    static int Topla(int a, int b, int c)
    {
        return a + b + c;
    }

    // Dizi (array) elemanlarını toplama
    static int Topla(int[] sayilar)
    {
        int toplam = 0;
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam;
    }
}