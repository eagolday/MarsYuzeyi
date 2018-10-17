
namespace MarstakiGezgin
{
    public abstract class GezginYonu
    {
        protected Gezgin _gezgin;

        public GezginYonu(Gezgin gezgin)
        {
            _gezgin = gezgin;
        }

        public abstract void SagaDon();
        public abstract void SolaDon();

        public abstract void Ilerle();


    }
}
