using System;

namespace MarstakiGezgin
{
    class Program
    {
        static void Main(string[] args)
        {

            Koordinat minKoordinat = new Koordinat(0, 0);
            Koordinat maxKoordinat = new Koordinat(5, 4);

            Yuzey yuzey = new Yuzey(maxKoordinat, minKoordinat);
            Gezgin gezgin = new Gezgin(new Koordinat(1, 2), "N", yuzey);
            gezgin.IlerlemeTalimati("LMLMLMLMM");

            string sonuc = gezgin.KonumKardinatlariniGetir();
            Console.WriteLine(sonuc);
            Console.ReadLine();


            Gezgin gezgin2 = new Gezgin(new Koordinat(3, 3), "E", yuzey);
            gezgin2.IlerlemeTalimati("MMRMMRMRRM");
            string sonuc2 = gezgin2.KonumKardinatlariniGetir();
            
            Console.WriteLine(sonuc2);

            Console.ReadLine();

        }
    }
}
