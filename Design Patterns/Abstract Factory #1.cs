using System;

namespace factory
{

    enum Oyunlar
    {
    Atari,
    PC,
    PS4
      }

    abstract class Oyun
    {
        public abstract void Platform();
    }

    class Atari : Oyun
    {
        public override void Platform()
        {
            Console.WriteLine("Atari");
        }
    }

    class PC : Oyun
    {
        public override void Platform()
        {
            Console.WriteLine("PC");
        }
    }

    class PS4 : Oyun
    {
        public override void Platform()
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
                case Oyunlar.PS4:
                    oyun = new PS4();
                    break;
            }

            return oyun;
        }
        
        
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Creater creater = new Creater();
            Oyun oyun = creater.FactoryMethod(Oyunlar.Atari);
            Oyun pcOyun = creater.FactoryMethod(Oyunlar.PC);
            oyun.Platform();
            pcOyun.Platform();
        }
    }
}
