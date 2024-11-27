using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Öğrenci not sistemi nesnesi oluşturma
        NotSistemi notSistemi = new NotSistemi();

        // Not ekleme
        notSistemi["Matematik"] = 85;
        notSistemi["Fizik"] = 90;
        notSistemi["Kimya"] = 78;

        // Notları listeleme
        Console.WriteLine("Notlar:");
        Console.WriteLine("Matematik: " + notSistemi["Matematik"]);
        Console.WriteLine("Fizik: " + notSistemi["Fizik"]);
        Console.WriteLine("Kimya: " + notSistemi["Kimya"]);

        // Geçersiz ders erişimi
        try
        {
            Console.WriteLine("Biyoloji: " + notSistemi["Biyoloji"]); // Geçersiz ders
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadLine();
    }
}

class NotSistemi
{
    private Dictionary<string, int> notlar;

    public NotSistemi()
    {
        notlar = new Dictionary<string, int>();
    }

    // İndeksleyici
    public int this[string dersAdi]
    {
        get
        {
            // Ders adı yoksa hata fırlat
            if (!notlar.ContainsKey(dersAdi))
            {
                throw new KeyNotFoundException("Geçersiz ders adı: " + dersAdi);
            }
            return notlar[dersAdi];
        }
        set
        {
            // Notu ekle veya güncelle
            notlar[dersAdi] = value;
        }
    }
}