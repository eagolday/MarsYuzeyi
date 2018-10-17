
namespace MarstakiGezgin.Yonler
{
    public class Bati : GezginYonu
    {

        public Bati(Gezgin gezgin) : base(gezgin)
        {

        }

        public override void Ilerle()
        {

            Koordinat koordinat = _gezgin.KoordinatlariGetir();
            koordinat = new Koordinat(koordinat.X - 1, koordinat.Y);
            _gezgin.KoordinatAyarla(koordinat);

        }

        public override void SagaDon()
        {
            _gezgin.GezgininYonunuAyarla(new Kuzey(_gezgin));
        }

        public override void SolaDon()
        {
            _gezgin.GezgininYonunuAyarla(new Guney(_gezgin));
        }
        public override string ToString()
        {
            return "W";
        }
    }
}
