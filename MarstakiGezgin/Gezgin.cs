using System;

namespace MarstakiGezgin
{
    public class Gezgin
    {
        private Koordinat _koordinat;
        private string _pusulaYonu;
        private Yuzey _yuzey;
        private GezginYonu _gezginYonu;

        public Gezgin(Koordinat koordinat,string pusulaYonu,Yuzey yuzey)
        {
            _koordinat = koordinat;
            _pusulaYonu = pusulaYonu;
            _yuzey = yuzey;
            _gezginYonu = YonIslemleri.GezgininYonunuYarat(pusulaYonu, this) ;
        }

        public Koordinat KoordinatlariGetir()
        {
            return _koordinat;
        }

        public void KoordinatAyarla(Koordinat koordinat)
        {
            bool gecelerliMi = _yuzey.DuzlemGecerliMi(koordinat);
            if (gecelerliMi)
            {
                _koordinat = koordinat;
            }
            else
            {
                Console.WriteLine("Diktörtgen yüzeyin bulunduğu x veya y koordinatından  birini aşıyor");
                Console.ReadLine();
            }
        }

        public void GezgininYonunuAyarla(GezginYonu gezginYonu)
        {
            this._gezginYonu = gezginYonu;
        }
        public string KonumKardinatlariniGetir()
        {
            return "Gezginin gerçek konumu -> x :" + _koordinat.X + ", y:" + _koordinat.Y+ ", Yön:" + _gezginYonu.ToString();
        }

        public void IlerlemeTalimati(string talimat)
        {
            for (int i = 0; i < talimat.Length; i++)
            {
                if (talimat[i] == 'L')
                {
                    _gezginYonu.SolaDon();
                }
                if (talimat[i] == 'R')
                {
                    _gezginYonu.SagaDon();
                }
                if (talimat[i] == 'M')
                {
                   _gezginYonu.Ilerle();
                }

            }
        }

    }
}
