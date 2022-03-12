using System;
using System.Collections.Generic;
using System.Linq;

namespace Patika.dev
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Year);

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(5));
            Console.WriteLine(DateTime.Now.AddMonths(3));

            Console.WriteLine(DateTime.Now.ToString("M"));
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("G"));
            Console.WriteLine("-------------Math Kütüphanesi--------------");
            Console.WriteLine(Math.Abs(-25)); //25
            Console.WriteLine(Math.Sin(-25));

            Console.WriteLine(Math.Ceiling(23.3)); // 24 Yukarı yuvarlar
            Console.WriteLine(Math.Round(23.3)); // 23 Aşağı ya da yukarı yuvarlar
            Console.WriteLine(Math.Round(23.7)); //24
            Console.WriteLine(Math.Floor(23.3)); //23 Aşağı yuvarlar

            Console.WriteLine(Math.Max(2, 4));

            Console.WriteLine(Math.Pow(2,4)); //2^4
            Console.WriteLine(Math.Sqrt(9)); // karekök alır. 3
            Console.WriteLine(Math.Log(9));
            Console.WriteLine(Math.Log10(10));



        }

    }

   
    
}



