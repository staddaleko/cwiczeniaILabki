﻿using System;
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
        public Point Poczatek {set; get;}
        public int Wysokosc { get; set; }
        public int Szerokosc { get; set; }
        public abstract void Rysuj(Graphics g, Point p);//'abstract' powoduje iz jest to od razu metoda wirtualna - oczywiste
    }
    
    class Elipsa
    {

    }
}
