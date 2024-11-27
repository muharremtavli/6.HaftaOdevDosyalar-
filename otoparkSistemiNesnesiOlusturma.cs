using System;

class Program
{
    static void Main()
    {
        // Otopark sistemi nesnesi oluşturma
        Otopark otopark = new Otopark(3, 5); // 3 kat, 5 park yeri

        // Araç park etme
        otopark[0, 0] = "34ABC123"; // 1. katta 1. park yeri
        otopark[1, 2] = "07XYZ456"; // 2. katta 3. park yeri

        // Park yerlerini kontrol etme
        Console.WriteLine("1. Kat, 1. Park Yeri: " + otopark[0, 0]); // Dolu
        Console.WriteLine("1. Kat, 2. Park Yeri: " + otopark[0, 1]); // Boş
        Console.WriteLine("2. Kat, 3. Park Yeri: " + otopark[1, 2]); // Dolu
        Console.WriteLine("3. Kat, 1. Park Yeri: " + otopark[2, 0]); // Boş

        // Geçersiz kat veya park yeri erişimi
        try
        {
            Console.WriteLine(otopark[3, 0]); // Geçersiz kat
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Console.WriteLine(otopark[1, 5]); // Geçersiz park yeri
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadLine();
    }
}

class Otopark
{
    private string[][] parkYerleri;

    public Otopark(int katSayisi, int yerSayisi)
    {
        // Her kat için park yerlerini başlatma
        parkYerleri = new string[katSayisi][];
        for (int i = 0; i < katSayisi; i++)
        {
            parkYerleri[i] = new string[yerSayisi];
        }
    }

    // İndeksleyici
    public string this[int kat, int yer]
    {
        get
        {
            // Geçersiz kat veya park yeri kontrolü
            if (kat < 0 || kat >= parkYerleri.Length || yer < 0 || yer >= parkYerleri[kat].Length)
            {
                throw new IndexOutOfRangeException("Geçersiz kat veya park yeri: [" + kat + ", " + yer + "]");
            }
            return parkYerleri[kat][yer] ?? "Empty"; // Eğer park yeri boşsa "Empty" döner
        }
        set
        {
            // Geçersiz kat veya park yeri kontrolü
            if (kat < 0 || kat >= parkYerleri.Length || yer < 0 || yer >= parkYerleri[kat].Length)
            {
                throw new IndexOutOfRangeException("Geçersiz kat veya park yeri: [" + kat + ", " + yer + "]");
            }
            parkYerleri[kat][yer] = value; // Araç plakasını ayarla
        }
    }
}