using System;

namespace OgrenciLib
{
    public class Ogrenci
    {
        public string ad;
        public string soyad;
        public string telno;
        public byte yas;
        double ortalama;
        string basaridurum;

        public string Basaridurum { get => basaridurum; }
        public double Ortalama
        {
            get
            {
                return ortalama;
            }
            set
            {
                ortalama = value;
                if (value < 2)
                {
                    basaridurum = "basarısız";
                }
                else
                {
                    basaridurum = "basarılı";
                }
            }
        }

    }
}
