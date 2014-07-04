using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powtorka
{
    class Figura
    {
        public void Rysuj1()
        {
            Console.WriteLine("Tu Figura");
        }
        public virtual void Rysuj2()
        {
            Console.WriteLine("Tu Figura");
        }

    }
    class Kolo:Figura
    {
        public override void Rysuj2()
        {
            Console.WriteLine("Tu koło z Wrocławia (new)");
        }

        public new void Rysuj1()
        {
            Console.WriteLine("Tu koło z Łodzi (override)");
        }


    }
    class Kwadrat : Figura
    {
        public override void Rysuj2()
        {
            Console.WriteLine("Tu kwadrat z Wrocławia (new)");
        }

        public new void Rysuj1()
        {
            Console.WriteLine("Tu kwadrat z Łodzi (override)");
        }


    }
    class Program
    {
        static Figura Utworz(string s)
        {
            switch (s.ToLower())
            {
                case "kolo": return new Kolo();
                case "kwadrat": return new Kwadrat();
            }
            return new Figura();
        }
        
        static void Main(string[] args)
        {
            Figura zmienna;

        }
    }
}
