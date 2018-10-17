
namespace MarstakiGezgin.Yonler
{
    public class Kuzey : GezginYonu
    {
        public Kuzey(Gezgin gezgin) : base(gezgin)
        {

        }

        public override void Ilerle()
        {
            Koordinat koordinat = _gezgin.KoordinatlariGetir();
            koordinat = new Koordinat(koordinat.X, koordinat.Y + 1);
            _gezgin.KoordinatAyarla(koordinat);
        }

        public override void SagaDon()
        {
            _gezgin.GezgininYonunuAyarla(new Dogu(_gezgin));
        }

        public override void SolaDon()
        {
            _gezgin.GezgininYonunuAyarla(new Bati(_gezgin));
        }

        public override string ToString()
        {
            return "N";
        }
    }
}
