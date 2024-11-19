using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            int sayi;

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Bir pozitif sayı giriniz: ");
                while (!int.TryParse(Console.ReadLine(), out sayi) || sayi <= 0)
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir sayı giriniz.");
                }

                if (IsPrime(sayi))
                {
                    asalSayilar.Add(sayi);
                }
                else
                {
                    asalOlmayanSayilar.Add(sayi);
                }
            }

            asalSayilar.Sort();
            asalSayilar.Reverse();
            asalOlmayanSayilar.Sort();
            asalOlmayanSayilar.Reverse();

            Console.WriteLine("\nAsal Sayılar (Büyükten Küçüğe):");
            foreach (int item in asalSayilar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAsal Olmayan Sayılar (Büyükten Küçüğe):");
            foreach (int item in asalOlmayanSayilar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAsal Sayılar Sayısı: " + asalSayilar.Count);
            Console.WriteLine("Asal Olmayan Sayılar Sayısı: " + asalOlmayanSayilar.Count);

            Console.WriteLine("\nAsal Sayılar Ortalaması: " + CalculateAverage(asalSayilar));
            Console.WriteLine("Asal Olmayan Sayılar Ortalaması: " + CalculateAverage(asalOlmayanSayilar));

            Console.ReadLine();
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        static double CalculateAverage(ArrayList list)
        {
            double sum = 0;
            foreach (int item in list)
            {
                sum += item;
            }
            return sum / list.Count;
        }
    }
}
