using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ögrenci c1 = new Ögrenci("Tolga", "Hardal", 333, 1);
            c1.SinifDüsür();
            c1.SinifDüsür();
            c1.bilgiGetir();

        }
    }

    class Ögrenci
    {
        private string Ad;
        private string Soyad;
        private int No;
        private int Sinif;

        public Ögrenci() { }
        

        public string Ad1 {
            get { return Ad; }
            set { Ad = value; }
        }
        public string Soyad1 { get => Soyad; set => Soyad = value; }
        public int No1 { get => No; set => No = value; }
        public int Sinif1 { get => Sinif;
           
            
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sinif en az 1 olmalıdır");
                    Sinif = 1;
                }
                else
                    Sinif = value;
                
                
            }
               
        }

        
        public Ögrenci(string ad1, string soyad1, int no1, int sinif1)
        {
            Ad1 = ad1;
            Soyad1 = soyad1;
            No1 = no1;
            Sinif1 = sinif1;
        }

        public void SinifDüsür()
        {
            this.Sinif = this.Sinif - 1;
        }

        public void bilgiGetir()
        {
            Console.WriteLine("Ögrenci Bilgileri");
            Console.WriteLine("Ögrenci İsmi:  " + this.Ad);
            Console.WriteLine("Ögrenci Soyad:  " + this.Soyad);
            Console.WriteLine("Ögrenci No:     " + this.No);
            Console.WriteLine("Ögrenci Sinif:  " + this.Sinif);


        }

    }
}