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
            Console.WriteLine("Tu Figura");//tu jest typ zmiennej wazniejszy (podana jest w 'Main'). Zawsze z tej klasy, z której jest zmienna
        }
        public virtual void Rysuj2()
        {
            Console.WriteLine("Tu Figura"); //nie jest wazny typ zmiennej, tylko typ obiektu przy zmiennej wirtualnej
        }

    }
    class Kolo:Figura
    {
        public new void Rysuj1()
        {
            Console.WriteLine("Tu koło z Łodzi (new)");
        }
        public override void Rysuj2()
        {
            Console.WriteLine("Tu koło z Wrocławia (override)");
        }

    }
    class Kwadrat : Figura
    {
        public new void Rysuj1()
        {
            Console.WriteLine("Tu kwadrat z Łodzi (new)");
        }
        public override void Rysuj2()
        {
            Console.WriteLine("Tu kwadrat z Wrocławia (override)");
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
            Figura zmienna;//gdyby była zmienna typu 'Kolo', wtedy by wyswietlalo "kolo"
            Console.WriteLine("Jaka figura?: ");
            string s = Console.ReadLine();

            zmienna = Utworz(s);
            zmienna.Rysuj1();
            zmienna.Rysuj2();
            Console.ReadKey();

        }
    }
}
