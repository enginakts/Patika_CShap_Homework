using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Menü
            Console.WriteLine("Menü:");
            Console.WriteLine("1 - Çift Sayıları Yazdır");
            Console.WriteLine("2 - m'e Eşit veya m'e Tam Bölünen Sayıları Yazdır");
            Console.WriteLine("3 - Kelimeleri Sondan Başa Yazdır");
            Console.WriteLine("4 - Cümledeki Kelime ve Harf Sayısını Yazdır");
            Console.WriteLine("5 - Çıkış");
            Console.Write("Bir seçenek girin: ");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    CiftSayilariYazdir();
                    break;
                case "2":
                    EsitVeyaBolunenSayilariYazdir();
                    break;
                case "3":
                    KelimeleriSondanBasaYazdir();
                    break;
                case "4":
                    CumledekiKelimeVeHarfSayisiniYazdir();
                    break;
                case "5":
                    Console.WriteLine("Çıkılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçenek. Tekrar deneyin.");
                    break;
            }

            // Kullanıcıya bir tuşa basmasını bekleriz
            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }

    // 1. Çift Sayıları Yazdır
    static void CiftSayilariYazdir()
    {
        Console.Write("Pozitif bir sayı girin (n): ");
        int n = int.Parse(Console.ReadLine());
        string numbers = "";

        Console.WriteLine($"{n} adet pozitif sayı giriniz:");
        for (int i = 0; i < n; i++)
        {
            int sayi = int.Parse(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                numbers += sayi +" - " ;
            }
        }
        Console.WriteLine($"Çift sayılar : {numbers}");
    }

    // 2. m'e Eşit veya m'e Tam Bölünen Sayıları Yazdır
    static void EsitVeyaBolunenSayilariYazdir()
    {
        Console.Write("Pozitif iki sayı girin (n, m): ");
        string[] inputs = Console.ReadLine().Split(' ');
        int n = int.Parse(inputs[0]);
        int m = int.Parse(inputs[1]);

        Console.WriteLine($"{n} adet pozitif sayı giriniz:");
        for (int i = 0; i < n; i++)
        {
            int sayi = int.Parse(Console.ReadLine());
            if (sayi == m || sayi % m == 0)
            {
                Console.WriteLine(sayi);
            }
        }
    }

    // 3. Kelimeleri Sondan Başa Yazdır
    static void KelimeleriSondanBasaYazdir()
    {
        Console.Write("Pozitif bir sayı girin (n): ");
        int n = int.Parse(Console.ReadLine());

        List<string> kelimeler = new List<string>();
        Console.WriteLine($"{n} adet kelime giriniz:");
        for (int i = 0; i < n; i++)
        {
            string kelime = Console.ReadLine();
            kelimeler.Add(kelime);
        }

        kelimeler.Reverse(); // Kelimeleri sondan başa doğru sıralar
        foreach (string kelime in kelimeler)
        {
            Console.WriteLine(kelime);
        }
    }

    // 4. Cümledeki Kelime ve Harf Sayısını Yazdır
    static void CumledekiKelimeVeHarfSayisiniYazdir()
    {
        Console.Write("Bir cümle yazın: ");
        string cumle = Console.ReadLine();

        // Cümleyi boşluklardan ayırarak kelimeleri alıyoruz
        string[] kelimeler = cumle.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int kelimeSayisi = kelimeler.Length;

        // Harf sayısını bulmak için tüm karakterleri kontrol ediyoruz
        int harfSayisi = 0;
        foreach (string kelime in kelimeler)
        {
            harfSayisi += kelime.Length;
        }

        Console.WriteLine($"Kelime Sayısı: {kelimeSayisi}");
        Console.WriteLine($"Harf Sayısı: {harfSayisi}");
    }
}
