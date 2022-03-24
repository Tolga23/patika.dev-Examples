using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan c1 = new Calisan();
            c1.Ad = "Tolga";
            c1.Soyad = "Hardal";
            c1.No = 2333;
            c1.Departman = "Developer";

            c1.CalisanBilgileri();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;


        public void CalisanBilgileri()
        {
            Console.WriteLine("Ad: {0}", Ad);
            Console.WriteLine("Soyad: {0}", Soyad);
            Console.WriteLine("No: {0}", No);
            Console.WriteLine("Departman: {0}", Departman);
        }
    }
}