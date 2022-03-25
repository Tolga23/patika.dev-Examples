using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan Sayisi: " + Calisan.CalisanSayisi);

            Calisan c1 = new Calisan("Tolga","Hardal","Dev");
            Console.WriteLine("Calisan Sayisi: " + Calisan.CalisanSayisi);


            Console.WriteLine("Toplama işlemi sonucu: "+Islemler.Topla(23,77));
            Console.WriteLine("Cıkarma işlemi sonucu: "+Islemler.Cıkar(100, 50));

        }


    }

    class Calisan
    {
        private static int calisanSayisi;

        private string isim;
        private string soyisim;
        private string departman;
        public static int CalisanSayisi { get => calisanSayisi;}

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan() { }
        public Calisan(string _isim,string _soyisim, string _departman)
        {
            this.isim = _isim;
            this.soyisim = _soyisim;
            this.departman = _departman;
            calisanSayisi++;
        }
    }


    static class Islemler  // static sınıflara kalıtım uygulanmaz ve üyelere nesneler aracılığı ile ulaşılmaz. Üyelere sınıf adı ile ulaşılır.
    {
        public static double Topla(int a, int b)
        {
            return a + b;
        }

        public static double Cıkar(int a, int b)
        {
            return a - b;
        }
    }
}