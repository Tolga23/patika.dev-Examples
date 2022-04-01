using System;
using System.Linq;
using System.Collections.Generic;

namespace Patika.dev
{
    public class Islemler : Kisi
    {
        List<Kisi> person = new List<Kisi>();

        public void Menu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("****************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
            Console.WriteLine("(0) Çıkış");
        }
        public void Rehber()
        {
            person.Add(new Kisi(isim = "Tolga", soyisim = "Hardal", tel = 09999));
            person.Add(new Kisi("Alper", "Hardal", 8888));
            person.Add(new Kisi("Büşra", "Hardal", 7787));
            person.Add(new Kisi("Gölge", "Pisi", 6666));
            person.Add(new Kisi() { isim = "Lethe", soyisim = "Qwd", tel = 5555 });
            
        }

        public void YeniKayit()
        {
            Console.Write("Lütfen isim giriniz          : ");
            isim = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz       : ");
            soyisim = Console.ReadLine();
            Console.Write("Lütfen tel numarası giriniz  : ");
            tel = int.Parse(Console.ReadLine());

            person.Add(new Kisi(isim ,soyisim, tel));

            Listele();                
        }

        public void NumaraSil()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string isimSoyisim = Console.ReadLine();
            
            // Aranılan isim & soyisim List içinde bulunamazsa
            if (!person.Contains(new Kisi(isimSoyisim)) || !person.Contains(new Kisi(this.soyisim = isimSoyisim)))
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. ");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1) ");
                Console.WriteLine("* Yeniden denemek için: (2) ");
                try
                {
                    int secim = int.Parse(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            break;
                        case 2:
                            NumaraSil();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lütfen 1 ve ya 2 seçiniz." + ex.Message);
                    NumaraSil();
                }

            }
            // Aranılan isim ve ya soyisim bulunursa çalışır.
            else
            {
                
                Console.WriteLine($"{isimSoyisim} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                
                try
                {
                    char onay = char.Parse(Console.ReadLine());
                    switch (onay)
                    {
                        case 'y':
                            Console.WriteLine($"{isimSoyisim} isimli kişi rehberden başarıyla silindi.");
                            person.Remove(new Kisi(isimSoyisim));
                            break;
                        case 'n':
                            break;
                        default:
                            Console.WriteLine("Yanlış tuşa basıldı. Lütfen (y/n) tuslarından birine basın.");
                            NumaraSil();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Yanlış tuşa basıldı. Lütfen (y/n) tuslarından birine basın "+ ex.Message) ;
                    NumaraSil();
                }
               
            }
            
        }

        public void Güncelle()
        {

            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string isimSoyisim = Console.ReadLine();

            if (!person.Contains(new Kisi(isimSoyisim)))
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Güncellemeyi sonlandırmak için    : (1)");
                Console.WriteLine(" * Yeniden denemek için              : (2)");

                try
                {
                    int secim = int.Parse(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            break;
                        case 2:
                            Güncelle();
                            break;
                        default:
                            Console.WriteLine("Yanlış bir seçim girildi. Lütfen (1) ve ya (2) seçeneklerinden birini seçiniz. ");
                            break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(" " + ex.Message);

                }
            }
            // Aranılan isim ve ya soyisim bulunursa çalışır.
            else 
            {                              
                    Console.WriteLine("Yeni numarayı giriniz: ");
                    int num = int.Parse(Console.ReadLine());
                    
                    var found = person.FirstOrDefault(c => c.isim == isimSoyisim);
                    if (found != null)
                        found.tel = num;
                             
            }

        }

        public void Listele()
        {
            foreach (var item in person)
            {
                Console.WriteLine(item);
            }
                     
        }

        public void Arama()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n*********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            try
            {
                int sec = int.Parse(Console.ReadLine());
                switch (sec)
                {
                    case 1:
                        string isimSoyisim = Console.ReadLine();
                        
                        foreach (Kisi kisi in person)
                        {
                            if (kisi.isim.ToLower() == isimSoyisim.ToLower() || kisi.soyisim.ToLower() == isimSoyisim.ToLower())
                            {
                                Console.WriteLine("Arama Sonuçlarınız:\n*********************************************");
                                Console.WriteLine(kisi);
                            }
                       
                        }

                        break;

                    case 2:
                        int num = int.Parse(Console.ReadLine());

                        foreach (Kisi kisi in person)
                        {
                            if (kisi.tel == num)
                            {
                                Console.WriteLine("Arama Sonuçlarınız:\n*********************************************");
                                Console.WriteLine(kisi);
                            }
                            
                        }
                        break;

                    default:
                        Console.WriteLine("Hatalı Seçim");
                        Arama();
                        break;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hatalı Seçim" + ex.Message);
                Arama();
            }
        }
    }

}



