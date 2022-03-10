using System;

namespace Patika.dev 
{
    class Program
    {

        

static void Main(string[] args)
        {

            // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.Write("Bir sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());

            for(int i = 0; i<=sayi; i++)
            {
                if ( i % 2 == 1)
                    Console.WriteLine(i);
                
            }
            // 1-1000 arasında ki tek ve çift sayıların toplamı
            int tek = 0;
            int cift = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 2 == 1)
                    tek += i;
                else
                    cift += i;
                        
            }
            Console.WriteLine("Tek Toplam: "+ tek);
            Console.WriteLine("Cift Toplam: "+ cift);

        }

    }

    
}
