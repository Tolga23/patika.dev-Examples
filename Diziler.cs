using System;

namespace Patika.dev
{
    class Program
    {



        static void Main(string[] args)
        {

            // Dizi tanımlama & Değer atama

            string[] renkler = new string[5];
            string[] cars = { "BMW", "Toyota", "Mercedes" };

            int[] dizi;
            dizi = new int[5];

            renkler[0] = "Mavi";

            dizi[3] = 10;

            Console.WriteLine(renkler[0]);

            // Döngüler ile dizi kullanımı
            // Klavyeden girilen n tane sayının ortalaması

            

            Console.Write("Dizini eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());

            int[] sayi = new int[diziUzunlugu];

            
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
                sayi[i] = int.Parse(Console.ReadLine());

                
            }

            int toplam = 0;
            
            foreach (var item in sayi)
            {
                toplam += item;
                
            }
            int ortalama = toplam / diziUzunlugu;
            Console.WriteLine("Ortalama: " + ortalama);


        }
    }
}

    

