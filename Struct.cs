using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dikdortgen d1 = new Dikdortgen();
            Console.WriteLine("Class: {0}",d1.Hesapla());

            Dikdortgen_struct d2;
            d2.KisaKenar = 3;
            d2.UzunKenar = 4;
            Console.WriteLine("Struct: {0}", d2.Hesapla());

        }


    }
    
    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen()
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }

        public int Hesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }

    }

    struct Dikdortgen_struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen_struct(int _kisakenar,int _uzunkenar)
        {
            KisaKenar = _kisakenar;
            UzunKenar = _uzunkenar;
        }

        public int Hesapla()
        {
             
            return this.KisaKenar * this.UzunKenar;
        }
    }
    
}