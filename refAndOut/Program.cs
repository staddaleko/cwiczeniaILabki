using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //string outString = "Oryginalny outString";
            //Console.WriteLine(outString);
            //outMethod(out outString);
            //Console.WriteLine(outString);

            string refString = "Oryginalny refString";
            Console.WriteLine(refString);
            refMethod(ref refString);
            Console.WriteLine(refString);
        }

        static void refMethod(ref string refString)
        {
            refString = "Nowy refString zmieniony przez metodę";
        }

        static void outMethod(out string outString)
        {
            outString = "Nowy outString zmieniony przez metodę";
        }

        
    }
}
