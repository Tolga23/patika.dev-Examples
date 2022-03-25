using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);


            int sıcaklık = 24;

            if (sıcaklık <= (int)Sicaklik.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekleyelim");
            }
            else if (sıcaklık >= (int)Sicaklik.Sıcak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            }
            else if(sıcaklık>=(int)Sicaklik.Normal && sıcaklık < (int)Sicaklik.ÇokSıcak)
            {
                Console.WriteLine("Hadi dışarı cıkalım");

            }
        }


    }
    
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum Sicaklik
    {
        Soğuk = 5,
        Normal = 20,
        Sıcak = 25,
        ÇokSıcak = 30
    }
    
}