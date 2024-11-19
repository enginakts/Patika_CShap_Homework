using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Bir sayı giriniz: ");
                while (!int.TryParse(Console.ReadLine(), out sayilar[i]))
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
                }
            }

            Array.Sort(sayilar);

            // En küçük 3 sayı
            int[] enKucukUc = new int[3];
            Array.Copy(sayilar, enKucukUc, 3);

            // En büyük 3 sayı
            int[] enBuyukUc = new int[3];
            Array.Copy(sayilar, sayilar.Length - 3, enBuyukUc, 0, 3);

            double enKucukUcOrt = CalculateAverage(enKucukUc);
            double enBuyukUcOrt = CalculateAverage(enBuyukUc);
            double toplamOrt = enKucukUcOrt + enBuyukUcOrt;

            Console.WriteLine("\nEn Küçük 3 Sayı: " + string.Join(", ", enKucukUc));
            Console.WriteLine("En Küçük 3 Sayı Ortalaması: " + enKucukUcOrt);

            Console.WriteLine("\nEn Büyük 3 Sayı: " + string.Join(", ", enBuyukUc));
            Console.WriteLine("En Büyük 3 Sayı Ortalaması: " + enBuyukUcOrt);

            Console.WriteLine("\nOrtalama Toplamı: " + toplamOrt);

            Console.ReadLine();
        }

        static double CalculateAverage(int[] array)
        {
            double sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }
            return sum / array.Length;
        }
    }
}
