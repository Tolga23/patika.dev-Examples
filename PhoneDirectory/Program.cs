using System;
using System.Collections;

namespace Patika.dev
{

    class Program
    {

        static void Main(string[] args)
        {

            
            Islemler i1 = new();
            // Menu açılır
            i1.Menu();
            // Rehbere kişiler yüklenir.
            i1.Rehber();

            try
            {
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        i1.YeniKayit();
                        break;
                    case 2:
                        i1.NumaraSil();
                        break;
                    case 3:
                        i1.Güncelle(); 
                        break;
                    case 4:
                        i1.Listele(); 
                        break;
                    case 5:
                        i1.Arama();
                        break;
                    case 0:
                        Console.WriteLine("Program Kapatılıyor.");
                        break;
                    default:
                        Console.WriteLine("Program Kapatılıyor.");
                        break;

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hatalı Seçim. Program Kapanıyor " + ex.Message);
            }
           
           
;
        }

        

    }

}



