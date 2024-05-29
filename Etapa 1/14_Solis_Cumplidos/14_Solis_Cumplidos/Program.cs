using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Solis_Cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, contador;

            Console.WriteLine("Cuantos años tienes?");
            edad = int.Parse(Console.ReadLine());

            contador = 1;

            while (contador <= edad)
            {
                Console.WriteLine("cumpliste " + contador);
                contador++;
            }

            Console.ReadLine();
        }
    }
}
