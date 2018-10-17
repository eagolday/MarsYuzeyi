
namespace MarstakiGezgin
{
    public class Koordinat
    {
        private int _x;
        private int _y;

        //Parametre gönderilmeden set edilmesini kapatıyorum.
        public Koordinat(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get { return _x; }
            private set
            {
                if (value < 0)
                    _x = 0;
                else
                    _x = value;
            }
        }

        public int Y
        {
            get { return _y; }
            private set
            {
                if (value < 0)
                    _y = 0;
                else
                    _y = value;
            }
        }

    }
}
