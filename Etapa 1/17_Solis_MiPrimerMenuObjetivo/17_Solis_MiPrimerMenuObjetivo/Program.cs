using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Solis_MiPrimerMenuObjetivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            Console.WriteLine("Bienvenido/a, tenga el menu de hoy, eliga un numero de las opciones");
            Console.WriteLine("Opcion 1");
            Console.WriteLine("Opcion 2");
            Console.WriteLine("Opcion 3");

            opcion = Console.ReadLine();

            Console.Clear();

            if (opcion == "1")
            {
                Console.WriteLine("Es una salchipapa, elegiste bien");
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Buena elección, ahora le traigo su amburguesa");
            }
            else if (opcion == "3")
            {
                Console.WriteLine("Le toco un silpancho, fue una buena elección");
            }
            

            Console.ReadKey();
        }
    }
}
