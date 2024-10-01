using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Kahve isimlerini saklayacağımız bir liste oluşturuyoruz.
        List<string> kahveler = new List<string>();

        // Kullanıcıdan 5 kahve ismi alıyoruz.
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Kahve {i}: ");
            string kahve = Console.ReadLine();
            kahveler.Add(kahve);
        }

        // Girilen kahve isimlerini yazdırıyoruz.
        Console.WriteLine("\nGirilen kahve isimleri:");
        foreach (var kahve in kahveler)
        {
            Console.WriteLine(kahve);
        }
    }
}
