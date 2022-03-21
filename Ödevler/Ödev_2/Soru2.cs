using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp1
{
    /// <summary>
    /// Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
    /// her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
    /// (Array sınıfını kullanarak yazınız.)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizinin eleman sayısını girin.");
            int arrLength = int.Parse(Console.ReadLine());
            int[] numbers = new int[arrLength];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                                              
            }


            Array.Sort(numbers);
            int min = 0;
            int max = 0;
            for (int i = 0; i < 3; i++)
            {
                min += numbers[i];
            }
            

            for (int i = numbers.Length-3; i < numbers.Length; i++)
            {
                max += numbers[i];
            }
            Console.WriteLine("Minimum 3 sayının ortalaması: " + min / 3);
            Console.WriteLine("Maximum 3 sayının ortalaması: " + max/3);
            Console.WriteLine("Ortalama toplamları: " + (min/3 + max/3));

            
        }
    }
}
