using System;

class Program
{
    static void Main()
    {
        // Satranç tahtası nesnesi oluşturma
        SatrançTahtası tahtası = new SatrançTahtası();

        // Taşları yerleştirme
        tahtası[0, 0] = "A1 - Beyaz Kale";
        tahtası[0, 1] = "B1 - Beyaz At";
        tahtası[0, 2] = "C1 - Beyaz Fil";
        tahtası[0, 3] = "D1 - Beyaz Vezir";
        tahtası[0, 4] = "E1 - Beyaz Şah";
        tahtası[0, 5] = "F1 - Beyaz Fil";
        tahtası[0, 6] = "G1 - Beyaz At";
        tahtası[0, 7] = "H1 - Beyaz Kale";

        // Taşları kontrol etme
        Console.WriteLine(tahtası[0, 0]); // A1 - Beyaz Kale
        Console.WriteLine(tahtası[0, 3]); // D1 - Beyaz Vezir

        // Geçersiz kare erişimi
        try
        {
            Console.WriteLine(tahtası[8, 8]); // Geçersiz kare
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadLine();
    }
}

class SatrançTahtası
{
    private string[,] kareler;

    public SatrançTahtası()
    {
        // 8x8 satranç tahtası
        kareler = new string[8, 8];
    }

    // İndeksleyici
    public string this[int satir, int sutun]
    {
        get
        {
            // Geçersiz kare kontrolü
            if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
            {
                throw new IndexOutOfRangeException("Geçersiz kare: [" + satir + ", " + sutun + "]");
            }
            return kareler[satir, sutun] ?? "Boş"; // Eğer kare boşsa "Boş" döner
        }
        set
        {
            // Geçersiz kare kontrolü
            if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
            {
                throw new IndexOutOfRangeException("Geçersiz kare: [" + satir + ", " + sutun + "]");
            }
            kareler[satir, sutun] = value;
        }
    }
}