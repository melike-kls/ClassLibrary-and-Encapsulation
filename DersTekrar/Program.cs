using OgrenciLib;
using System;

namespace DersTekrar
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ad = "Ahmet";
            ogrenci.soyad = "Mehmet";
            ogrenci.telno = "123456789";
            ogrenci.yas = 20;
            ogrenci.Ortalama = 3;
            Console.WriteLine(ogrenci.Basaridurum);
            Console.ReadKey();


        }


    }

    


}


