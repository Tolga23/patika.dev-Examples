using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Patika.dev
{
    class Program
    {

        static void Main(string[] args)
        {

            // using System.Collections kullanılmalı

            ArrayList liste = new ArrayList();
            liste.Add("Tolga");
            liste.Add(23);
            liste.Add(true);
            liste.Add('T');

            // ArrayList verilerine erişim
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
                Console.WriteLine(item);

            // Add Range
            Console.WriteLine("************* ADD RANGE **************");
            string[] renkler = { "Yeşil", "Siyah", "Kırmızı" };
            List<int> sayılar = new List<int> { 1, 23, 5, 7, 9 };

            liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
                Console.WriteLine(item);

            // Binary Search Sort işlemi yapıldıktan sonra çalışır
           //   liste.BinarySearch(7);   7 sayısının indexini getirir
            
        }
    }

   

}



