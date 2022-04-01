using System;
using System.Collections.Generic;

namespace Patika.dev
{
    public class Kisi : IEquatable<Kisi>
    {

        public string isim { get; set; }
        public string soyisim { get; set; }
        public int tel { get; set; }

       

        public Kisi(string _isim, string _soyisim, int _tel)
        {
            this.isim = _isim;
            this.soyisim = _soyisim;
            this.tel = _tel;
        }
        public override string ToString()
        {
            return  "İsim: " + isim  + "\nSoyisim: " + soyisim  + "\nTelefon Numarası: " +tel + "\n-"; 
        }

        
        public Kisi(string _isim)
        {
            this.isim = _isim;
                       
            this.soyisim = _isim;
            
        }
       

        public Kisi(int _tel)
        {
            this.tel = _tel;
        }


        public Kisi(){}

        public bool Equals(Kisi other)
        {
            if (this.isim == other.isim || this.soyisim == other.soyisim || this.tel == other.tel)
            {
                return true;
            }
            else
                return false;
        }
    }

}



