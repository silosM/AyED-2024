using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static string saludar(string nombre)
        {
            string saludo;
            return saludo = ("Hola "+nombre);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hola, Como te llamas?");
            string usuario = Console.ReadLine();
            Console.WriteLine(saludar(usuario));

            Console.ReadKey();
        }
    }
}
