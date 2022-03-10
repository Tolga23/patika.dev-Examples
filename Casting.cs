using System;

namespace Patika.dev 
{
    class Program
    {


        static void Main(string[] args)
        {
            // System Convert
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;

            Console.WriteLine("Toplam: " + toplam);

            // Parse
            ParseMethod();
        }

        
        

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10,23";
            int r1;
            double d1;

            r1 = Int32.Parse(metin1);
            d1 = Double.Parse(metin2);

            Console.WriteLine("metin1: " + r1);
            Console.WriteLine("metin2 " + d1);
        }

    }

    
}
