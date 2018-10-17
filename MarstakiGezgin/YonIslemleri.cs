using MarstakiGezgin.Yonler;

namespace MarstakiGezgin
{
   public  class YonIslemleri
    {
        public static GezginYonu GezgininYonunuYarat(string yon, Gezgin gezgin)
        {
            GezginYonu gezginYonu = null;
            if (yon == "N" || yon == "n")
            {
                gezginYonu = new Kuzey(gezgin);
            }
            else if (yon == "E" || yon == "e")
            {
                gezginYonu = new Dogu(gezgin);
            }
            else if (yon == "S" || yon == "s")
            {
                gezginYonu = new Guney(gezgin);
            }
            else if (yon == "W" || yon == "w")
            {
                gezginYonu = new Bati(gezgin);
            }

            return gezginYonu;
        }

    }
}
