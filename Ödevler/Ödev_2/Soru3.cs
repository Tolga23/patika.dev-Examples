using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    /// <summary>
    /// Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan 
    /// ve dizinin elemanlarını sıralayan programı yazınız.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            List<string> words = new List<string>();
            string[] wowels = { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U" };
            List<string> word = new List<string>();

            words.Add(Console.ReadLine());

            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < wowels.Length; j++)
                {
                    if (words[i].Contains(wowels[j]))
                    {
                        word.Add(wowels[j]);
                    }
                }
                
            }

            Console.WriteLine("Ünlü harfler: ");
            foreach (var item in word)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
