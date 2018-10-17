using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarstakiGezgin
{

    public class Yuzey
    {
        private Koordinat _maxKoordinat;
        private Koordinat _minKoordinat;

        public Yuzey(Koordinat maxKoordinat, Koordinat minKoordinat)
        {
            _maxKoordinat = maxKoordinat;
            _minKoordinat = minKoordinat;
        }

        public bool DuzlemGecerliMi(Koordinat koordinat)
        {
            if (!KoordinatDuzlemdeMi(koordinat.X, koordinat.Y))
            {
                return false;
            }
            return true;
        }


        // NASA’dan gönderilen harf katarları sonucu robotik gezginin son konumu,
        // diktörtgen yüzeyin bulunduğu x veya y koordinatından en az birini aşarsa, aşan koordinat dikdörtgenin maksimum konumunda kalacaktır.
        //     (ÖRN: diktörtgenin koordinatları 0,0 ve 5,5 ise ve yeni konum 7,4 çıktı ise robotik gezginin son konumu 5,4 olacaktır.)

        private bool KordinatXDuzlemindeMi(int x)
        {
            return x >= _minKoordinat.X && x <= _maxKoordinat.X;
        }
        private bool KordinatYDuzlemindeMi(int y)
        {
            return y >= _minKoordinat.Y && y <= _maxKoordinat.Y;
        }
        private bool KoordinatDuzlemdeMi(int x, int y)
        {
            return (KordinatXDuzlemindeMi(x) && KordinatYDuzlemindeMi(y));
        }


    }
}
