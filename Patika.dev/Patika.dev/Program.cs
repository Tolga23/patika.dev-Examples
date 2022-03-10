using System;

namespace Patika.dev 
{
    class Program
    {


        static void Main(string[] args)
        {
            int totalCost;
            double meal_cost = 12.00;
            int tip_percent = 20;
            int tax_percent = 8;
            double tip , tax;



            tip = meal_cost / 100 * tip_percent ;
                     
            tax = meal_cost / 100 * tax_percent;
           
            totalCost = Convert.ToInt32(meal_cost + tip + tax);


            if (totalCost == 15 && tip > 2)
                Console.WriteLine("Başarılı! \n" + totalCost);
            else
                Console.WriteLine("Hata!");
        }


    }
}
