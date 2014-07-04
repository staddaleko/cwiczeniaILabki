using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIMP1
{
    interface IRysuj
    {
        void Rysuj(Graphics g, Point p);
    }

    abstract class Figura : IRysuj
    {
        public static Brush Pedzel { set; get; }
        public Point Poczatek {set; get;}
        public int Wysokosc { get; set; }
        public int Szerokosc { get; set; }
        static Figura()
        {
            Pedzel = Brushes.Azure;
        }

        public abstract void Rysuj(Graphics g, Point p);//'abstract' powoduje iz jest to od razu metoda wirtualna - oczywiste
    }
    
    class Elipsa : Figura
    {
        Brush pedzel = Figura.Pedzel;
        public override void Rysuj(Graphics g, Point p)//tu musi byc 'override', bo domyslnie jest 'new'. 'override' nadpisuje nam metode, a 'new' tylko przyslania
        {
            
        }
    }
}
