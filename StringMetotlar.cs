using System;
using System.Collections.Generic;
using System.Linq;

namespace Patika.dev
{
    class Program
    {

        static void Main(string[] args)
        {

            string str = "Patika.dev C# 101";
            string str2 = "Patika.dev";

            Console.WriteLine(str.Length);

            // CompareTo, Compare
            Console.WriteLine(str.CompareTo(str2)); // 1,0,-1   eşitse 0, str>str2 1, str2>str -1
            Console.WriteLine(String.Compare(str, str2,true));
            Console.WriteLine(String.Compare(str, str2, false));

            // Contains
            Console.WriteLine(str.Contains(str2));
            Console.WriteLine(str.EndsWith("101"));

            // IndexOf
            Console.WriteLine(str.IndexOf("dev"));

            // Insert
            Console.WriteLine(str.Insert(0,"Merhaba! "));

            // PadLeft, PadRight
            Console.WriteLine(str + str2.PadLeft(30));
            Console.WriteLine(str + str2.PadLeft(30, '*'));

            //Remove
            Console.WriteLine(str.Remove(10));
            Console.WriteLine(str.Remove(5,3));

            //Replace
            Console.WriteLine(str.Replace(" ", "")); //cümledeki boşluklar kaldırıldı.

            //Split
            Console.WriteLine(str.Split(' ')[1]); //bosluğa göre diziye atar ve 1. indexi getirir.

            //Substring
            Console.WriteLine(str.Substring(4)); //4. indexten başlayarak yazdırır
            Console.WriteLine(str.Substring(4, 5)); //4. indexten başlayıp 5 karakter getirir.


        }

    }

   
    
}



