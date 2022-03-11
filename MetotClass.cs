using System;
using System.Collections.Generic;
using System.Linq;

namespace Patika.dev
{
    class Program
    {
             
        static void Main(string[] args)
        {

            int a = 3, b = 7;
            Console.WriteLine(Topla(a, b));
            int sonuc = a + b;

            Methodlar yazdir = new Methodlar();
            yazdir.EkranaYazdir("Method yazdir: "+sonuc.ToString());

        }

        static int Topla(int num1,int num2)
        {
            return num1 + num2;
        }
    }

    class Methodlar
    {

        public void EkranaYazdir(string str)
        {
            Console.WriteLine(str);
        }

    }
}

    

