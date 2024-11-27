using System;

struct KarmaşıkSayı
{
    public double Real { get; set; }      // Gerçek kısmı
    public double Imaginary { get; set; } // Hayali kısmı
    // Toplama işlemi
    public static KarmaşıkSayı operator +(KarmaşıkSayı s1, KarmaşıkSayı s2)
    {
        return new KarmaşıkSayı
        {
            Real = s1.Real + s2.Real,
            Imaginary = s1.Imaginary + s2.Imaginary
        };
    }
    // Çıkarma işlemi
    public static KarmaşıkSayı operator -(KarmaşıkSayı s1, KarmaşıkSayı s2)
    {
        return new KarmaşıkSayı
        {
            Real = s1.Real - s2.Real,
            Imaginary = s1.Imaginary - s2.Imaginary
        };
    }
    // Sonucu a + bi formatında döndüren metot
    public override string ToString()
    {
        if (Imaginary >= 0)
            return $"{Real} + {Imaginary}i";
        else
            return $"{Real} - {-Imaginary}i"; // Negatif hayali kısım için
    }
}
class Program
{
    static void Main()
    {
        // Karmaşık sayılar oluşturma
        KarmaşıkSayı s1 = new KarmaşıkSayı { Real = 3, Imaginary = 4 };
        KarmaşıkSayı s2 = new KarmaşıkSayı { Real = 1, Imaginary = 2 };
        // Toplama işlemi
        KarmaşıkSayı toplam = s1 + s2;
        Console.WriteLine($"Toplama: {s1} + {s2} = {toplam}");
        // Çıkarma işlemi
        KarmaşıkSayı fark = s1 - s2;
        Console.WriteLine($"Çıkarma: {s1} - {s2} = {fark}");
    }
}