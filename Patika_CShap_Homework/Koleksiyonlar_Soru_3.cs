using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle giriniz: ");
            string cumle = Console.ReadLine().ToLower();
            List<char> sesliHarfler = new List<char>();
            char[] sesliHarflerArray = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char harf in cumle)
            {
                if (Array.Exists(sesliHarflerArray, element => element == harf))
                {
                    sesliHarfler.Add(harf);
                }
            }

            sesliHarfler.Sort();

            Console.WriteLine("\nSesli Harfler (Sıralı):");
            foreach (char harf in sesliHarfler)
            {
                Console.WriteLine(harf);
            }

            Console.ReadLine();
        }
    }
}
