using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Solis_HastaQueSI
{
    class Program
    {
        static void Main(string[] args)
        {
            string si;

            Console.WriteLine("DIga SI para terminar el programa");
            si = Console.ReadLine();

            while (si != "SI")
            {
                Console.WriteLine("¿Desea terminar el programa?");
                si = Console.ReadLine();
            }
            if (si == "SI")
            {
                Console.WriteLine("Hasta la vista baby");
            }

            Console.ReadKey();
        }
    }
}
