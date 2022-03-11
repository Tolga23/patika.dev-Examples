using System;
using System.Collections.Generic;
using System.Linq;

namespace Patika.dev
{
    class Program
    {

        static void Main(string[] args)
        {
            Islemler ins = new();

            int sonuc = ins.Expo(2, 3);
            Console.WriteLine(sonuc);
            Console.WriteLine(ins.Expo(2, 1));
            Console.WriteLine(ins.Expo(2, 0));
            Console.WriteLine(ins.Expo(0, 2));


            // Extension Metotlar

            string name = "Tolga Hardal";
            Console.WriteLine(name.CheckSpaces());
            Console.WriteLine(name.RemoveWhiteSpaces());
            Console.WriteLine(name.MakeUpper());
            Console.WriteLine(name.MakeLower());


            int[] dizi = { 23, 5, 66, 12, 1, 45 };
            dizi.Sortt();
        }


    }

    class Islemler
    {
        // Recursive
        public int Expo(int sayi, int üs)
        {
            if (üs == 0)
                return sayi = 1;
            else if (üs == 1)
                return sayi;

            return Expo(sayi, üs - 1) * sayi;
        }

    }


    public static class Extension
    {

        public static bool CheckSpaces(this string param)
        {
           return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*", dizi);
        }

        public static string MakeUpper(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLower(this string param)
        {
            return param.ToLower();
        }

        public static int[] Sortt(this int[] sort)
        {
            Array.Sort(sort);

            foreach (int num in sort)
            {
                Console.WriteLine(num);
            }

            return sort;
            
        }

    }
}



