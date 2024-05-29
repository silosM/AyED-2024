using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Solis_HolaNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            String Nombre;
            Console.WriteLine("Como te llamas?");
            Nombre = Console.ReadLine();
            Console.WriteLine("Hola " + Nombre);
            Console.ReadKey();
        }
    }
}
