using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Solis_EsMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.WriteLine("Cuantos años tienes?");
            edad = int.Parse(Console.ReadLine());

            if (edad > 18)
            {
                Console.WriteLine("eres mayor de edad");
            }
            else if (edad < 18)
            {
                Console.WriteLine("eres menor de edad");
            }
            else
            {
                Console.WriteLine("tienes 18");
            }

            Console.ReadKey();
        }
    }
}
