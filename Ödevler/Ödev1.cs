using System;
using System.Collections.Generic;
using System.Linq;

namespace Patika.dev
{
    class Program
    {

        static void Main(string[] args)
        {
            Sorular patika = new();
            patika.Soru1();

            patika.Soru2();

            patika.Soru3();

            patika.Soru4();
            

        }


        




    }

    class Sorular
    {
        /// <summary> 
        /// ************************* SORU 1 *****************************************
        /// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
        /// Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        /// Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        /// </summary>
        public void Soru1()
        {
            Console.WriteLine("************************* SORU 1 *********************************");

            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            Console.Write("{0} adet sayı girin: ", sayi);

            int[] sayilar = new int[sayi];

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.Write("Çift Sayılar: ");
            for (int i = 0; i < sayilar.Length; i++)
            {

                if (sayilar[i] % 2 == 0)
                {
                    Console.Write(sayilar[i] + " ");

                }
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// ************************* SORU 2 *****************************************
        ///  Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin(n, m). 
        ///  Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        ///  Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        /// </summary>

        public void Soru2()
        {
            Console.WriteLine("************************* SORU 2 *********************************");

            Console.WriteLine("Lütfen iki sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Console.Write("{0} adet sayı girin: ", n);

            int[] nNum = new int[n];

            for (int i = 0; i < n; i++)
            {
                nNum[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("m'e eşit yada tam bölünenler: ");

            for (int i = 0; i < n; i++)
            {
                if (nNum[i] == m || m % nNum[i] == 0)
                {
                    Console.Write(nNum[i] + " ");
                }
            }

            Console.WriteLine("");
        }

        /// <summary>
        /// ************************* SORU 3 *****************************************
        /// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
        /// Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
        /// Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın
        /// <summary>
        public void Soru3()
        {
            Console.WriteLine("************************* SORU 3 *********************************");

            Console.Write("Bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("{0} adet kelime girin: ", n);

            string[] word = new string[n];

            for (int i = 0; i < n; i++)
            {
                word[i] = Console.ReadLine();
            }

            Array.Reverse(word);
            foreach (string str in word)
            {
                Console.Write(str + " ");
            }
        }

        /// <summary>
        /// ************************* SORU 4 *****************************************
        /// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
        /// Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        /// <summary>

        public void Soru4()
        {
            Console.WriteLine("************************* SORU 4 *********************************");

            Console.Write("Lütfen bir cümle yazınız: ");

            string cumle = Console.ReadLine();
            string[] kelime = cumle.Split(" ");
            char[] harf = cumle.ToCharArray();


            Console.WriteLine("Toplam Kelime sayısı: " + kelime.Length);
            Console.WriteLine("Toplam Harf sayısı: " + (harf.Length - kelime.Length + 1));
        }

    }
}



