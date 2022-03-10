using System;
using System.Collections.Generic;
using System.Linq;

namespace Patika.dev
{
    class Program
    {
             
        static void Main(string[] args)
        {

            // Sort
            int[] arr = { 23, 13, 4, 55, 1, 37, 78, 6, 99 };

            Console.WriteLine("******Sırasız Dizi******");
            foreach (var sayi in arr)
                Console.WriteLine(sayi);

            Console.WriteLine("******Sıralı Dizi******");

            Array.Sort(arr);
            foreach (var sayi in arr)
                Console.WriteLine(sayi);

            // Clear
            Console.WriteLine("******Array Clear******");
            Array.Clear(arr,5,2);
            foreach (var sayi in arr)
                Console.WriteLine(sayi);

            // Reverse

            Console.WriteLine("******Reverse******");

            Array.Reverse(arr);
            foreach (var sayi in arr)
                Console.WriteLine(sayi);
        }
    }
}

    

