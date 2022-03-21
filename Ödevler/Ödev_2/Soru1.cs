using System;
using System.Collections;

namespace ConsoleApp1
{
    /// <summary>
    /// Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
    /// Negatif ve numeric olmayan girişleri engelleyin. 
    /// Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
    /// Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();
            ArrayList asal = new ArrayList();
            Console.WriteLine("20 adet sayı girin.");

            try
            {
                
                int i = 0;
                while (i < 20)
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    
                    if (n >= 0)
                    {

                        if (n == 1 || n % 2 == 0 || n % 3 == 0 || n % 5 == 0 || n % 7 == 0)
                        {
                            numbers.Add(n);
                            if (n == 2 || n == 3 || n == 5 || n == 7)
                            {
                                numbers.Remove(n);
                                asal.Add(n);
                            }
                            
                           
                        }
                        else
                        {
                            asal.Add(n);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Lütfen 0'dan büyük bir sayı girin.");
                        i--;
                    }

                    i++;
                    
                }
                
                Console.WriteLine("******* [{0}] tane Asal Sayı vardır **********", asal.Count);

                asal.Sort();
                int asalToplam = 0;
                int toplam = 0;

                

                foreach (int item in asal)
                {
                    asalToplam += item;
                    Console.WriteLine(item);

                }
                
                Console.WriteLine("Asal sayıların ortalaması: " + asalToplam / asal.Count);
                Console.WriteLine("******* [{0}] tane Asal Olmayan Sayı vardır. **********", numbers.Count);

                numbers.Sort();
                               
                foreach (int item in numbers)
                {
                    toplam += item;
                    Console.WriteLine(item);
                }
                Console.WriteLine("Asal olmayan sayıların ortalaması: " + toplam / numbers.Count);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Hata: Lütfen bir sayı girin. ", ex.Message );
                                
            }
           
            
            
            
            
        }
    }
}
