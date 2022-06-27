using System;

namespace interfaceApp
{

    enum Oyunlar
    {
        PC,
        Atari,
        PS5
    }

    interface Oyun
    {
        void Play();
    }

    class Atari : Oyun
    {
        public void Play()
        {
            Console.WriteLine("Atari");
        }
    }

    class PC : Oyun
    {
        public void Play()
        {
            Console.WriteLine("PC");
        }
    }

    class PS5 : Oyun
    {
        public void Play()
        {
            Console.WriteLine("PS4");
        }
    }

    class Creater
    {
        public Oyun FactoryMethod(Oyunlar OyunTipi)
        {
            Oyun oyun = null;

            switch (OyunTipi)
            {
                case Oyunlar.Atari:
                    oyun = new Atari();
                    break;
                case Oyunlar.PC:
                    oyun = new PC();
                    break;
                case Oyunlar.PS5:
                    oyun = new PS5();
                    break;
            }

            return oyun;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Creater creater = new Creater();
                Oyun oyun = creater.FactoryMethod(Oyunlar.Atari);
                Oyun pcOyun = creater.FactoryMethod(Oyunlar.PC);
                oyun.Play();
                pcOyun.Play();

            }

        }
    }
}