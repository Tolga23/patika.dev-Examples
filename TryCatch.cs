using System;

namespace Patika.dev 
{
    class Program
    {

        //        Try-Catch-Finally ve Mantıksal Hatalar

            //Try catch blokları sayesinde uygulama içerisinde bir hata oluştuğunda belirtilen işlemler yaptırılabilir.

             //try{ Hataya sebebiyet verme ihtimali olan kod }

             //catch { Hata ile karşılaşıldığında ne yapılacağı buraya yazılır   }

             //finally{ Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız }

static void Main(string[] args)
        {
            try // hata alması muhtemel kod bloğu yazılır
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen sayı: " + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally   // koşuldan bağımsız çalışır
            {
                Console.Write("İşlem tamamlandı \n");
            }

            // Exception 2

            try
            {
                //int a = int.Parse(null); // ArgumentNullException
                int b = int.Parse("test");  // Wrong Format - FormatException
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
                
            }
            catch(FormatException ex1)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex1);
            }
            


        }

        
        

       

    }

    
}
