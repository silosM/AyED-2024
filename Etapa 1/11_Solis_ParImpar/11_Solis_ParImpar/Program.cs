using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Solis_ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int entero, resto;

            Console.WriteLine("dime un numero entero y te dire si es par o inpar");
            entero = int.Parse(Console.ReadLine());

            resto = entero % 2;

            if (resto == 0)
            {
                Console.WriteLine(" tu numero es par");
            }
            else
            {
                Console.WriteLine("tu numero es impar");
            }


            Console.ReadKey();
        }
    }
}
