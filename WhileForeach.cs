using System;

namespace Patika.dev
{
    class Program
    {



        static void Main(string[] args)
        {

            // 1 den baslayarak console'dan girilen sayıya kadar ortalama hesaplat
            Console.Write("Bir sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            // a dan z ye kadar tüm harcleri consola yazdır
            char c = 'a';
            while (c < 'z')
            {
                Console.Write(c);
                c++;
            }

            // Foreach

            string[] cars = { "BMW", "Ford", "Toyata" };

            foreach (var car in cars)  
            {
                Console.WriteLine(car);
            }





            {

            }

        }
    }
}

    

