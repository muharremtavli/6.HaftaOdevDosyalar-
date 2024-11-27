using System;
class Program
{
    static void Main()
    {
        // Kitaplık nesnesi oluşturma
        Kitaplik kitaplik = new Kitaplik(5);

        // Kitap ekleme
        kitaplik[0] = "Sefiller";
        kitaplik[1] = "Suç ve Ceza";
        kitaplik[2] = "Bülbülü Öldürmek";
        kitaplik[3] = "1984";
        kitaplik[4] = "Hayvan Çiftliği";

        // Kitapları listeleme
        Console.WriteLine("Kitaplar:");
        for (int i = 0; i < kitaplik.Length; i++)
        {
            Console.WriteLine($"{i}: {kitaplik[i]}");
        }

        // Geçersiz indeks erişimi
        try
        {
            Console.WriteLine(kitaplik[5]); // Geçersiz indeks
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Kitap adını değiştirme
        kitaplik[2] = "Yeni Bülbülü Öldürmek";
        Console.WriteLine("Güncellenmiş Kitaplar:");
        for (int i = 0; i < kitaplik.Length; i++)
        {
            Console.WriteLine($"{i}: {kitaplik[i]}");
        }
        Console.ReadLine();
    }
}

class Kitaplik
{
    private string[] kitaplar;

    public Kitaplik(int boyut)
    {
        kitaplar = new string[boyut];
    }

    // İndeksleyici
    public string this[int indeks]
    {
        get
        {
            // Geçersiz indeks kontrolü
            if (indeks < 0 || indeks >= kitaplar.Length)
            {
                throw new IndexOutOfRangeException("Geçersiz indeks: " + indeks);
            }
            return kitaplar[indeks];
        }
        set
        {
            // Geçersiz indeks kontrolü
            if (indeks < 0 || indeks >= kitaplar.Length)
            {
                throw new IndexOutOfRangeException("Geçersiz indeks: " + indeks);
            }
            kitaplar[indeks] = value;
        }
    }

    // Kitap sayısını döndürme
    public int Length
    {
        get { return kitaplar.Length; }
    }
}
}
