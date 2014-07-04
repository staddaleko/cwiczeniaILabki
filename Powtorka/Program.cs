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
            Console.WriteLine("Tu koło z Wrocławia");
        }

        public new void Rysuj1()
        {
            Console.WriteLine("Tu koło z Łodzi");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Figura zmienna;

        }
    }
}
