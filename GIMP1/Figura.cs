using GIMP1;
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
        public Point Poczatek { set; get; }
        public int Wysokosc { get; set; }
        public int Szerokosc { get; set; }
        static Figura()//konstruktor statyczny sluzy tylko do inicjalizacji pol statycznych
        {
            Pedzel = Brushes.Red;
        }
        public Figura()
        {
            Wysokosc = 100;
            Szerokosc = 100;
        }
        public abstract void Rysuj(Graphics g, Point p);//'abstract' powoduje iz jest to od razu metoda wirtualna - oczywiste
    }
    class Elipsa : Figura
    {
        Brush pedzel = Figura.Pedzel;
        public override void Rysuj(Graphics g, Point p)//tu musi byc 'override', bo domyslnie jest 'new'. 'override' nadpisuje nam metode, a 'new' tylko przyslania
        {
            g.FillEllipse(pedzel, p.X, p.Y, Szerokosc, Wysokosc);
        }
    }
    class Prostokat : Figura
    {
        Brush pedzel = Figura.Pedzel;
        public override void Rysuj(Graphics g, Point p)
        {
            g.FillRectangle(pedzel, p.X, p.Y, Szerokosc, Wysokosc);
        }
    }
}
